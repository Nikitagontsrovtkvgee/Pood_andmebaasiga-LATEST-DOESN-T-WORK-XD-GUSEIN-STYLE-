using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Tooded : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");
        string kasutaja_roll = "";
        string valitud_pilt = "";
        string piltide_kaust = Path.Combine(Application.StartupPath, "..\\..\\Images");

        public Tooded(string roll)
        {
            InitializeComponent();
            kasutaja_roll = roll;

            // ПРИНУДИТЕЛЬНАЯ ПРИВЯЗКА КНОПОК (чтобы работали)
            this.btnLisa.Click += new EventHandler(btnLisa_Click);
            this.btnUuenda.Click += new EventHandler(btnUuenda_Click);
            this.btnKustuta.Click += new EventHandler(btnKustuta_Click);
            this.btnOtsiPilt.Click += new EventHandler(btnOtsiPilt_Click);
            this.btnLisaKat.Click += new EventHandler(btnLisaKat_Click);
            this.dataGridViewTooded.CellClick += new DataGridViewCellEventHandler(dataGridViewTooded_CellClick);

            this.Load += (s, e) => { NaitaAndmed(); NaitaKategooriad(); PiiraLigipaasu(); };

            txtNimetus.TextChanged += (s, e) => {
                if (dataGridViewTooded.DataSource is DataTable dt)
                    dt.DefaultView.RowFilter = string.Format("Toodenimetus LIKE '%{0}%'", txtNimetus.Text);
            };
        }

        public void NaitaAndmed()
        {
            try
            {
                if (connect.State == ConnectionState.Open) connect.Close();
                connect.Open();
                string query = "SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, K.Kategooria_nimetus FROM Tooded T JOIN Kategooria K ON T.Kategooriad_Id = K.Id";
                SqlDataAdapter adp = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (!dt.Columns.Contains("VisualPilt")) dt.Columns.Add("VisualPilt", typeof(Image));

                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        string path = Path.Combine(piltide_kaust, row["Pilt"].ToString());
                        if (File.Exists(path)) row["VisualPilt"] = new Bitmap(Image.FromFile(path), new Size(50, 50));
                    }
                    catch { }
                }

                dataGridViewTooded.DataSource = dt;
                dataGridViewTooded.Columns["Id"].Visible = false;
                dataGridViewTooded.Columns["Pilt"].Visible = false;

                var imgCol = (DataGridViewImageColumn)dataGridViewTooded.Columns["VisualPilt"];
                imgCol.DisplayIndex = 0;
                imgCol.HeaderText = "Toode";
                dataGridViewTooded.RowTemplate.Height = 60;
            }
            catch (Exception ex) { MessageBox.Show("Data Error: " + ex.Message); }
            finally { connect.Close(); }
        }

        private void btnOtsiPilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                valitud_pilt = Path.GetFileName(open.FileName);
                picPilt.Image = Image.FromFile(open.FileName);
                if (!Directory.Exists(piltide_kaust)) Directory.CreateDirectory(piltide_kaust);
                string targetPath = Path.Combine(piltide_kaust, valitud_pilt);
                if (!File.Exists(targetPath)) File.Copy(open.FileName, targetPath);
            }
        }

        private void btnLisa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tooded(Toodenimetus, Kogus, Hind, Pilt, Kategooriad_Id) VALUES(@t, @ko, @h, @p, @ka)", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@t", txtNimetus.Text);
                cmd.Parameters.AddWithValue("@ko", txtKogus.Text);
                cmd.Parameters.AddWithValue("@h", txtHind.Text.Replace(',', '.'));
                cmd.Parameters.AddWithValue("@p", valitud_pilt);
                cmd.Parameters.AddWithValue("@ka", cmbKategooria.SelectedValue);
                cmd.ExecuteNonQuery();
                connect.Close();
                NaitaAndmed();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); connect.Close(); }
        }

        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (dataGridViewTooded.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewTooded.SelectedRows[0].Cells["Id"].Value);
                SqlCommand cmd = new SqlCommand("DELETE FROM Tooded WHERE Id=@id", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connect.Close();
                NaitaAndmed();
            }
        }

        private void dataGridViewTooded_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridViewTooded.Rows[e.RowIndex];
                txtNimetus.Text = r.Cells["Toodenimetus"].Value.ToString();
                txtKogus.Text = r.Cells["Kogus"].Value.ToString();
                txtHind.Text = r.Cells["Hind"].Value.ToString();
                cmbKategooria.Text = r.Cells["Kategooria_nimetus"].Value.ToString();
                try
                {
                    picPilt.Image = Image.FromFile(Path.Combine(piltide_kaust, r.Cells["Pilt"].Value.ToString()));
                }
                catch { picPilt.Image = null; }
            }
        }

        private void btnLisaKat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Kategooria(Kategooria_nimetus) VALUES(@k)", connect);
            connect.Open();
            cmd.Parameters.AddWithValue("@k", txtUusKat.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            NaitaKategooriad();
        }

        public void NaitaKategooriad()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmbKategooria.DataSource = dt;
            cmbKategooria.DisplayMember = "Kategooria_nimetus";
            cmbKategooria.ValueMember = "Id";
        }

        private void PiiraLigipaasu()
        {
            bool isAdmin = (kasutaja_roll == "Admin");
            btnLisa.Visible = btnUuenda.Visible = btnKustuta.Visible = btnLisaKat.Visible = isAdmin;
        }
    }
}
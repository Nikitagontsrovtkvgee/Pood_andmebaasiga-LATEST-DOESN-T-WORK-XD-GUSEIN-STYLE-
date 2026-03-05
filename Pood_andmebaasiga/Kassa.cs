using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Pood_andmebaasiga
{
    public partial class Kassa : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");
        DataTable korvTable = new DataTable();

        public Kassa()
        {
            InitializeComponent();
            korvTable.Columns.Add("Id", typeof(int));
            korvTable.Columns.Add("Toode");
            korvTable.Columns.Add("Hind", typeof(double));
            dataGridViewKorv.DataSource = korvTable;
            LoadShop();
        }

        private void LoadShop()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Toodenimetus, Hind, Kogus FROM Tooded", connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewShop.DataSource = dt;
            if (dataGridViewShop.Columns["Id"] != null) dataGridViewShop.Columns["Id"].Visible = false;
        }

        private void btnLisaKorvi_Click(object sender, EventArgs e)
        {
            if (dataGridViewShop.SelectedRows.Count > 0)
            {
                var row = dataGridViewShop.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                int laos = Convert.ToInt32(row.Cells["Kogus"].Value);

                if (laos > 0)
                {
                    korvTable.Rows.Add(id, row.Cells["Toodenimetus"].Value, row.Cells["Hind"].Value);
                    UpdateStock(id, -1);
                    LoadShop();
                }
                else { MessageBox.Show("Toode on otsas!"); }
            }
        }

        private void UpdateStock(int id, int change)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tooded SET Kogus = Kogus + @change WHERE Id = @id", connect);
            cmd.Parameters.AddWithValue("@change", change);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        private void btnOsta_Click(object sender, EventArgs e)
        {
            if (korvTable.Rows.Count == 0) return;

            string file = Path.Combine(Application.StartupPath, "tsekk.pdf");
            Document doc = new Document();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));
                doc.Open();
                doc.Add(new Paragraph("OSTUTSEKK\n" + DateTime.Now.ToString()));
                doc.Add(new Paragraph("--------------------------"));

                double total = 0;
                foreach (DataRow r in korvTable.Rows)
                {
                    doc.Add(new Paragraph($"{r["Toode"]} - {r["Hind"]} EUR"));
                    total += Convert.ToDouble(r["Hind"]);
                }

                doc.Add(new Paragraph("--------------------------"));
                doc.Add(new Paragraph("KOKKU: " + total + " EUR"));
                doc.Close();

                korvTable.Clear();
                MessageBox.Show("Tšekk salvestatud: " + file);
            }
            catch (Exception ex) { MessageBox.Show("Viga: " + ex.Message); }
        }
    }
}
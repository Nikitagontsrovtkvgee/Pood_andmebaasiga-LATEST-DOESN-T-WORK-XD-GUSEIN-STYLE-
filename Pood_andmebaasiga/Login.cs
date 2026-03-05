using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogiSisse_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT Roll FROM Kasutajad WHERE Kasutajanimi=@nimi AND Parool=@parool", connect);
                cmd.Parameters.AddWithValue("@nimi", txtKasutaja.Text);
                cmd.Parameters.AddWithValue("@parool", txtParool.Text);

                object result = cmd.ExecuteScalar();
                connect.Close();

                if (result != null)
                {
                    string roll = result.ToString();
                    MessageBox.Show("Tere tulemast, " + roll + "!");
                    Tooded peavorm = new Tooded(roll);
                    peavorm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vale kasutajanimi või parool!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }
    }
}
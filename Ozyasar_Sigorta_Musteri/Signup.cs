using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Ozyasar_Sigorta_Musteri
{
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=OZYASAR\\SQLEXPRESS;Initial Catalog=OZYASAR;Integrated Security=True");
        public Signup()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

            if (signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Tüm Alanlara Veri Girişi Yapmalısınız", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '"
                                + signup_username.Text.Trim() + "'"; // admin tablomuzun adı
                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);


                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " Zaten Kayıtlı", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (username, password, date_created) " +
                                    "VALUES(@username, @pass, @date)";

                                DateTime date = DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Kayıt Başarı ile Tamamlandı", "BİLGİ MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Formu değiştirir
                                    Form1 lForm = new Form1();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veri Tabanı Bağlantı Hatası" + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            
               
            }
        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showpass.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }
    }
}

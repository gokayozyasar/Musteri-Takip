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
using System.Diagnostics.Eventing.Reader;

namespace Ozyasar_Sigorta_Musteri
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=OZYASAR\\SQLEXPRESS;Initial Catalog=OZYASAR;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "" )
            {
                MessageBox.Show("Lütfen Tüm Alanlara Veri Girişlerini Yapınız.","Hata Mesajı",MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM admin WHERE username = @username AND password  =  @pass ";
                        using(SqlCommand cmd = new SqlCommand(selectData,connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue ("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            
                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Giriş Başarıyla Tamamlandı.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                        
                            else
                            {
                                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                            
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Bağlantı Hatası" + ex , "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    { 
                        connect.Close(); 
                    }

                }
            }
        }
    }
}

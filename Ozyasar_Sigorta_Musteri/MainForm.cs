using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ozyasar_Sigorta_Musteri
{
    public partial class MainForm : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public MainForm()
        {
            InitializeComponent();
        }
        void MusteriGetir()
        {
            baglanti = new SqlConnection("Data Source=OZYASAR\\SQLEXPRESS;Initial Catalog=OZYASAR;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri ",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'oZYASARDataSet.Tbl_Musteri' table. You can move, or remove it, as needed.
            this.tbl_MusteriTableAdapter.Fill(this.oZYASARDataSet.Tbl_Musteri);

            MusteriGetir();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_MusteriTableAdapter.Fill(this.oZYASARDataSet.Tbl_Musteri);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Txtid.Text =dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtTc.Text =dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtAdSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MskDogum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Msk_Telefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtUavt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Cmb_Sigorta.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTc.Text) || string.IsNullOrWhiteSpace(TxtAdSoyad.Text))
            {
                MessageBox.Show("T.C. Kimlik No ve Ad Soyad alanları boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // CheckBox değerlerini toplayarak Cmb_Sigorta'ya yazma
            StringBuilder sigortaBuilder = new StringBuilder();

            if (chkDASK.Checked) sigortaBuilder.Append("DASK, ");
            if (chkTrafik.Checked) sigortaBuilder.Append("TRAFİK, ");
            if (chkKasko.Checked) sigortaBuilder.Append("KASKO, ");
            if (chkKonut.Checked) sigortaBuilder.Append("KONUT, ");
            if (chkSeyahat.Checked) sigortaBuilder.Append("SEYAHAT, ");
            if (chkYSS.Checked) sigortaBuilder.Append("YSS, ");

            // Sonundaki virgülü kaldır
            if (sigortaBuilder.Length > 0)
            {
                sigortaBuilder.Length -= 2; // Son iki karakter (", ") silinir
            }

            // Cmb_Sigorta'ya atama
            Cmb_Sigorta.Text = sigortaBuilder.ToString();

            // Önce aynı TCKimlikNo'ya sahip bir kayıt var mı kontrol et
            string kontrolSorgu = "SELECT COUNT(*) FROM Tbl_Musteri WHERE MusteriKimlik = @kimlik";
            SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, baglanti);

            // TCKimlikNo parametresini ekle
            kontrolKomut.Parameters.AddWithValue("@kimlik", TxtTc.Text);

            baglanti.Open();

            // Aynı kimliğe sahip kaç kayıt var?
            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

            if (kayitSayisi > 0)
            {
                // Eğer aynı TCKimlikNo varsa, kayıt ekleme
                MessageBox.Show("Bu T.C. Kimlik No'ya sahip müşteri zaten mevcut!", "Kayıt Eklenemiyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Aynı kimlik yoksa, yeni kayıt ekle
                string sorgu = "INSERT INTO Tbl_Musteri (MusteriKimlik,MusteriAdsoyad,MusteriDogum,MusteriTelefon,MusteriEmail,MusteriUavt,MusteriSigorta) VALUES (@kimlik,@adsoyad,@dogum,@telefon,@email,@uavt,@sigorta)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@kimlik", TxtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
                komut.Parameters.AddWithValue("@dogum", MskDogum.Text);
                komut.Parameters.AddWithValue("@telefon", Msk_Telefon.Text);
                komut.Parameters.AddWithValue("@email",txtEmail.Text);
                komut.Parameters.AddWithValue("@uavt",txtUavt.Text);
                komut.Parameters.AddWithValue("@sigorta", Cmb_Sigorta.Text);

                komut.ExecuteNonQuery();  // Yeni müşteri ekleniyor
                MessageBox.Show("Yeni müşteri başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Yeni müşteri eklendikten sonra listeyi güncelle
                MusteriGetir();
            }

            // Bağlantıyı kapat
            baglanti.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            // Silme işlemi için kullanıcıdan onay al
            DialogResult dialogResult = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Silme sorgusu
                string sorgu = "DELETE FROM Tbl_Musteri WHERE id=@id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // id parametresi ekleniyor
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(Txtid.Text));

                // Veritabanı bağlantısı açılıyor
                baglanti.Open();

                // Silme işlemi gerçekleştiriliyor ve etkilenen satır sayısını alıyoruz
                int sonuc = komut.ExecuteNonQuery();

                // Veritabanı bağlantısı kapatılıyor
                baglanti.Close();

                // Silme işlemi başarılıysa mesaj gösteriliyor
                if (sonuc > 0)
                {
                    MessageBox.Show("Müşteri başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Müşteri silinemedi. Lütfen id'yi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Müşteri listesini güncelle
                MusteriGetir();
            }
            else
            {
                // Kullanıcı silme işlemini iptal ettiğinde bilgi mesajı göster
                MessageBox.Show("Silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Txtid.Text = "";
            TxtTc.Text = "";
            TxtAdSoyad.Text = "";
            MskDogum.Text = "";
            Msk_Telefon.Text = "";
            Cmb_Sigorta.Text = "";
            chkDASK .Checked = false;
            chkTrafik.Checked=false;
            chkKasko.Checked = false;
            chkKonut.Checked=false;
            chkSeyahat.Checked = false;
            chkYSS.Checked=false ;
            TxtTc.Focus();
            
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtid.Text))
            {
                MessageBox.Show("Güncellenecek müşteri ID'si boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // CheckBox değerlerini toplayarak Cmb_Sigorta'ya yazma
            StringBuilder sigortaBuilder = new StringBuilder();

            if (chkDASK.Checked) sigortaBuilder.Append("DASK, ");
            if (chkTrafik.Checked) sigortaBuilder.Append("TRAFİK, ");
            if (chkKasko.Checked) sigortaBuilder.Append("KASKO, ");
            if (chkKonut.Checked) sigortaBuilder.Append("KONUT, ");
            if (chkSeyahat.Checked) sigortaBuilder.Append("SEYAHAT, ");
            if (chkYSS.Checked) sigortaBuilder.Append("YSS, ");

            // Sonundaki virgülü kaldır
            if (sigortaBuilder.Length > 0)
            {
                sigortaBuilder.Length -= 2; // Son iki karakter (", ") silinir
            }

            // Cmb_Sigorta'ya atama
            Cmb_Sigorta.Text = sigortaBuilder.ToString();

            // Güncelleme sorgusu
            string sorgu = "UPDATE Tbl_Musteri SET MusteriKimlik = @kimlik, MusteriAdsoyad = @adsoyad, MusteriDogum = @dogum, MusteriTelefon = @telefon,MusteriEmail = @email, MusteriUavt = @uavt, MusteriSigorta = @sigorta WHERE id = @id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(Txtid.Text));
            komut.Parameters.AddWithValue("@kimlik", TxtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@dogum", MskDogum.Text);
            komut.Parameters.AddWithValue("@telefon", Msk_Telefon.Text);
            komut.Parameters.AddWithValue("@email",txtEmail.Text);
            komut.Parameters.AddWithValue("@uavt",txtUavt.Text);
            komut.Parameters.AddWithValue("@sigorta", Cmb_Sigorta.Text);

            try
            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MusteriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            string aramaTerimi = TxtArama.Text.Trim(); // Kullanıcının girdiği arama terimini al

            // Arama sorgusu
            string sorgu = "SELECT * FROM Tbl_Musteri WHERE MusteriKimlik LIKE @arama OR MusteriAdsoyad LIKE @arama";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@arama", "%" + aramaTerimi + "%"); // Arama terimi için parametre ekle

                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo; // Sonuçları DataGridView'a ata
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama sırasında bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }
    }
}

namespace Ozyasar_Sigorta_Musteri
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUavt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.chkSeyahat = new System.Windows.Forms.CheckBox();
            this.chkYSS = new System.Windows.Forms.CheckBox();
            this.chkKonut = new System.Windows.Forms.CheckBox();
            this.chkKasko = new System.Windows.Forms.CheckBox();
            this.chkTrafik = new System.Windows.Forms.CheckBox();
            this.chkDASK = new System.Windows.Forms.CheckBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cmb_Sigorta = new System.Windows.Forms.ComboBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Msk_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_İstatistik = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriUavtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSigortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oZYASARDataSet = new Ozyasar_Sigorta_Musteri.OZYASARDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbl_MusteriTableAdapter = new Ozyasar_Sigorta_Musteri.OZYASARDataSetTableAdapters.Tbl_MusteriTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZYASARDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(335, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖZYAŞAR SİGORTA MÜŞTERİ TAKİP SİSTEMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 62);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1148, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtUavt);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.chkSeyahat);
            this.groupBox1.Controls.Add(this.chkYSS);
            this.groupBox1.Controls.Add(this.chkKonut);
            this.groupBox1.Controls.Add(this.chkKasko);
            this.groupBox1.Controls.Add(this.chkTrafik);
            this.groupBox1.Controls.Add(this.chkDASK);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Cmb_Sigorta);
            this.groupBox1.Controls.Add(this.TxtTc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Msk_Telefon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MskDogum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAdSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(546, 393);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtUavt
            // 
            this.txtUavt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUavt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUavt.Location = new System.Drawing.Point(157, 242);
            this.txtUavt.Margin = new System.Windows.Forms.Padding(2);
            this.txtUavt.Multiline = true;
            this.txtUavt.Name = "txtUavt";
            this.txtUavt.Size = new System.Drawing.Size(300, 31);
            this.txtUavt.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(157, 208);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 31);
            this.txtEmail.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(88, 251);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "UAVT :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(84, 217);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 21);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "E Mail :";
            // 
            // chkSeyahat
            // 
            this.chkSeyahat.AutoSize = true;
            this.chkSeyahat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSeyahat.Location = new System.Drawing.Point(304, 345);
            this.chkSeyahat.Name = "chkSeyahat";
            this.chkSeyahat.Size = new System.Drawing.Size(69, 17);
            this.chkSeyahat.TabIndex = 17;
            this.chkSeyahat.Text = "SEYAHAT";
            this.chkSeyahat.UseVisualStyleBackColor = true;
            // 
            // chkYSS
            // 
            this.chkYSS.AutoSize = true;
            this.chkYSS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkYSS.Location = new System.Drawing.Point(238, 345);
            this.chkYSS.Name = "chkYSS";
            this.chkYSS.Size = new System.Drawing.Size(43, 17);
            this.chkYSS.TabIndex = 16;
            this.chkYSS.Text = "YSS";
            this.chkYSS.UseVisualStyleBackColor = true;
            // 
            // chkKonut
            // 
            this.chkKonut.AutoSize = true;
            this.chkKonut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkKonut.Location = new System.Drawing.Point(169, 345);
            this.chkKonut.Name = "chkKonut";
            this.chkKonut.Size = new System.Drawing.Size(63, 17);
            this.chkKonut.TabIndex = 15;
            this.chkKonut.Text = "KONUT";
            this.chkKonut.UseVisualStyleBackColor = true;
            // 
            // chkKasko
            // 
            this.chkKasko.AutoSize = true;
            this.chkKasko.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkKasko.Location = new System.Drawing.Point(304, 318);
            this.chkKasko.Name = "chkKasko";
            this.chkKasko.Size = new System.Drawing.Size(60, 17);
            this.chkKasko.TabIndex = 14;
            this.chkKasko.Text = "KASKO";
            this.chkKasko.UseVisualStyleBackColor = true;
            // 
            // chkTrafik
            // 
            this.chkTrafik.AutoSize = true;
            this.chkTrafik.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTrafik.Location = new System.Drawing.Point(238, 318);
            this.chkTrafik.Name = "chkTrafik";
            this.chkTrafik.Size = new System.Drawing.Size(61, 17);
            this.chkTrafik.TabIndex = 13;
            this.chkTrafik.Text = "TRAFİK";
            this.chkTrafik.UseVisualStyleBackColor = true;
            // 
            // chkDASK
            // 
            this.chkDASK.AutoSize = true;
            this.chkDASK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDASK.Location = new System.Drawing.Point(169, 318);
            this.chkDASK.Name = "chkDASK";
            this.chkDASK.Size = new System.Drawing.Size(53, 17);
            this.chkDASK.TabIndex = 12;
            this.chkDASK.Text = "DASK";
            this.chkDASK.UseVisualStyleBackColor = true;
            // 
            // Txtid
            // 
            this.Txtid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtid.Enabled = false;
            this.Txtid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Location = new System.Drawing.Point(157, 30);
            this.Txtid.Margin = new System.Windows.Forms.Padding(2);
            this.Txtid.Multiline = true;
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(300, 31);
            this.Txtid.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(113, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "İd :";
            // 
            // Cmb_Sigorta
            // 
            this.Cmb_Sigorta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Sigorta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmb_Sigorta.FormattingEnabled = true;
            this.Cmb_Sigorta.Location = new System.Drawing.Point(157, 276);
            this.Cmb_Sigorta.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_Sigorta.Name = "Cmb_Sigorta";
            this.Cmb_Sigorta.Size = new System.Drawing.Size(300, 29);
            this.Cmb_Sigorta.TabIndex = 11;
            // 
            // TxtTc
            // 
            this.TxtTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTc.Location = new System.Drawing.Point(157, 64);
            this.TxtTc.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTc.Multiline = true;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(300, 31);
            this.TxtTc.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sigorta Bilgisi :";
            // 
            // Msk_Telefon
            // 
            this.Msk_Telefon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Msk_Telefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Msk_Telefon.Location = new System.Drawing.Point(157, 170);
            this.Msk_Telefon.Margin = new System.Windows.Forms.Padding(2);
            this.Msk_Telefon.Mask = "(99)(999) 000-0000";
            this.Msk_Telefon.Name = "Msk_Telefon";
            this.Msk_Telefon.Size = new System.Drawing.Size(300, 29);
            this.Msk_Telefon.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefon Numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // MskDogum
            // 
            this.MskDogum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MskDogum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogum.Location = new System.Drawing.Point(157, 132);
            this.MskDogum.Margin = new System.Windows.Forms.Padding(2);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(300, 29);
            this.MskDogum.TabIndex = 7;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(60, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ad Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tckn / Ykn / Vkn :";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdSoyad.Location = new System.Drawing.Point(157, 98);
            this.TxtAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdSoyad.Multiline = true;
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(300, 31);
            this.TxtAdSoyad.TabIndex = 6;
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ekle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Ekle.Location = new System.Drawing.Point(33, 40);
            this.Btn_Ekle.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(125, 30);
            this.Btn_Ekle.TabIndex = 12;
            this.Btn_Ekle.Text = "EKLE";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guncelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.Location = new System.Drawing.Point(33, 126);
            this.Btn_Guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(125, 30);
            this.Btn_Guncelle.TabIndex = 14;
            this.Btn_Guncelle.Text = "GÜNCELLE";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click_1);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Location = new System.Drawing.Point(33, 169);
            this.Btn_Sil.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(125, 30);
            this.Btn_Sil.TabIndex = 15;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_İstatistik);
            this.groupBox2.Controls.Add(this.Btn_Sil);
            this.groupBox2.Controls.Add(this.Btn_Ekle);
            this.groupBox2.Controls.Add(this.Btn_Guncelle);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(561, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(201, 387);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // Btn_İstatistik
            // 
            this.Btn_İstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_İstatistik.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_İstatistik.Location = new System.Drawing.Point(33, 212);
            this.Btn_İstatistik.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_İstatistik.Name = "Btn_İstatistik";
            this.Btn_İstatistik.Size = new System.Drawing.Size(125, 30);
            this.Btn_İstatistik.TabIndex = 16;
            this.Btn_İstatistik.Text = "İSTATİSTİK";
            this.Btn_İstatistik.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(33, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.musteriKimlikDataGridViewTextBoxColumn,
            this.musteriAdsoyadDataGridViewTextBoxColumn,
            this.musteriDogumDataGridViewTextBoxColumn,
            this.musteriTelefonDataGridViewTextBoxColumn,
            this.musteriEmailDataGridViewTextBoxColumn,
            this.musteriUavtDataGridViewTextBoxColumn,
            this.musteriSigortaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMusteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 473);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 323);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // musteriKimlikDataGridViewTextBoxColumn
            // 
            this.musteriKimlikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.musteriKimlikDataGridViewTextBoxColumn.DataPropertyName = "MusteriKimlik";
            this.musteriKimlikDataGridViewTextBoxColumn.FillWeight = 110F;
            this.musteriKimlikDataGridViewTextBoxColumn.HeaderText = "Kimlik Numarası";
            this.musteriKimlikDataGridViewTextBoxColumn.Name = "musteriKimlikDataGridViewTextBoxColumn";
            this.musteriKimlikDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriKimlikDataGridViewTextBoxColumn.Width = 159;
            // 
            // musteriAdsoyadDataGridViewTextBoxColumn
            // 
            this.musteriAdsoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.musteriAdsoyadDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdsoyad";
            this.musteriAdsoyadDataGridViewTextBoxColumn.FillWeight = 110F;
            this.musteriAdsoyadDataGridViewTextBoxColumn.HeaderText = "Ad Soyad";
            this.musteriAdsoyadDataGridViewTextBoxColumn.Name = "musteriAdsoyadDataGridViewTextBoxColumn";
            this.musteriAdsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriAdsoyadDataGridViewTextBoxColumn.Width = 106;
            // 
            // musteriDogumDataGridViewTextBoxColumn
            // 
            this.musteriDogumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.musteriDogumDataGridViewTextBoxColumn.DataPropertyName = "MusteriDogum";
            this.musteriDogumDataGridViewTextBoxColumn.FillWeight = 110F;
            this.musteriDogumDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.musteriDogumDataGridViewTextBoxColumn.Name = "musteriDogumDataGridViewTextBoxColumn";
            this.musteriDogumDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriDogumDataGridViewTextBoxColumn.Width = 137;
            // 
            // musteriTelefonDataGridViewTextBoxColumn
            // 
            this.musteriTelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.musteriTelefonDataGridViewTextBoxColumn.DataPropertyName = "MusteriTelefon";
            this.musteriTelefonDataGridViewTextBoxColumn.FillWeight = 110F;
            this.musteriTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.musteriTelefonDataGridViewTextBoxColumn.Name = "musteriTelefonDataGridViewTextBoxColumn";
            this.musteriTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriTelefonDataGridViewTextBoxColumn.Width = 168;
            // 
            // musteriEmailDataGridViewTextBoxColumn
            // 
            this.musteriEmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.musteriEmailDataGridViewTextBoxColumn.DataPropertyName = "MusteriEmail";
            this.musteriEmailDataGridViewTextBoxColumn.FillWeight = 110F;
            this.musteriEmailDataGridViewTextBoxColumn.HeaderText = "Email Adresi";
            this.musteriEmailDataGridViewTextBoxColumn.Name = "musteriEmailDataGridViewTextBoxColumn";
            this.musteriEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriUavtDataGridViewTextBoxColumn
            // 
            this.musteriUavtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.musteriUavtDataGridViewTextBoxColumn.DataPropertyName = "MusteriUavt";
            this.musteriUavtDataGridViewTextBoxColumn.FillWeight = 110F;
            this.musteriUavtDataGridViewTextBoxColumn.HeaderText = "Uavt Kodu";
            this.musteriUavtDataGridViewTextBoxColumn.Name = "musteriUavtDataGridViewTextBoxColumn";
            this.musteriUavtDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriUavtDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // musteriSigortaDataGridViewTextBoxColumn
            // 
            this.musteriSigortaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.musteriSigortaDataGridViewTextBoxColumn.DataPropertyName = "MusteriSigorta";
            this.musteriSigortaDataGridViewTextBoxColumn.FillWeight = 150F;
            this.musteriSigortaDataGridViewTextBoxColumn.HeaderText = "Sigorta Bilgisi";
            this.musteriSigortaDataGridViewTextBoxColumn.Name = "musteriSigortaDataGridViewTextBoxColumn";
            this.musteriSigortaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "Tbl_Musteri";
            this.tblMusteriBindingSource.DataSource = this.oZYASARDataSet;
            // 
            // oZYASARDataSet
            // 
            this.oZYASARDataSet.DataSetName = "OZYASARDataSet";
            this.oZYASARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TxtArama);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(787, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 163);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgi Sorgulama";
            // 
            // TxtArama
            // 
            this.TxtArama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtArama.Location = new System.Drawing.Point(21, 64);
            this.TxtArama.Multiline = true;
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(178, 35);
            this.TxtArama.TabIndex = 17;
            this.TxtArama.TextChanged += new System.EventHandler(this.TxtArama_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sorgulamak İstediğiniz Bilgiyi Giriniz :";
            // 
            // tbl_MusteriTableAdapter
            // 
            this.tbl_MusteriTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1180, 807);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZYASARDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cmb_Sigorta;
        private System.Windows.Forms.MaskedTextBox Msk_Telefon;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_İstatistik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSeyahat;
        private System.Windows.Forms.CheckBox chkYSS;
        private System.Windows.Forms.CheckBox chkKonut;
        private System.Windows.Forms.CheckBox chkKasko;
        private System.Windows.Forms.CheckBox chkTrafik;
        private System.Windows.Forms.CheckBox chkDASK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUavt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEmail;
        private OZYASARDataSet oZYASARDataSet;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        private OZYASARDataSetTableAdapters.Tbl_MusteriTableAdapter tbl_MusteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriUavtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSigortaDataGridViewTextBoxColumn;
    }
}
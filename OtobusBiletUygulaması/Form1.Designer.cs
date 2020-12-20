namespace OtobusBiletUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.labelSoy = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonYardim = new System.Windows.Forms.Button();
            this.buttonBilet = new System.Windows.Forms.Button();
            this.buttonSefer = new System.Windows.Forms.Button();
            this.groupBoxSefer = new System.Windows.Forms.GroupBox();
            this.groupBoxSefer3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.labelFirma3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBoxSefer2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFirma2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxSefer1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.labelSaat = new System.Windows.Forms.Label();
            this.labelFirmaAdi = new System.Windows.Forms.Label();
            this.labelNereye = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelNereden = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxTarih = new System.Windows.Forms.GroupBox();
            this.groupBoxNereye = new System.Windows.Forms.GroupBox();
            this.comboBoxNereden = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxNereye = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Nereye = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nereden = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelYil = new System.Windows.Forms.Label();
            this.labelAy = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelGun = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MenuResim = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSefer.SuspendLayout();
            this.groupBoxSefer3.SuspendLayout();
            this.groupBoxSefer2.SuspendLayout();
            this.groupBoxSefer1.SuspendLayout();
            this.groupBoxTarih.SuspendLayout();
            this.groupBoxNereye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonCikis);
            this.groupBox1.Controls.Add(this.buttonYardim);
            this.groupBox1.Controls.Add(this.buttonBilet);
            this.groupBox1.Controls.Add(this.buttonSefer);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 578);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTel);
            this.groupBox2.Controls.Add(this.labelTc);
            this.groupBox2.Controls.Add(this.labelSoy);
            this.groupBox2.Controls.Add(this.labelAd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Bilgileri";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(6, 94);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(36, 22);
            this.labelTel.TabIndex = 3;
            this.labelTel.Text = "Tel";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(6, 72);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(35, 22);
            this.labelTc.TabIndex = 2;
            this.labelTc.Text = "TC";
            // 
            // labelSoy
            // 
            this.labelSoy.AutoSize = true;
            this.labelSoy.Location = new System.Drawing.Point(6, 50);
            this.labelSoy.Name = "labelSoy";
            this.labelSoy.Size = new System.Drawing.Size(73, 22);
            this.labelSoy.TabIndex = 1;
            this.labelSoy.Text = "SOYAD";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(6, 28);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(35, 22);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "AD";
            // 
            // buttonCikis
            // 
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCikis.ImageIndex = 3;
            this.buttonCikis.ImageList = this.MenuResim;
            this.buttonCikis.Location = new System.Drawing.Point(6, 454);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(212, 98);
            this.buttonCikis.TabIndex = 4;
            this.buttonCikis.Text = "ÇIKIŞ            ";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonYardim
            // 
            this.buttonYardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonYardim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYardim.ImageIndex = 4;
            this.buttonYardim.ImageList = this.MenuResim;
            this.buttonYardim.Location = new System.Drawing.Point(6, 350);
            this.buttonYardim.Name = "buttonYardim";
            this.buttonYardim.Size = new System.Drawing.Size(212, 98);
            this.buttonYardim.TabIndex = 3;
            this.buttonYardim.Text = "İLETİŞİM/YARDIM";
            this.buttonYardim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYardim.UseVisualStyleBackColor = true;
            this.buttonYardim.Click += new System.EventHandler(this.buttonYardim_Click);
            // 
            // buttonBilet
            // 
            this.buttonBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonBilet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBilet.ImageIndex = 5;
            this.buttonBilet.ImageList = this.MenuResim;
            this.buttonBilet.Location = new System.Drawing.Point(6, 246);
            this.buttonBilet.Name = "buttonBilet";
            this.buttonBilet.Size = new System.Drawing.Size(212, 98);
            this.buttonBilet.TabIndex = 2;
            this.buttonBilet.Text = "BİLETLERİM";
            this.buttonBilet.UseVisualStyleBackColor = true;
            this.buttonBilet.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSefer
            // 
            this.buttonSefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSefer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSefer.ImageIndex = 6;
            this.buttonSefer.ImageList = this.MenuResim;
            this.buttonSefer.Location = new System.Drawing.Point(6, 142);
            this.buttonSefer.Name = "buttonSefer";
            this.buttonSefer.Size = new System.Drawing.Size(212, 98);
            this.buttonSefer.TabIndex = 1;
            this.buttonSefer.Text = "SEFERLER";
            this.buttonSefer.UseVisualStyleBackColor = true;
            this.buttonSefer.Click += new System.EventHandler(this.buttonSefer_Click);
            // 
            // groupBoxSefer
            // 
            this.groupBoxSefer.Controls.Add(this.groupBoxSefer3);
            this.groupBoxSefer.Controls.Add(this.groupBoxSefer2);
            this.groupBoxSefer.Controls.Add(this.groupBoxSefer1);
            this.groupBoxSefer.Controls.Add(this.button4);
            this.groupBoxSefer.Controls.Add(this.groupBoxTarih);
            this.groupBoxSefer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxSefer.Location = new System.Drawing.Point(249, 12);
            this.groupBoxSefer.Name = "groupBoxSefer";
            this.groupBoxSefer.Size = new System.Drawing.Size(704, 578);
            this.groupBoxSefer.TabIndex = 2;
            this.groupBoxSefer.TabStop = false;
            this.groupBoxSefer.Text = "Seferler";
            this.groupBoxSefer.Enter += new System.EventHandler(this.groupBoxSefer_Enter);
            // 
            // groupBoxSefer3
            // 
            this.groupBoxSefer3.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxSefer3.Controls.Add(this.button5);
            this.groupBoxSefer3.Controls.Add(this.label12);
            this.groupBoxSefer3.Controls.Add(this.labelFirma3);
            this.groupBoxSefer3.Controls.Add(this.label14);
            this.groupBoxSefer3.Controls.Add(this.label15);
            this.groupBoxSefer3.Controls.Add(this.label16);
            this.groupBoxSefer3.Location = new System.Drawing.Point(6, 386);
            this.groupBoxSefer3.Name = "groupBoxSefer3";
            this.groupBoxSefer3.Size = new System.Drawing.Size(692, 91);
            this.groupBoxSefer3.TabIndex = 8;
            this.groupBoxSefer3.TabStop = false;
            this.groupBoxSefer3.Text = "Sefer 3";
            // 
            // button5
            // 
            this.button5.ImageKey = "(yok)";
            this.button5.ImageList = this.MenuResim;
            this.button5.Location = new System.Drawing.Point(203, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "Onayla / Devam Et";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label12.Location = new System.Drawing.Point(203, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 31);
            this.label12.TabIndex = 5;
            this.label12.Text = "Saat";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirma3
            // 
            this.labelFirma3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirma3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelFirma3.Location = new System.Drawing.Point(10, 17);
            this.labelFirma3.Name = "labelFirma3";
            this.labelFirma3.Size = new System.Drawing.Size(142, 31);
            this.labelFirma3.TabIndex = 4;
            this.labelFirma3.Text = "FİRMA ADİ";
            this.labelFirma3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label14.Location = new System.Drawing.Point(549, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 41);
            this.label14.TabIndex = 3;
            this.label14.Text = "label7";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label15.Location = new System.Drawing.Point(22, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 31);
            this.label15.TabIndex = 2;
            this.label15.Text = "FİYAT";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label16.Location = new System.Drawing.Point(406, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 41);
            this.label16.TabIndex = 0;
            this.label16.Text = "label6";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxSefer2
            // 
            this.groupBoxSefer2.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxSefer2.Controls.Add(this.button6);
            this.groupBoxSefer2.Controls.Add(this.label6);
            this.groupBoxSefer2.Controls.Add(this.labelFirma2);
            this.groupBoxSefer2.Controls.Add(this.label9);
            this.groupBoxSefer2.Controls.Add(this.label10);
            this.groupBoxSefer2.Controls.Add(this.label11);
            this.groupBoxSefer2.Location = new System.Drawing.Point(6, 289);
            this.groupBoxSefer2.Name = "groupBoxSefer2";
            this.groupBoxSefer2.Size = new System.Drawing.Size(692, 91);
            this.groupBoxSefer2.TabIndex = 8;
            this.groupBoxSefer2.TabStop = false;
            this.groupBoxSefer2.Text = "Sefer 2";
            // 
            // button6
            // 
            this.button6.ImageList = this.MenuResim;
            this.button6.Location = new System.Drawing.Point(203, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 31);
            this.button6.TabIndex = 7;
            this.button6.Text = "Onayla / Devam Et";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(203, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saat";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirma2
            // 
            this.labelFirma2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelFirma2.Location = new System.Drawing.Point(10, 17);
            this.labelFirma2.Name = "labelFirma2";
            this.labelFirma2.Size = new System.Drawing.Size(142, 31);
            this.labelFirma2.TabIndex = 4;
            this.labelFirma2.Text = "FİRMA ADİ";
            this.labelFirma2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(549, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 41);
            this.label9.TabIndex = 3;
            this.label9.Text = "label7";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(22, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "FİYAT";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(406, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 41);
            this.label11.TabIndex = 0;
            this.label11.Text = "label6";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxSefer1
            // 
            this.groupBoxSefer1.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxSefer1.Controls.Add(this.button7);
            this.groupBoxSefer1.Controls.Add(this.labelSaat);
            this.groupBoxSefer1.Controls.Add(this.labelFirmaAdi);
            this.groupBoxSefer1.Controls.Add(this.labelNereye);
            this.groupBoxSefer1.Controls.Add(this.labelFiyat);
            this.groupBoxSefer1.Controls.Add(this.labelNereden);
            this.groupBoxSefer1.Location = new System.Drawing.Point(6, 192);
            this.groupBoxSefer1.Name = "groupBoxSefer1";
            this.groupBoxSefer1.Size = new System.Drawing.Size(692, 91);
            this.groupBoxSefer1.TabIndex = 7;
            this.groupBoxSefer1.TabStop = false;
            this.groupBoxSefer1.Text = "Sefer 1";
            // 
            // button7
            // 
            this.button7.ImageList = this.MenuResim;
            this.button7.Location = new System.Drawing.Point(203, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 31);
            this.button7.TabIndex = 8;
            this.button7.Text = "Onayla / Devam Et";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // labelSaat
            // 
            this.labelSaat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelSaat.Location = new System.Drawing.Point(203, 16);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(142, 31);
            this.labelSaat.TabIndex = 5;
            this.labelSaat.Text = "Saat";
            this.labelSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirmaAdi
            // 
            this.labelFirmaAdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelFirmaAdi.Location = new System.Drawing.Point(10, 17);
            this.labelFirmaAdi.Name = "labelFirmaAdi";
            this.labelFirmaAdi.Size = new System.Drawing.Size(142, 31);
            this.labelFirmaAdi.TabIndex = 4;
            this.labelFirmaAdi.Text = "FİRMA ADİ";
            this.labelFirmaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNereye
            // 
            this.labelNereye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelNereye.Location = new System.Drawing.Point(549, 28);
            this.labelNereye.Name = "labelNereye";
            this.labelNereye.Size = new System.Drawing.Size(137, 41);
            this.labelNereye.TabIndex = 3;
            this.labelNereye.Text = "label7";
            this.labelNereye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFiyat
            // 
            this.labelFiyat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelFiyat.Location = new System.Drawing.Point(22, 54);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(116, 31);
            this.labelFiyat.TabIndex = 2;
            this.labelFiyat.Text = "FİYAT";
            this.labelFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNereden
            // 
            this.labelNereden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelNereden.Location = new System.Drawing.Point(406, 28);
            this.labelNereden.Name = "labelNereden";
            this.labelNereden.Size = new System.Drawing.Size(137, 41);
            this.labelNereden.TabIndex = 0;
            this.labelNereden.Text = "label6";
            this.labelNereden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.ImageList = this.MenuResim;
            this.button4.Location = new System.Drawing.Point(257, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sefer Değiştir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBoxTarih
            // 
            this.groupBoxTarih.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxTarih.Controls.Add(this.groupBoxNereye);
            this.groupBoxTarih.Controls.Add(this.label8);
            this.groupBoxTarih.Controls.Add(this.Nereye);
            this.groupBoxTarih.Controls.Add(this.label5);
            this.groupBoxTarih.Controls.Add(this.Nereden);
            this.groupBoxTarih.Controls.Add(this.label4);
            this.groupBoxTarih.Controls.Add(this.labelYil);
            this.groupBoxTarih.Controls.Add(this.labelAy);
            this.groupBoxTarih.Controls.Add(this.button2);
            this.groupBoxTarih.Controls.Add(this.labelGun);
            this.groupBoxTarih.Controls.Add(this.button1);
            this.groupBoxTarih.Location = new System.Drawing.Point(6, 19);
            this.groupBoxTarih.Name = "groupBoxTarih";
            this.groupBoxTarih.Size = new System.Drawing.Size(692, 167);
            this.groupBoxTarih.TabIndex = 3;
            this.groupBoxTarih.TabStop = false;
            // 
            // groupBoxNereye
            // 
            this.groupBoxNereye.Controls.Add(this.comboBoxNereden);
            this.groupBoxNereye.Controls.Add(this.button3);
            this.groupBoxNereye.Controls.Add(this.comboBoxNereye);
            this.groupBoxNereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBoxNereye.Location = new System.Drawing.Point(158, 147);
            this.groupBoxNereye.Name = "groupBoxNereye";
            this.groupBoxNereye.Size = new System.Drawing.Size(324, 132);
            this.groupBoxNereye.TabIndex = 4;
            this.groupBoxNereye.TabStop = false;
            this.groupBoxNereye.Text = "NEREDEN                      NEREYE";
            // 
            // comboBoxNereden
            // 
            this.comboBoxNereden.DisplayMember = "KÜTAHYA";
            this.comboBoxNereden.FormattingEnabled = true;
            this.comboBoxNereden.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Antalya",
            "Ankara",
            "Bursa",
            "Denizli",
            "Konya",
            "Kütahya",
            "Muğla",
            "Rize",
            "Trabzon",
            "Yalova"});
            this.comboBoxNereden.Location = new System.Drawing.Point(6, 36);
            this.comboBoxNereden.Name = "comboBoxNereden";
            this.comboBoxNereden.Size = new System.Drawing.Size(121, 33);
            this.comboBoxNereden.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Yolculuk ARA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBoxNereye
            // 
            this.comboBoxNereye.DisplayMember = "KÜTAHYA";
            this.comboBoxNereye.FormattingEnabled = true;
            this.comboBoxNereye.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Antalya",
            "Ankara",
            "Bursa",
            "Denizli",
            "Konya",
            "Kütahya",
            "Muğla",
            "Rize",
            "Trabzon",
            "Yalova"});
            this.comboBoxNereye.Location = new System.Drawing.Point(197, 36);
            this.comboBoxNereye.Name = "comboBoxNereye";
            this.comboBoxNereye.Size = new System.Drawing.Size(121, 33);
            this.comboBoxNereye.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(238, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 50);
            this.label8.TabIndex = 7;
            this.label8.Text = ">>>>>>";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nereye
            // 
            this.Nereye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Nereye.Location = new System.Drawing.Point(470, 28);
            this.Nereye.Name = "Nereye";
            this.Nereye.Size = new System.Drawing.Size(216, 50);
            this.Nereye.TabIndex = 6;
            this.Nereye.Text = "NEREYE";
            this.Nereye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(358, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 50);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nereden
            // 
            this.Nereden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Nereden.Location = new System.Drawing.Point(6, 28);
            this.Nereden.Name = "Nereden";
            this.Nereden.Size = new System.Drawing.Size(216, 50);
            this.Nereden.TabIndex = 5;
            this.Nereden.Text = "NEREDEN";
            this.Nereden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.Location = new System.Drawing.Point(274, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYil
            // 
            this.labelYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelYil.Location = new System.Drawing.Point(370, 94);
            this.labelYil.Name = "labelYil";
            this.labelYil.Size = new System.Drawing.Size(112, 50);
            this.labelYil.TabIndex = 4;
            this.labelYil.Text = "0";
            this.labelYil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAy
            // 
            this.labelAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelAy.Location = new System.Drawing.Point(293, 94);
            this.labelAy.Name = "labelAy";
            this.labelAy.Size = new System.Drawing.Size(71, 50);
            this.labelAy.TabIndex = 3;
            this.labelAy.Text = "0";
            this.labelAy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.MenuResim;
            this.button2.Location = new System.Drawing.Point(534, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "SONRAKİ GÜN";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelGun
            // 
            this.labelGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelGun.Location = new System.Drawing.Point(216, 94);
            this.labelGun.Name = "labelGun";
            this.labelGun.Size = new System.Drawing.Size(71, 50);
            this.labelGun.TabIndex = 2;
            this.labelGun.Text = "0";
            this.labelGun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.MenuResim;
            this.button1.Location = new System.Drawing.Point(6, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÖNCEKİ GÜN";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 186);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(248, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 379);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bileterim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bilet No";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(27, 280);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "Bileti Sil";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // MenuResim
            // 
            this.MenuResim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MenuResim.ImageStream")));
            this.MenuResim.TransparentColor = System.Drawing.Color.Transparent;
            this.MenuResim.Images.SetKeyName(0, "arrowLeft.png");
            this.MenuResim.Images.SetKeyName(1, "arrowRight.png");
            this.MenuResim.Images.SetKeyName(2, "checkmark.png");
            this.MenuResim.Images.SetKeyName(3, "cross.png");
            this.MenuResim.Images.SetKeyName(4, "singleplayer.png");
            this.MenuResim.Images.SetKeyName(5, "save.png");
            this.MenuResim.Images.SetKeyName(6, "menuList.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 602);
            this.Controls.Add(this.groupBoxSefer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BuBilet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSefer.ResumeLayout(false);
            this.groupBoxSefer3.ResumeLayout(false);
            this.groupBoxSefer2.ResumeLayout(false);
            this.groupBoxSefer1.ResumeLayout(false);
            this.groupBoxTarih.ResumeLayout(false);
            this.groupBoxNereye.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonYardim;
        private System.Windows.Forms.Button buttonBilet;
        private System.Windows.Forms.Button buttonSefer;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label labelTc;
        public System.Windows.Forms.Label labelSoy;
        public System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.GroupBox groupBoxSefer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelGun;
        private System.Windows.Forms.GroupBox groupBoxTarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelYil;
        private System.Windows.Forms.Label labelAy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxNereye;
        private System.Windows.Forms.ComboBox comboBoxNereye;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Nereye;
        private System.Windows.Forms.Label Nereden;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBoxSefer1;
        private System.Windows.Forms.Label labelNereden;
        private System.Windows.Forms.Label labelNereye;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelFirmaAdi;
        private System.Windows.Forms.GroupBox groupBoxSefer3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelFirma3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBoxSefer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFirma2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.ComboBox comboBoxNereden;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList MenuResim;
    }
}


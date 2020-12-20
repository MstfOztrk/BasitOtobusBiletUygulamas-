using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtobusBiletUygulaması
{
    public partial class Form1 : Form
    {
        int gun;
        int ay;
        int yil;
        public bool denetim { get; set; }
        OleDbConnection baglanti;
        OleDbDataAdapter adaptor;
        OleDbCommand komut;
        DataSet verikumesi;

        void Baglanti()
        {
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeferAcKapa();

        }

        private void buttonSefer_Click(object sender, EventArgs e)
        {
            SeferAcKapa();
        }
        void SeferAcKapa()
        {
            if (groupBoxSefer.Visible == true)
            {
                groupBoxSefer.Visible = false;
                BiletDoldur();
               
            }
            else
            {
                groupBoxSefer.Visible = true;
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool yardimKontrol = true;
        private void buttonYardim_Click(object sender, EventArgs e)
        {
            
            if (yardimKontrol)
            {              
                buttonYardim.Text = "(555)(555 5555)";
                yardimKontrol = false;
            }
            else if(!yardimKontrol)
            {               
                buttonYardim.Text = "İLETİŞİM/YARDIM";
                yardimKontrol = true;
            }
        }
        DateTime thisDay = DateTime.Now;
        
        private void timer1_Tick(object sender, EventArgs e)
        {                      

        }
        void TarihHesap()
        {
            gun = thisDay.Day;
            ay = thisDay.Month;
            yil = thisDay.Year;
            labelGun.Text = gun.ToString("d");
            labelAy.Text = ay.ToString("d");
            labelYil.Text = yil.ToString("d");
        }
        bool Seferler = false;
        void SeferVisible()
        {
            if (!Seferler)
            {
                groupBoxSefer1.Visible = false;
                groupBoxSefer2.Visible = false;
                groupBoxSefer3.Visible = false;
            }
            else
            {
                groupBoxSefer1.Visible = true;
                groupBoxSefer2.Visible = true;
                groupBoxSefer3.Visible = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxNereye.Parent = groupBoxSefer;
            Seferler = false;
            SeferVisible();
            button4.Visible = false;
            groupBoxTarih.Visible = false;
            timer1.Start();
            TarihHesap();
            denetim = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thisDay = thisDay.AddDays(1);
            TarihHesap();
            SonrakiGun();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thisDay = thisDay.AddDays(-1);
            TarihHesap();
            SonrakiGun();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            if((comboBoxNereden.SelectedIndex==comboBoxNereye.SelectedIndex) || (comboBoxNereden.SelectedIndex==-1 || comboBoxNereye.SelectedIndex==-1) )
            {
                MessageBox.Show("Lütfen Yolculuk Bilgilerinizi Gözden Geçirin.");
            }
            else
            {
                SonrakiGun();
            }
            
        }
        void SonrakiGun()
        {
            Nereden.Text = comboBoxNereden.Text;
            Nereye.Text = comboBoxNereye.Text;
            groupBoxNereye.Visible = false;
            groupBoxTarih.Visible = true;
            button4.Visible = true;
            Seferler = true;
            SeferVisible();
            SeferAyarla(labelFirmaAdi, labelSaat, labelNereden, labelNereye, labelFiyat,button7);
            SeferAyarla(labelFirma2, label6, label11, label9, label10, button6);
            SeferAyarla(labelFirma3, label12, label16, label14, label15, button5);
        }
        Random rndSaat = new Random();
        void SeferAyarla(Label firmaAdi, Label saat, Label nereden, Label nereye, Label fiyat,Button onay)
        {
            Random rnd = new Random();
            firmaAdi.Text = "MustafaKuzu";
            saat.Text = rndSaat.Next(1, 22).ToString()+":00";
            nereden.Text = Nereden.Text;
            nereye.Text = Nereye.Text;
            fiyat.Text = rndSaat.Next(50,90).ToString()+"₺";
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBoxNereye.Visible = true;
            groupBoxTarih.Visible = false;
            comboBoxNereden.SelectedIndex = -1;
            comboBoxNereye.SelectedIndex = -1;
            button4.Visible = false;
            Seferler = false;
            SeferVisible();
        }
        void BiletDoldur()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Otobus.accdb");
            adaptor = new OleDbDataAdapter("Select * from Biletler", baglanti);
            verikumesi = new DataSet();
            komut = new OleDbCommand();
            baglanti.Open();
            adaptor.Fill(verikumesi, "Authors_table");
            baglanti.Close();
            dataGridView1.DataSource = verikumesi;
            dataGridView1.DataMember = "Authors_table";
        }

        private void groupBoxSefer_Enter(object sender, EventArgs e)
        {

        }
        public bool test()
        {
            return false;
        }
        
      
        public void Yukle(Label firmaAdi, Label saat, Label nereden, Label nereye, Label fiyat)
        {
            Form2 f2 = new Form2();
            f2.labelFirma.Text = firmaAdi.Text;
            f2.LabelSaat.Text = saat.Text;
            f2.labelNereden.Text = nereden.Text;
            f2.labelNereye.Text = nereye.Text;
            f2.labelFiyat.Text = fiyat.Text;
            f2.label9.Text = labelAd.Text;
            f2.label10.Text = labelSoy.Text;
            f2.label11.Text = labelTc.Text;
            f2.label13.Text = labelTel.Text;
            f2.labelTarih.Text = gun.ToString() + "." + ay.ToString() + "." + yil.ToString();
            f2.Show();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            Yukle(labelFirmaAdi, labelSaat, labelNereden, labelNereye, labelFiyat);         
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Yukle(labelFirma2, label6, label11, label9, label10);           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Yukle(labelFirma3, label12, label16, label14, label15);         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                try
                {
                    var test =MessageBox.Show("Bileti Silmek İstediğinize Emin misiniz?","Bilet Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (test == DialogResult.Yes)
                    {

                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Otobus.accdb");
                        adaptor = new OleDbDataAdapter("Select * from Biletler", baglanti);
                        verikumesi = new DataSet();
                        komut = new OleDbCommand();
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "Delete from Biletler where BiletKodu=" + textBox1.Text + "";
                        komut.ExecuteNonQuery();
                        komut.Dispose();
                        baglanti.Close();

                        BiletDoldur();

                        textBox1.Clear();
                        MessageBox.Show("Biletiniz Silinmiştir, Para İadesi En Kısa Süre İçerisinde Yapılacaktır.");
                    }
                    else
                    {
                        MessageBox.Show("Bilet Silme İşleminiz İptal Edilmiştir");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Bilet Kodunuzu kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Bilet Kodunu Kontrol Ediniz.");
            }
        }
    }
}

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
    public partial class Form2 : Form
    {
        OleDbConnection baglanti;
        OleDbDataAdapter adaptor;
        OleDbCommand komut;
        DataSet verikumesi;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            KoltukSecim(button16);
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {         
            Form1 f1 = new Form1();
            
        }
        void BiletSatinAl(Button koltukNumara)
        {
            Random rnd = new Random();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Otobus.accdb");
            adaptor = new OleDbDataAdapter("Select * from Biletler", baglanti);
            verikumesi = new DataSet();
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into Biletler(BiletKodu,Adi,Soyadi,TCNumarası,TelefonNumarası,Tarih,SeferNereden,SeferNereye,KoltukNo,Saat,Fiyat) values (@pBilet,@pAdi,@Soyadi,@pTc,@pTel,@pTarih,@pNereden,@pNereye,@pKoltukNo,@pSaat,@pFiyat)";
            komut.Parameters.AddWithValue("@pBilet", rnd.Next(0,1000000));
            komut.Parameters.AddWithValue("@pAdi", label9.Text);
            komut.Parameters.AddWithValue("@pSoyadi", label10.Text);
            komut.Parameters.AddWithValue("@pTc", label11.Text);
            komut.Parameters.AddWithValue("@pTel", label13.Text);
            komut.Parameters.AddWithValue("@pTarih", labelTarih.Text);
            komut.Parameters.AddWithValue("@pNereden", labelNereden.Text);
            komut.Parameters.AddWithValue("@pNereye", labelNereye.Text);
            komut.Parameters.AddWithValue("@pKolukNo", Convert.ToInt32(koltukNumara.Text));
            komut.Parameters.AddWithValue("@pSaat", LabelSaat.Text);
            komut.Parameters.AddWithValue("@pFiyat", labelFiyat.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();


        }
        
        void KoltukSecim(Button koltuk)
        {
            int koltukNumara = Convert.ToInt32(koltuk.Text);
            if (koltuk.BackColor == Color.LightCoral)
            {
                var iptal = DialogResult = MessageBox.Show("Bileti iptal Etmek İstediğinize Emin misiniz?", "Bilet İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iptal == DialogResult.Yes ) 
                {
                    BiletSil(koltuk);
                    MessageBox.Show("Bilet Silindi");
                    koltuk.BackColor = DefaultBackColor;
      
                }
            }
            else
            {
                var iptal = DialogResult = MessageBox.Show("Bileti Satın Almak İstediğinize Emin misiniz?", "Bilet Satın Alım", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iptal == DialogResult.Yes) 
                {
                    BiletSatinAl(koltuk);          
                    MessageBox.Show("Bilet Satın Alındı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    koltuk.BackColor = Color.LightCoral;
                    MessageBox.Show("Bileti İptal Etmek İsterseniz Satın Aldığınız Koltuğa Tekrar Tıklayabilirsin.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
            }

        }
        void BiletSil(Button koltukNo)
        {
            try
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Otobus.accdb");
                adaptor = new OleDbDataAdapter("Select * from Biletler", baglanti);
                verikumesi = new DataSet();
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from Biletler where KoltukNo=" + Convert.ToInt32(koltukNo.Text) + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();

                MessageBox.Show("Biletiniz Silinmiştir, Para İadesi En Kısa Süre İçerisinde Yapılacaktır.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KoltukSecim(button1);           
        }
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KoltukSecim(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KoltukSecim(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KoltukSecim(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KoltukSecim(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KoltukSecim(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KoltukSecim(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KoltukSecim(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KoltukSecim(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KoltukSecim(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KoltukSecim(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            KoltukSecim(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            KoltukSecim(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            KoltukSecim(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            KoltukSecim(button15);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            KoltukSecim(button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            KoltukSecim(button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            KoltukSecim(button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            KoltukSecim(button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            KoltukSecim(button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            KoltukSecim(button22);
        }
    }
}

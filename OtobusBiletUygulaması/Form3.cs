using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletUygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           if(textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Giriş Bilgileri Boş Geçilemez");
                
            }
            else
            {              
                Form1 f1 = new Form1();
                f1.labelAd.Text = textBox1.Text;
                f1.labelSoy.Text = textBox2.Text;
                f1.labelTc.Text = textBox3.Text;
                f1.labelTel.Text = textBox4.Text;
                f1.Show();
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BEYAZ_EŞYA
{
    public partial class sifreunuttum : Form
    {   
        public sifreunuttum()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris g = new giris();
            g.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            islem sifre = new islem();//işlem sınıfından eleman oluşturdum.
            try
            {
                label4.Text=("ŞİFRENİZ  : " + sifre.sifreunuttum(textBox1.Text, textBox2.Text, textBox3.Text));
                //burada ise matotdan aldığımız bilgileri kontrol yaparak textboxa yazdırdım.
            }
            catch(Exception)
            {
                //yanlış yazımda yada eksik bilgide bu mesaj gözükecek .
                MessageBox.Show("HATA BİLGİ LÜTFEN KONTROL EDİNİZ !!!!");
            }
           
                
            
        }
    }
}

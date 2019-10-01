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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//şifreyi göstermek için 
        {
            if (checkBox1.Checked)//checkbox a basılmiş ise 
            {
                //karakteri göster.
                textBox2.PasswordChar = '\0';
            }
          
            else  //değilse karakterlerin yerine * koy
            {
                textBox2.PasswordChar = '*';
            }
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                    sifreunuttum göster = new sifreunuttum();//şifremi unuttum formuna giriş için 
                    göster.Show();
                    this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islem giriss = new islem();//giriş işlemi için sınıftan metot oluşturdum
            if (giriss.giris(textBox1.Text, textBox2.Text))
            {
                anaekran a = new anaekran();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış !!! ");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifreunuttum göster = new sifreunuttum();//şifremi unuttum formuna giriş için 
            göster.Show();
            this.Hide();
        }
    } 
}

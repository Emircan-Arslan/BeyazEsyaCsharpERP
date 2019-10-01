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
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void ekle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {   // open file dialog penceresiyle resim açılmasını sağlıyoruz
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   //aldığımız ismi textbox a atıyoruz
                textBox8.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                islem kayitt = new islem();
                //bilgileri değişkenlere atıyorum 
                string urunturu = comboBox1.Text, marka = comboBox2.Text, enerjısinifi = comboBox3.Text, urunrengı = comboBox4.Text, model = textBox1.Text, yukseklık = textBox3.Text, derınlık = textBox4.Text, genıslık = textBox5.Text, hacım = textBox6.Text;
                DateTime tarıh = dateTimePicker1.Value;
                String date = tarıh.ToString();
                string resımyol = openFileDialog1.FileName;
                int adet;
                adet = Convert.ToInt32(textBox7.Text);
                Double fıyat;
                fıyat = Convert.ToDouble(textBox2.Text);
                string resimkayit ="resimler2/"+textBox8.Text;

           
                kayitt.kayit(urunturu, marka, enerjısinifi, urunrengı, model, fıyat, yukseklık, derınlık, genıslık, hacım, adet, date, resimkayit, resımyol);
                MessageBox.Show("Yeni Kayıt Başarılı", "Bilgi");
            

            
            

            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ALANLAR SİLENECEK EMİNMİSİNİZ", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                pictureBox1.Image = null;
            }
            else if (dialogResult == DialogResult.No)
            {
                //burayı boş bıraktım çünkü bişe yapılmasına gerek yok 
            }
            
            

        }
    }
}

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
    public partial class musterı : Form
    {
        public musterı()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("KAYDETMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ !!!", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {
                    string ad, soyad, tel, ıl, ılce, semt;
                    ad = textBox2.Text;
                    soyad = textBox3.Text;
                    tel = textBox4.Text;
                    ıl = textBox5.Text;
                    ılce = textBox6.Text;
                    semt = textBox7.Text;
                    islem mekle = new islem();
                

                try
                {
                    
                    mekle.musterı(ad, soyad, tel, ıl, ılce, semt);
                    MessageBox.Show("MÜŞTERİ KAYIT EDİLDİ ");
                    
                }
                catch (Exception)
                { MessageBox.Show("HATALI KAYIT ALANLARI KONTROL EDİNİZ "); }
            }
            else if (dialogResult == DialogResult.No)
            {
                //nurayı boş bırakıyorum bişe yazmaya gerek yok. 
            }
            islem goster = new islem();
            goster.musterılist();
            dataGridView1.DataSource = goster.tablo;

        }
            

        private void musterı_Load(object sender, EventArgs e)
        {
            islem mekle = new islem();
            mekle.musterılist();
            dataGridView1.DataSource = mekle.tablo;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            islem ara = new islem();
            ara.muara(textBox1.Text);
            dataGridView1.DataSource = ara.tablo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ALANLAR SİLENECEK EMİNMİSİNİZ !!!", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                //nurayı boş bırakıyorum bişe yazmaya gerek yok. 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ !!!", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {
                string numara;
                islem silme = new islem();
                numara = textBox4.Text;
                try
                {
                    silme.musterısill(numara);
                    MessageBox.Show("Kayıt Silindi");

                    islem os = new islem();//kayıt silindikden sonra datagridi yenilemek için.
                    os.musterılist();
                    dataGridView1.DataSource = os.tablo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex.ToString(), "Error");
                }
            }

            else if (dialogResult == DialogResult.No)
            {
                //nurayı boş bırakıyorum bişe yazmaya gerek yok. 
            }
        }
    }
}

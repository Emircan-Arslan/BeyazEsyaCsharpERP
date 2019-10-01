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
    public partial class guncelle_sıl : Form
    {
        public guncelle_sıl()
        {
            InitializeComponent();
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
               
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //nurayı boş bırakıyorum bişe yazmaya gerek yok. 
            }
        }

        private void guncelle_sıl_Load(object sender, EventArgs e)
        {
            islem os = new islem();
            os.güncelle_sıl();
            dataGridView1.DataSource = os.tablo;
           
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ !!!", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {
                try
                {

                    string urunturu; urunturu = comboBox1.Text;
                    string marka; marka = comboBox2.Text;
                    string enerjısinifi; enerjısinifi = comboBox3.Text;
                    string urunrengı; urunrengı = comboBox4.Text;
                    string model; model = textBox1.Text;
                    string yukseklık; yukseklık = textBox3.Text;
                    string derınlık; derınlık = textBox4.Text;
                    string genıslık; genıslık = textBox5.Text;
                    string hacım; hacım = textBox6.Text;
                    DateTime tarıh; tarıh = dateTimePicker1.Value;
                    int adet;
                    adet = Convert.ToInt32(textBox7.Text);
                    Double fıyat;
                    fıyat = Convert.ToDouble(textBox2.Text);
                    islem guncel = new islem();
                    guncel.guncelle(urunturu, marka, enerjısinifi, urunrengı, fıyat, yukseklık, derınlık, genıslık, hacım, adet, tarıh, model);
                    MessageBox.Show("güncelleme başarılı ");
                    ///////
                    islem os = new islem();//HEMEN LİSTELEME YAPSIN DİYE 
                    os.güncelle_sıl();
                    dataGridView1.DataSource = os.tablo;

                }
                catch(Exception)
                {
                    MessageBox.Show("HATA ALANLARI KONTROL EDİNİZ");
                }
               

            }
            else if (dialogResult == DialogResult.No)
            {
                //nurayı boş bırakıyorum bişe yazmaya gerek yok. 
            }

        }


        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ !!!", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {
                string numara;
                islem silme = new islem();
                numara = textBox1.Text;
                try
                {
                    silme.sill(numara);
                    MessageBox.Show("Kayıt Silindi");

                    islem os = new islem();//kayıt silindikden sonra datagridi yenilemek için.
                    os.güncelle_sıl();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


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
    public partial class satıs : Form
    {
        public satıs()
        {
            InitializeComponent();
        }

        private void satıs_Load(object sender, EventArgs e)
        {
            islem liste = new islem();
            liste.satıslıst();
            dataGridView1.DataSource = liste.tablo;

            islem mlist = new islem();
            mlist.musterılist();
            dataGridView2.DataSource = mlist.tablo;

        

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
         
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
           

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double fıyat, toplam = 0;
            fıyat = Convert.ToDouble(label4.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    toplam = fıyat;
                    label12.Text = fıyat.ToString();
                    break;

                case 1:
                    toplam = fıyat+fıyat;
                    label12.Text = toplam.ToString();
                    break;
                case 2:
                    toplam = fıyat + fıyat+fıyat;
                    label12.Text = toplam.ToString();
                    break;
                case 3: 
                    toplam = fıyat + fıyat+fıyat+fıyat;
                    label12.Text = toplam.ToString();
                    break;
                case 4:
                    toplam = fıyat + fıyat + fıyat + fıyat+fıyat;
                    label12.Text = toplam.ToString();
                    break;
                default:
                    MessageBox.Show("YANLIŞ SEÇİM");
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int adet;
            adet = Convert.ToInt32(comboBox1.Text);
            string urunmodel, musterıtel,tur;

            urunmodel = textBox1.Text;
            musterıtel = textBox2.Text;
            tur = comboBox2.Text;

            double fıyat = Convert.ToDouble(label12.Text);

            if (textBox1.Text != "" && textBox2.Text != "")

                {

                islem g = new islem();
               g.satısguncelle(adet, textBox1.Text);
                islem s = new islem();
                s.satısekle(urunmodel, adet, fıyat, musterıtel,tur);
            MessageBox.Show("SATIŞ BAŞARILI ");

                  }

            else
            {
                MessageBox.Show("ÜRÜN MODEL YADA MÜŞTERİ TEL YAZINIZ ");
            }
            islem liste = new islem();
            liste.satıslıst();
            dataGridView1.DataSource = liste.tablo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            label12.Text = "";
            label4.Text = "";
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

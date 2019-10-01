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
    public partial class stokara : Form
    {
        public stokara()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            islem ara = new islem();
           
            
            ara.arama(textBox1.Text);
            dataGridView1.DataSource = ara.tablo;

        }

        private void stokara_Load(object sender, EventArgs e)
        {
            islem listele = new islem();
            listele.yazdırlist();
            dataGridView1.DataSource = listele.tablo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tur;
            tur = comboBox1.Text;
            islem araa = new islem();
            araa.turarama(tur);
            dataGridView1.DataSource = araa.tablo;

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            islem listele = new islem();
            listele.yazdırlist();
            dataGridView1.DataSource = listele.tablo;
        }
    }
}

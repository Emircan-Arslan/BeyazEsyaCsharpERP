using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BEYAZ_EŞYA
{
    public partial class haberler : Form
    {
        public haberler()
        {
            InitializeComponent();
        }

        private void haberler_Load(object sender, EventArgs e)
        {   //timer sayesinde sistem saatini ve tarihini atdım
            timer1.Interval = 1000;
            timer1.Start();
            label5.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
            ////////////////////////////////////////////////
            //datagrid nesnesinde gösterdim.
            islem os = new islem();
            os.haberlist();
            dataGridView2.DataSource = os.tablo;

            islem musteriler = new islem();
            musteriler.musterılist();
            dataGridView3.DataSource = musteriler.tablo;

            islem satıs = new islem();
            satıs.sonsatıs();
            dataGridView1.DataSource = satıs.tablo;


            islem stok = new islem();
            stok.azalanstok();
            dataGridView4.DataSource = stok.tablo;



            if (dataGridView1.Rows[0].Cells[0].Value.ToString() != string.Empty)
            {
                //işlemler,

                MessageBox.Show("DİKKAT STOKDA AZALAN ÜRÜNLER VAR !!!");
                button4.BackColor = Color.Red;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             //tarih ve saati labellarda gösterdim.
            label5.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView3.Visible = false;
            dataGridView2.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView4.Visible = false;
            dataGridView3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView2.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gainsboro;
            dataGridView3.Visible = false;
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView4.Visible = true;
        }
    }
}

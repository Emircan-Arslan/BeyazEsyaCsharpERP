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
    public partial class barkod : Form
    {
        public barkod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Framewokümüzü kullanarak borcode oluşturmasını istiyoruz
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //textbox’a girdiğimiz textimizin barcode’unu picturebox’ta gösteriyoruz.
            pictureBox1.Image = barcode.Draw(textBox1.Text, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(textBox1.Text, 50);
        }

        private void barkod_Load(object sender, EventArgs e)
        {
            islem os = new islem();
            os.güncelle_sıl();
            dataGridView1.DataSource = os.tablo;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //burada data gridde seçili olan model no yu text box a atar.
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int X = printDocument1.DefaultPageSettings.Margins.Left;
            int Y = printDocument1.DefaultPageSettings.Margins.Top;
            int Genislik = pictureBox1.Width * 2;
            int Yukseklik = pictureBox1.Height * 2;
            e.Graphics.DrawImage(pictureBox1.Image, X, Y, Genislik, Yukseklik);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("BARKOD YADA QR CODE YAZDIRILSIN MI    !!!", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {
                printDocument1.Print();

            }
            else if (dialogResult == DialogResult.No)
            {
                //nurayı boş bırakıyorum bişe yazmaya gerek yok. 
            }
        }
    }
}

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
    
    
    public partial class anaekran : Form

    {

        void yavruform(Form yavru)//ana formun içinde diğer formları açmak için bir metot oluşturdum.
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == yavru.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
                else
                {
                    eleman.Close();
                }
            }
            if (durum == false)
            {
                yavru.MdiParent = this;
                yavru.Show();
            }
        }



        public anaekran()
        {
            InitializeComponent();
        }

        private void tÜMÜNÜGÖSTERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void üRÜNEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekle ee = new ekle();//ekle formunu ana formda göstermek için. 
            yavruform(ee);
        }

        private void mÜSTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musterı mm = new musterı();//musteri formunu açar. 
            yavruform(mm);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkmak İstediğinden Eminmisin", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak uygulamayı kapatır.
            {
                this.Close();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //burayı boş bıraktım çünkü bişe yapılmasına gerek yok 
            }
        }

        private void anaekran_Load(object sender, EventArgs e)
        {
            haberler hh = new haberler();//loadda haber formu çıkar 
            yavruform(hh);
        }

        private void aNAEKRANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            haberler hh = new haberler();//haber formuna gelmek için
            yavruform(hh);
        }

        private void sATIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satıs ss = new satıs();//satıs formunu açmak için.
            yavruform(ss);
        }

        private void sTOKARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokara sa = new stokara();//stokara formunu açmak için.
            yavruform(sa);
        }

        private void yAZDIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yazdır ya = new yazdır();//stokara formunu açmak için.
            yavruform(ya);
        }

        private void üRÜNGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void üRÜNSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle_sıl gu = new guncelle_sıl();//guncelle formunu açmak için.
            yavruform(gu);
        }

        private void bARKODİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barkod gu = new barkod();//guncelle formunu açmak için.
            yavruform(gu);
        }

        private void tOPLAMSATIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toplamsatis tsa = new toplamsatis();//guncelle formunu açmak için.
            yavruform(tsa);
        }
    }
}

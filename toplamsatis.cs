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
    public partial class toplamsatis : Form
    {
        public toplamsatis()
        {
            InitializeComponent();
        }

        private void toplamsatis_Load(object sender, EventArgs e)
        {
            islem satıs = new islem();
            satıs.sonsatıs();
            dataGridView1.DataSource = satıs.tablo;

            islem tops = new islem();
            tops.topsatıs();
            dataGridView2.DataSource = tops.tablo;

            islem topfıyat = new islem();
            topfıyat.topfıyat();
            dataGridView3.DataSource = topfıyat.tablo;
        }
    }
}

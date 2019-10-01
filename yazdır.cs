using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
    using Microsoft.Office.Interop.Excel;
using System.Collections;

namespace BEYAZ_EŞYA
{
    
    public partial class yazdır : Form
    {
        public yazdır()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("EXCEL e AKTARILSIN MI  !!!", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {

                // daragriddeki verileri excele aktarmak için aşağıdaki kodları yazıyoruz. 
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {

                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();


                    }
                }
            }

            else if (dialogResult == DialogResult.No)
            {
                //nurayı boş bırakıyorum bişe yazmaya gerek yok. 
            }

        }

        private void yazdır_Load(object sender, EventArgs e)
        {
            islem os = new islem();
            os.yazdırlist();
            dataGridView1.DataSource = os.tablo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("SAYFA YAZDIRILSIN MI   !!!", "", MessageBoxButtons.YesNo);//messageBox da "evet" ,"hayır" butonu ekledim.
            if (dialogResult == DialogResult.Yes)//messageBox da çıkan pencerede evet seçeneğine tıklarsak TEXT ler temizlenir.
            {
                printDocument1.Print();

            }
            else if (dialogResult == DialogResult.No)
            {
                //nurayı boş bırakıyorum bişe yazmaya gerek yok. 
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

                Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
                dataGridView1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
                e.Graphics.DrawImage(bm, 0, 0);
            }
            

        
    }
}

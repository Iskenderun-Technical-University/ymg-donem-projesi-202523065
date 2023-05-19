using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;

namespace ARAÇ_KİRALAMA_OTOMASYON
{ 
    public partial class Kiralamaİşlemleri : Form
    {
        KİRALAMA arackiralama = new KİRALAMA();
        public Kiralamaİşlemleri()
        {
            InitializeComponent();
        }

        private void Kiralamaİşlemleri_Load(object sender, EventArgs e)
        {
            yenilelistele();
        }
        private void yenilelistele()
        {
            string cümle = "select*from arac";




            SqlDataAdapter adtr2 = new SqlDataAdapter();


            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
           
          //  dataGridView1.Columns[1].Visible=false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            int carpım, txt, lbl;
            txt = Convert.ToInt32(textBox1.Text);
            lbl = Convert.ToInt32(label5.Text);

            carpım=txt*lbl;

            label9.Text = Convert.ToString(carpım);

            MessageBox.Show(carpım + "TL Kiralama Ücreti");
            


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells[6].Value.ToString();
            comboBox1.Text = satır.Cells[0].Value.ToString();
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime başlangıçtarihi = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime bitiştarihi = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan kiralanangünsayısı = bitiştarihi - başlangıçtarihi;
            label5.Text = kiralanangünsayısı.TotalDays.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

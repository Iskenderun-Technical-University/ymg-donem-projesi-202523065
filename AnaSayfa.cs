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

namespace ARAÇ_KİRALAMA_OTOMASYON
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MüsteriListele listele=new MüsteriListele();
            listele.ShowDialog();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüşteriEkle ekle=new MüşteriEkle(); 
            ekle.ShowDialog();
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
          AraçListele   add=new AraçListele();

            add.ShowDialog();


            SqlConnection conn;
            SqlDataAdapter da;
            SqlCommand cmd;
            DataSet ds;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UNS7IFO\\SQLEXPRESS;Initial Catalog=vize;Integrated Security=True");
            da = new SqlDataAdapter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arabaekle kayıt = new arabaekle();
            kayıt.ShowDialog();
            
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kiralamaİşlemleri ki = new Kiralamaİşlemleri();
            ki.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            rapor rr = new rapor();
            rr.ShowDialog();
        }
    }
}

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
    public partial class AraçListele : Form
    {
        KİRALAMA arackiralama=new KİRALAMA();
        public AraçListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text=satır.Cells["plaka"].Value.ToString();
            comboBox4.Text = satır.Cells["marka"].Value.ToString();
            comboBox2.Text = satır.Cells["seriveyıl"].Value.ToString();
           // textBox2.Text = satır.Cells["yıl"].Value.ToString();
            textBox3.Text = satır.Cells["renk"].Value.ToString();
            textBox4.Text = satır.Cells["km"].Value.ToString();
           comboBox3.Text = satır.Cells["yakıt"].Value.ToString();
            textBox5.Text = satır.Cells["kiraücreti"].Value.ToString();
            // DateTime.Now.ToString   
            // pictureBox2.ImageLocation = satır.Cells["resim"].Value.ToString();
           // foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            //foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }

        private void AraçListele_Load(object sender, EventArgs e)
        {
           YenileAraçlarListesi();
            // foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select*from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
          dataGridView1.DataSource=  arackiralama.listele(adtr2, cümle);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update arac set marka=@marka,seriveyıl=@seriveyıl,renk=@renk,km=@km,yakıt=@yakıt,kiraücreti=@kiraücreti where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka",textBox1.Text);
            komut2.Parameters.AddWithValue("@marka",comboBox4.Text);
            komut2.Parameters.AddWithValue("@seriveyıl", comboBox2.Text);
            komut2.Parameters.AddWithValue("@renk", textBox3.Text);
            komut2.Parameters.AddWithValue("@km", textBox4.Text);
            komut2.Parameters.AddWithValue("@yakıt", comboBox3.Text);
            komut2.Parameters.AddWithValue("@kiraücreti", textBox5.Text);
            
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            


            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
           // foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            YenileAraçlarListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from arac where plaka= '"+satır.Cells["plaka"].Value.ToString() + " '           ";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            YenileAraçlarListesi();





        }

        private void button1_Click(object sender, EventArgs e)
        {
           arabaekle aa=new arabaekle();
            aa.ShowDialog();    
        }
    }
}

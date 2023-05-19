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
    public partial class arabaekle : Form
    {
        KİRALAMA arackiralama=new KİRALAMA(); 
        public arabaekle()
        {
            InitializeComponent();
        }

        private void arabaekle_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string cümle = "insert into arac(plaka,marka,seriveyıl,renk,km,yakıt,kiraücreti) values(@plaka,@marka,@seriveyıl,@renk,@km,@yakıt,@kiraücreti)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", textBox1.Text);
            komut2.Parameters.AddWithValue("@marka",comboBox1.Text);
            komut2.Parameters.AddWithValue("@seriveyıl", comboBox2.Text);
        
            komut2.Parameters.AddWithValue("@renk", textBox3.Text);
            komut2.Parameters.AddWithValue("@km", textBox4.Text);
            komut2.Parameters.AddWithValue("@yakıt", comboBox3.Text);
            komut2.Parameters.AddWithValue("@kiraücreti", textBox5.Text);
           
           arackiralama.ekle_sil_güncelle(komut2,cümle);

            MessageBox.Show("KAYIT BAŞARILI");

             
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";












        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}

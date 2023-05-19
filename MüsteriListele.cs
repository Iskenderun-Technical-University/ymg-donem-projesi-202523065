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
    public partial class MüsteriListele : Form
    {
        KİRALAMA arackiralama = new KİRALAMA();
        public MüsteriListele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;

            

            string cümle = "delete MÜSTERİBİLGİ where tc='" + satır.Cells["tc"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            
            
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();




        }

        private void MüsteriListele_Load(object sender, EventArgs e)
        {
            yenilelistele();

        }

        private void yenilelistele()
        {
            string cümle = "select*from MÜSTERİBİLGİ";

          


            SqlDataAdapter adtr2 = new SqlDataAdapter();


            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "ADSOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-MAİL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select*from MÜSTERİBİLGİ where tc like '%"+textBox1.Text+"%'";


            SqlDataAdapter adtr2 = new SqlDataAdapter();
           

            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void btnÇIKIŞ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTC.Text=satır.Cells[0].Value.ToString();
            textBox2.Text = satır.Cells[1].Value.ToString();
            textBox4.Text = satır.Cells[2].Value.ToString();
            txtADRES.Text = satır.Cells[3].Value.ToString();
            txtMAİL.Text = satır.Cells[4].Value.ToString();
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            string cümle = "update MÜSTERİBİLGİ set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,mail=@mail where tc=@tc";
            SqlCommand komut2=new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad ", textBox2.Text);
            komut2.Parameters.AddWithValue("@telefon ", textBox4.Text);
            komut2.Parameters.AddWithValue("@adres ", txtADRES.Text);
            komut2.Parameters.AddWithValue("@mail ", txtMAİL.Text);

            arackiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüşteriEkle M=new MüşteriEkle();    
            M.ShowDialog(); 
        }
    }
}

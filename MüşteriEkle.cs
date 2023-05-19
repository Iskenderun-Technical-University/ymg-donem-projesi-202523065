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
    public partial class MüşteriEkle : Form
    {
        KİRALAMA arac_kiralama=new KİRALAMA();  
        public MüşteriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into MÜSTERİBİLGİ(tc,adsoyad,telefon,adres,mail) values(@tc,@adsoyad,@telefon,@adres,@mail)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc" , txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad ", textBox2.Text);
            komut2.Parameters.AddWithValue("@telefon ", textBox4.Text);
            komut2.Parameters.AddWithValue("@adres ", txtADRES.Text);
            komut2.Parameters.AddWithValue("@mail ", txtMAİL.Text);

            arac_kiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";



        }

        private void MüşteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}

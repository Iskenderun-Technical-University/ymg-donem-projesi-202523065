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
    public partial class loginform : Form
    { 
        SqlConnection con;
        SqlCommand cmd; 
        SqlDataReader dr;
        
        DataSet ds;
        public static string SQLCon = "Data Source=DESKTOP-UNS7IFO\\SQLEXPRESS;Initial Catalog=projem;Integrated Security=True";
        
      

        public loginform()
        {
            InitializeComponent();

           con = new SqlConnection(SQLCon);
           



        }

        private void loginform_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void giriş()
        {
            string sorgu = "select * from girişform where tc=@user and sifre=@pass ";


            con = new SqlConnection(SQLCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user",textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", SİFRELEME.MD5SİFRELE(textBox2.Text)); 



            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                this.Hide();    
                AnaSayfa h=new AnaSayfa();  
                h.Show();
            }
            else
            {
                MessageBox.Show("TC VEYA ŞİFRE HATALI");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  SİFRELEME.MD5SİFRELE(textBox2.Text);

            string sorgu = "select * from girişform where tc='" + textBox1.Text + "'and sifre='" + SİFRELEME.MD5SİFRELE(textBox2.Text) + "' ";


            con = new SqlConnection(SQLCon);
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
            }
            else
            {
                MessageBox.Show("TC VEYA ŞİFRE HATALI");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            con.Close();*/


            giriş();

        
        }
    }
}

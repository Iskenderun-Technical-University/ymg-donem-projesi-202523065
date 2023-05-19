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
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public static string SQLCon = "Data Source=DESKTOP-UNS7IFO\\SQLEXPRESS;Initial Catalog=projem;Integrated Security=True";

        public void rapordoldur(string sql)
        {
            con = new SqlConnection(SQLCon);
            da = new SqlDataAdapter(sql,con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            RaporArac1.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = RaporArac1;
            con.Close();



        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rapordoldur("select * from arac ");
        }
    }
}

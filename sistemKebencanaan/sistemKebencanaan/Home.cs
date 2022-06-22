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

namespace sistemKebencanaan
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            /* Show data kebencanaan from SSMS */
            // connString: Sesuaikan server dan database nya dengan yang ada di sistem aslinya
            string connString = "server = DESKTOP-FVOSJ6B\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
            //SQLDataAdapter untuk select semua data dari tabel master sistem informasi kebencanaan
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kecamatan_tm",connString);
            DataSet ds = new DataSet();
            da.Fill(ds,"kecamatan_tm");
            dataGridView1.DataSource = ds.Tables["kecamatan_tm"].DefaultView;
        }

        private void btn_insertData_Click(object sender, EventArgs e)
        {
            InsertData insertData = new InsertData();
            insertData.ShowDialog();
        }
    }
}

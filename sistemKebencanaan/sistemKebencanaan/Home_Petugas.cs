using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemKebencanaan
{
    public partial class Home_Petugas : Form
    {
        public Home_Petugas()
        {
            InitializeComponent();
        }

        public static string idData;

        // connString: Sesuaikan server dan database nya dengan yang ada di sistem aslinya
        string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";

        string selectAllQuery;

        private void refreshDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            // Refresh Data Grid 
            //SQLDataAdapter untuk select semua data dari tabel master sistem informasi kebencanaan

            selectAllQuery = "SELECT a.id_data AS [ID Data], " +
                "a.tanggal AS Tanggal, " +
                "a.waktu as Waktu, " +
                "a.jenis_bencana as [Jenis Bencana], " +
                "a.kecamatan as Kecamatan, " +
                "a.desa_kelurahan as [Desa/Kelurahan], " +
                "a.dusun_lingkungan as [Dusun/Lingkungan], " +
                "a.alamat as Alamat, " +
                "a.fasilitas as Fasilitas, " +
                "a.tingkat_kerusakan as [Tingkat Kerusakan], " +
                "a.jumlah_kk as [Jumlah KK], " +
                "a.jumlah_korban as [Jumlah Korban], " +
                "a.jumlah_korban_anak as [Jumlah Korban Anak], " +
                "a.jumlah_korban_dewasa as [Jumlah Korban Dewasa], " +
                "a.jumlah_korban_lansia as [Jumlah Korban Lansia], " +
                "a.jumlah_lukaringan as [Jumlah Korban Luka Ringan], " +
                "a.jumlah_lukaberat as [Jumlah Korban Luka Berat], " +
                "a.jumlah_meninggal as [Jumlah Korban Meninggal], " +
                "b.username as Penginput " +
                "FROM sikdeliserdang a JOIN sik_users_petugas_tm b ON a.userid_inputter = b.id_user ";

            SqlDataAdapter da = new SqlDataAdapter(selectAllQuery, connString);
            DataSet ds = new DataSet();
            da.Fill(ds, "data_kebencanaan");
            dataGridView1.DataSource = ds.Tables["data_kebencanaan"].DefaultView;

            // Coba tambah tombol Edit dan Delete di DataGridView (Untuk Home khusus Petugas)
            // "Edit" Button
            DataGridViewButtonColumn dbtn_edit = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(dbtn_edit);
            dbtn_edit.HeaderText = "Edit";
            dbtn_edit.Text = "Edit";
            dbtn_edit.Name = "btn_edit";
            dbtn_edit.UseColumnTextForButtonValue = true;

            // "Delete" Button
            DataGridViewButtonColumn dbtn_delete = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(dbtn_delete);
            dbtn_delete.HeaderText = "Delete";
            dbtn_delete.Text = "Delete";
            dbtn_delete.Name = "btn_delete";
            dbtn_delete.UseColumnTextForButtonValue = true;
        }

        private void btn_insertData_Click(object sender, EventArgs e)
        {
            InsertData insertData = new InsertData();
            insertData.ShowDialog();

            // Refresh data server 
            //SQLDataAdapter untuk select semua data dari tabel master sistem informasi kebencanaan

            refreshDataGrid();

        }

        private void Home_Petugas_Load(object sender, EventArgs e)
        {
            /* Show data kebencanaan from SSMS */
            //SQLDataAdapter untuk select semua data dari tabel master sistem informasi kebencanaan

            refreshDataGrid();


        }

        // Function Button Edit dan Delete data
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 19 || e.ColumnIndex == 0)
            {
                // Edit Data
                //MessageBox.Show("Edit ID Data : " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                idData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                EditData editData = new EditData();
                editData.ShowDialog();

                //dataGridView1.DataSource = null;
                //dataGridView1.Columns.Clear();

                refreshDataGrid();

            }
            if (e.ColumnIndex == 20 || e.ColumnIndex == 1)
            {
                // Delete Data
                string deletedIdData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                string deleteDataQuery = "DELETE FROM sikdeliserdang WHERE id_data = " + deletedIdData;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmdDeleteData = new SqlCommand(deleteDataQuery, conn);
                    cmdDeleteData.Connection.Open();

                    cmdDeleteData.CommandText = deleteDataQuery;
                    cmdDeleteData.ExecuteNonQuery();
                }

                refreshDataGrid();

                    

            }
            
        }
    }
}

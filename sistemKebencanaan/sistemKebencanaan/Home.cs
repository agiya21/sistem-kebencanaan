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

        string connString, selectAllQuery;

        private void Home_Load(object sender, EventArgs e)
        {
            /* Show data kebencanaan from SSMS */
            // connString: Sesuaikan server dan database nya dengan yang ada di sistem aslinya
            connString = "server = DESKTOP-FVOSJ6B\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
            //SQLDataAdapter untuk select semua data dari tabel master sistem informasi kebencanaan

            selectAllQuery = "SELECT a.tanggal AS Tanggal, " +
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
                "FROM sikdeliserdang a JOIN sik_users_petugas_tm b ON a.userid_inputter = b.id_user " +
                "WHERE b.username = '" + Login.uname + "'";

            SqlDataAdapter da = new SqlDataAdapter(selectAllQuery,connString);
            DataSet ds = new DataSet();
            da.Fill(ds,"data_kebencanaan");
            dataGridView1.DataSource = ds.Tables["data_kebencanaan"].DefaultView;
        }

        private void btn_insertData_Click(object sender, EventArgs e)
        {
            InsertData insertData = new InsertData();
            insertData.ShowDialog();

            // Refresh data server 
            connString = "server = DESKTOP-FVOSJ6B\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
            //SQLDataAdapter untuk select semua data dari tabel master sistem informasi kebencanaan

            selectAllQuery = "SELECT a.tanggal AS Tanggal, " +
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
                "FROM sikdeliserdang a JOIN sik_users_petugas_tm b ON a.userid_inputter = b.id_user " +
                "WHERE b.username = '" + Login.uname + "'";

            SqlDataAdapter da = new SqlDataAdapter(selectAllQuery, connString);
            DataSet ds = new DataSet();
            da.Fill(ds, "data_kebencanaan");
            dataGridView1.DataSource = ds.Tables["data_kebencanaan"].DefaultView;
        }
    }
}

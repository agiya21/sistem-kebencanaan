﻿using System;
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
        int searchCounter = 0;

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
                "a.keterangan_fasilitas as [Keterangan Fasilitas], " +
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

        private void refreshDataGridAfterSearch(string searchQuery)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            // Refresh Data Grid 
            //SQLDataAdapter untuk select semua data dari tabel master sistem informasi kebencanaan
            SqlDataAdapter da = new SqlDataAdapter(searchQuery, connString);
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

        private void cb_searchKecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb_searchKecamatan = (ComboBox)sender;
            string pilihanKecamatan = (string)cb_searchKecamatan.SelectedItem;

            string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string idKecamatanQuery = "SELECT id_kecamatan FROM kecamatan_tm WHERE nama_kecamatan = '" + pilihanKecamatan + "'";

                SqlCommand cmd = new SqlCommand(idKecamatanQuery, conn);
                cmd.Connection.Open();

                cmd.CommandText = idKecamatanQuery;
                string idKec = (string)cmd.ExecuteScalar();

                refreshItemDesaKelurahan(idKec);
            }
        }

        private void cb_searchDesaKelurahan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_searchDesaKelurahan.SelectedValue.ToString() != null)
            {
                string kodeDesaKelurahan = (string)cb_searchDesaKelurahan.SelectedValue.ToString();
                refreshItemDusunLingkugan(kodeDesaKelurahan);

            }
        }

        /* ComboBox Desa/Kelurahan */
        private void refreshItemDesaKelurahan(string kodeKecamatan)
        {
            if (cb_searchKecamatan.Text != "")
            {
                string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
                SqlConnection con = new SqlConnection(connString);
                DataRow dr;

                con.Open();
                SqlCommand cmdDesKel = new SqlCommand("SELECT * FROM desa_kelurahan_tm WHERE id_kecamatan = @kodeKecamatan", con);
                cmdDesKel.Parameters.AddWithValue("kodeKecamatan", kodeKecamatan);
                SqlDataAdapter sda = new SqlDataAdapter(cmdDesKel);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Pilih Desa/Kelurahan--" };
                dt.Rows.InsertAt(dr, 0);

                cb_searchDesaKelurahan.ValueMember = "id_desakelurahan";
                cb_searchDesaKelurahan.DisplayMember = "nama_desakelurahan";
                cb_searchDesaKelurahan.DataSource = dt;
            }

        }

        /* ComboBox Dusun Lingkungan */
        private void refreshItemDusunLingkugan(string kodeDesaKelurahan)
        {
            string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
            SqlConnection con = new SqlConnection(connString);
            DataRow dr;

            con.Open();
            SqlCommand cmdDusLing = new SqlCommand("SELECT * FROM dusun_lingkungan_tm WHERE id_desaKelurahan = @kodeDesaKelurahan", con);
            cmdDusLing.Parameters.AddWithValue("kodeDesaKelurahan", kodeDesaKelurahan);
            SqlDataAdapter sda = new SqlDataAdapter(cmdDusLing);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Pilih Dusun/Lingkungan--" };
            dt.Rows.InsertAt(dr, 0);

            cb_searchDusunLingkungan.ValueMember = "id_dusunlingkungan";
            cb_searchDusunLingkungan.DisplayMember = "nama_dusunlingkungan";
            cb_searchDusunLingkungan.DataSource = dt;
        }

        private void Home_Petugas_Load(object sender, EventArgs e)
        {
            refreshDataGrid();

            /* Tambah Item Untuk pencarian jenis bencana */
            cb_searchJenisBencana.Items.Add("");
            cb_searchJenisBencana.Items.Add("Angin Puting Beliung");
            cb_searchJenisBencana.Items.Add("Banjir");
            cb_searchJenisBencana.Items.Add("Gempa Bumi");
            cb_searchJenisBencana.Items.Add("Kebakaran");
            cb_searchJenisBencana.Items.Add("Longsor");
            cb_searchJenisBencana.Items.Add("Tsunami");

            // Tambah Item kecamatan
            cb_searchKecamatan.Items.Add("");
            string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string callItemQuery = "SELECT nama_kecamatan FROM kecamatan_tm";

                SqlCommand cmd = new SqlCommand(callItemQuery, conn);
                cmd.Connection.Open();

                cmd.CommandText = callItemQuery;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb_searchKecamatan.Items.Add((string)dr["nama_kecamatan"]);
                }
            }

            /* Tambah Item untuk pencarian Fasilitas */
            cb_searchFasilitas.Items.Add("");
            cb_searchFasilitas.Items.Add("Sekolah");
            cb_searchFasilitas.Items.Add("Rumah Ibadah");
            cb_searchFasilitas.Items.Add("Rumah Tempat Tinggal");
            cb_searchFasilitas.Items.Add("Pertanian/Perkebunan");
                        
        }

        // Function Button Edit dan Delete data
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex == 19 || e.ColumnIndex == 0)
            if (e.ColumnIndex == 20)
            {
                // Edit Data
                idData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                EditData editData = new EditData();
                editData.ShowDialog();

                refreshDataGrid();

            }
            if (e.ColumnIndex == 21)
            {

                // Delete Data
                DialogResult yesNoDelete = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?","Warning", MessageBoxButtons.YesNo);

                if(yesNoDelete == DialogResult.Yes)
                {
                    string deletedIdData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                    string deleteDataQuery = "DELETE FROM sikdeliserdang WHERE id_data = " + deletedIdData;

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        SqlCommand cmdDeleteData = new SqlCommand(deleteDataQuery, conn);
                        cmdDeleteData.Connection.Open();

                        cmdDeleteData.CommandText = deleteDataQuery;
                        cmdDeleteData.ExecuteNonQuery();
                    }

                }
                else if(yesNoDelete == DialogResult.No)
                {
                    // Do nothing, tidak menghapus data
                }

                refreshDataGrid();

            }

        }

        private void btn_searchData_Click(object sender, EventArgs e)
        {
            // kalau pilihan combobox nya tidak kosong, counter nya +1
            if (cb_searchJenisBencana.Text != "")
            {
                searchCounter += 1;
            }
            if(dtp_searchTanggal.Checked)
            {
                searchCounter += 1;
            }
            if (cb_searchKecamatan.Text != "")
            {
                searchCounter += 1;
            }
            if (cb_searchDesaKelurahan.Text != "")
            {
                searchCounter += 1;
            }
            if (cb_searchDusunLingkungan.Text != "")
            {
                searchCounter += 1;
            }
            if (cb_searchFasilitas.Text != "")
            {
                searchCounter += 1;
            }

            // Create query based on searchCounter
            string searchQuery = selectAllQuery;
            string finalSearchQuery = "";
            string searchJenisBencana, searchTanggal, searchKecamatan, searchDesaKelurahan, searchDusunLingkungan, searchFasilitas;

            searchJenisBencana = cb_searchJenisBencana.Text;
            searchTanggal = dtp_searchTanggal.Text;
            searchKecamatan = cb_searchKecamatan.Text;
            searchDesaKelurahan = cb_searchDesaKelurahan.Text;
            searchDusunLingkungan = cb_searchDusunLingkungan.Text;
            searchFasilitas = cb_searchFasilitas.Text;

            if (searchCounter > 0)
            {
                searchQuery += "WHERE ";
                if(searchJenisBencana != "")
                {
                    searchQuery += "jenis_bencana = '" + searchJenisBencana + "' AND ";
                }
                if (searchTanggal != "")
                {
                    searchQuery += "tanggal = CONVERT(DATE,'" + searchTanggal + "',103) AND "; 
                }
                if(searchKecamatan != "")
                {
                    searchQuery += "kecamatan = '" + searchKecamatan + "' AND ";
                }
                if(searchDesaKelurahan != "")
                {
                    searchQuery += "desa_kelurahan = '" + searchDesaKelurahan + "' AND ";
                }
                if(searchDusunLingkungan != "")
                {
                    searchQuery += "dusun_lingkungan = '" + searchDusunLingkungan + "' AND ";
                }
                if(searchFasilitas != "")
                {
                    searchQuery += "fasilitas = '" + searchFasilitas + "' AND ";
                }

                // Final Query, hapus kata "AND" di WHERE item yang terakhir
                finalSearchQuery = searchQuery.Remove(searchQuery.Length - 4, 4);
                
                //MessageBox.Show("Search Counter = " + searchCounter.ToString() + "\nQuery: " + finalSearchQuery);

                refreshDataGridAfterSearch(finalSearchQuery);
            }
            else
            {
                refreshDataGrid();
            }

            // reset searchCounter
            searchCounter = 0;

        }
    }
}

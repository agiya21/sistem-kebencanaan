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
    public partial class EditData : Form
    {
        string jenisBencana,
                tanggalWaktu,
                kecamatan,
                desaKelurahan,
                dusunLingkungan,
                alamat,
                fasilitas,
                keteranganFasilitas,
                tingkatKerusakan;

        string jenisBencana_new,
                tanggalWaktu_new,
                kecamatan_new,
                desaKelurahan_new,
                dusunLingkungan_new,
                alamat_new,
                fasilitas_new,
                keteranganFasilitas_new,
                tingkatKerusakan_new;

        int     id_data,
                jumlahKk,
                jumlahKorban,
                jumlahKorbanAnak,
                jumlahKorbanDewasa,
                jumlahKorbanLansia,
                jumlahLukaRingan,
                jumlahLukaBerat,
                jumlahMeninggal;

        
        int     jumlahKk_new,
                jumlahKorban_new,
                jumlahKorbanAnak_new,
                jumlahKorbanDewasa_new,
                jumlahKorbanLansia_new,
                jumlahLukaRingan_new,
                jumlahLukaBerat_new,
                jumlahMeninggal_new;

        string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";

        // Uncomment untuk pake server di laptop bapak
        //string connString = "server = LAPTOP-7KMMU9D1\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";

        public EditData()
        {
            InitializeComponent();
            tb_jumlahKorbanAnak.KeyPress += new KeyPressEventHandler(tb_jumlahKorbanAnak_KeyPress);
            tb_jumlahKorbanDewasa.KeyPress += new KeyPressEventHandler(tb_jumlahKorbanDewasa_KeyPress);
            tb_jumlahKorbanLansia.KeyPress += new KeyPressEventHandler(tb_jumlahKorbanLansia_KeyPress);
            tb_jumlahKk.KeyPress += new KeyPressEventHandler(tb_jumlahKk_KeyPress);
            tb_jumlahLukaRingan.KeyPress += new KeyPressEventHandler(tb_jumlahLukaRingan_KeyPress);
            tb_jumlahLukaBerat.KeyPress += new KeyPressEventHandler(tb_jumlahLukaBerat_KeyPress);
            tb_jumlahMeninggal.KeyPress += new KeyPressEventHandler(tb_jumlahMeninggal_KeyPress);

        }

        private void cb_kecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb_kecamatan = (ComboBox)sender;
            string pilihanKecamatan = (string)cb_kecamatan.SelectedItem;

            //string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
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

        private void cb_desaKelurahan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_desaKelurahan.SelectedValue.ToString() != null)
            {
                string kodeDesaKelurahan = (string)cb_desaKelurahan.SelectedValue.ToString();
                refreshItemDusunLingkugan(kodeDesaKelurahan);

            }
        }

        /* ComboBox Desa/Kelurahan */
        private void refreshItemDesaKelurahan(string kodeKecamatan)
        {
            //string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
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

            cb_desaKelurahan.ValueMember = "id_desakelurahan";
            cb_desaKelurahan.DisplayMember = "nama_desakelurahan";
            cb_desaKelurahan.DataSource = dt;

        }

        /* ComboBox Dusun Lingkungan */
        private void refreshItemDusunLingkugan(string kodeDesaKelurahan)
        {
            //string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
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

            cb_dusunLingkungan.ValueMember = "id_dusunlingkungan";
            cb_dusunLingkungan.DisplayMember = "nama_dusunlingkungan";
            cb_dusunLingkungan.DataSource = dt;
        }

        /* Event handler for numeric only textbox BEGIN*/
        private void tb_jumlahKorban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tb_jumlahKk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tb_jumlahLukaRingan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tb_jumlahLukaBerat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tb_jumlahMeninggal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb_jumlahKorbanAnak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb_jumlahKorbanDewasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb_jumlahKorbanLansia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /* Event handler for numeric only textbox END */

        /* Load "Insert Data" Form content */
        private void EditData_Load(object sender, EventArgs e)
        {
            /* Combo Box pilihan "Jenis Bencana" */
            cb_jenisBencana.Items.Add("Angin Puting Beliung");
            cb_jenisBencana.Items.Add("Banjir");
            cb_jenisBencana.Items.Add("Gempa Bumi");
            cb_jenisBencana.Items.Add("Kebakaran");
            cb_jenisBencana.Items.Add("Longsor");
            cb_jenisBencana.Items.Add("Tsunami");

            /* Combo Box pilihan Fasilitas */
            cb_fasilitas.Items.Add("Sekolah");
            cb_fasilitas.Items.Add("Rumah Ibadah");
            cb_fasilitas.Items.Add("Rumah Tempat Tinggal");
            cb_fasilitas.Items.Add("Pertanian/Perkebunan");

            /* Combo Box pilihan "Tingkat Kerusakan" */
            cb_tingkatKerusakan.Items.Add("Ringan (Kerusakan < 20%)");
            cb_tingkatKerusakan.Items.Add("Sedang (Kerusakan antara 20% s/d 50%)");
            cb_tingkatKerusakan.Items.Add("Berat (Kerusakan > 50%)");

            /* Combo Box pilihan "Kecamatan" */
            //string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
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
                    cb_kecamatan.Items.Add((string)dr["nama_kecamatan"]);
                }
                cmd.Connection.Close();

            }

            /* Load Isian form dengan data yang sudah ada */
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string fetchQuery = "SELECT CONCAT(" +
                    "tanggal,' ',waktu,';'," +
                    "jenis_bencana,';'," +
                    "kecamatan,';'," +
                    "desa_kelurahan,';'," +
                    "dusun_lingkungan,';'," +
                    "alamat,';'," +
                    "fasilitas,';'," +
                    "keterangan_fasilitas,';'," +
                    "tingkat_kerusakan,';'," +
                    "jumlah_kk,';'," +
                    "jumlah_korban_anak,';'," +
                    "jumlah_korban_dewasa,';'," +
                    "jumlah_korban_lansia,';'," +
                    "jumlah_lukaringan,';'," +
                    "jumlah_lukaberat,';'," +
                    "jumlah_meninggal) FROM sikdeliserdang WHERE id_data = " + Home_Petugas.idData;
                SqlCommand cmd_fetch = new SqlCommand(fetchQuery, conn);

                string fetchData = cmd_fetch.ExecuteScalar().ToString();
                // Contoh result query
                //2022-07-14 09:50:01;Banjir;Percut Sei Tuan;Desa Amplas;DUSUN II;saefsdfas;Rumah Ibadah;Sedang;1;2;4;3;5;2;3

                String[] dataList = fetchData.Split('\u003b');

                tanggalWaktu = dataList[0];
                jenisBencana = dataList[1];
                kecamatan = dataList[2];
                desaKelurahan = dataList[3];
                dusunLingkungan = dataList[4];
                alamat = dataList[5];
                fasilitas = dataList[6];
                keteranganFasilitas = dataList[7];
                tingkatKerusakan = dataList[8];
                jumlahKk = Int32.Parse(dataList[9]);
                jumlahKorbanAnak = Int32.Parse(dataList[10]);
                jumlahKorbanDewasa = Int32.Parse(dataList[11]);
                jumlahKorbanLansia = Int32.Parse(dataList[12]);
                jumlahLukaRingan = Int32.Parse(dataList[13]);
                jumlahLukaBerat = Int32.Parse(dataList[14]);
                jumlahMeninggal = Int32.Parse(dataList[15]);

                cb_jenisBencana.Text = jenisBencana;
                dtp_waktuKejadian.Text = tanggalWaktu;
                cb_kecamatan.Text = kecamatan;
                cb_desaKelurahan.Text = desaKelurahan;
                cb_dusunLingkungan.Text = dusunLingkungan;
                rtb_alamat.Text = alamat;
                cb_fasilitas.Text = fasilitas;
                tb_keteranganFasilitas.Text = keteranganFasilitas;
                if (tingkatKerusakan == "Ringan")
                {
                    cb_tingkatKerusakan.Text = "Ringan (Kerusakan < 20%)";
                }
                else if (tingkatKerusakan == "Sedang")
                {
                    cb_tingkatKerusakan.Text = "Sedang (Kerusakan antara 20% s/d 50%)";
                }
                else
                {
                    cb_tingkatKerusakan.Text = "Berat (Kerusakan > 50%)";
                }
                tb_jumlahKk.Text = jumlahKk.ToString();
                tb_jumlahKorbanAnak.Text = jumlahKorbanAnak.ToString();
                tb_jumlahKorbanDewasa.Text = jumlahKorbanDewasa.ToString();
                tb_jumlahKorbanLansia.Text = jumlahKorbanLansia.ToString();
                tb_jumlahLukaRingan.Text = jumlahLukaRingan.ToString();
                tb_jumlahLukaBerat.Text = jumlahLukaBerat.ToString();
                tb_jumlahMeninggal.Text = jumlahMeninggal.ToString();


            }

        }

        
        /* Submit Data with Submit Button*/
        private void btn_submitEditData_Click(object sender, EventArgs e)
        {
            /* Set Default value for numeric textbox */
            if (string.IsNullOrEmpty(tb_jumlahKk.Text))
            {
                tb_jumlahKk.Text = "0";
            }
            if (string.IsNullOrEmpty(tb_jumlahLukaRingan.Text))
            {
                tb_jumlahLukaRingan.Text = "0";
            }
            if (string.IsNullOrEmpty(tb_jumlahLukaBerat.Text))
            {
                tb_jumlahLukaBerat.Text = "0";
            }
            if (string.IsNullOrEmpty(tb_jumlahMeninggal.Text))
            {
                tb_jumlahMeninggal.Text = "0";
            }
            if (string.IsNullOrEmpty(tb_jumlahKorbanAnak.Text))
            {
                tb_jumlahKorbanAnak.Text = "0";
            }
            if (string.IsNullOrEmpty(tb_jumlahKorbanDewasa.Text))
            {
                tb_jumlahKorbanDewasa.Text = "0";
            }
            if (string.IsNullOrEmpty(tb_jumlahKorbanLansia.Text))
            {
                tb_jumlahKorbanLansia.Text = "0";
            }

            /* Isi variabel dengan data dari Form */
            jenisBencana_new = cb_jenisBencana.Text;
            tanggalWaktu_new = dtp_waktuKejadian.Text;
            kecamatan_new = cb_kecamatan.Text;
            desaKelurahan_new = cb_desaKelurahan.Text;
            dusunLingkungan_new = cb_dusunLingkungan.Text;
            alamat_new = rtb_alamat.Text;
            fasilitas_new = cb_fasilitas.Text;
            keteranganFasilitas_new = tb_keteranganFasilitas.Text;
            if (cb_tingkatKerusakan.Text == "Ringan (Kerusakan < 20%)")
            {
                tingkatKerusakan_new = "Ringan";
            }
            else if (cb_tingkatKerusakan.Text == "Sedang (Kerusakan antara 20% s/d 50%)")
            {
                tingkatKerusakan_new = "Sedang";
            }
            else
            {
                tingkatKerusakan_new = "Berat";
            }
            jumlahKk_new = Int32.Parse(tb_jumlahKk.Text);
            jumlahKorbanAnak_new = Int32.Parse(tb_jumlahKorbanAnak.Text);
            jumlahKorbanDewasa_new = Int32.Parse(tb_jumlahKorbanDewasa.Text);
            jumlahKorbanLansia_new = Int32.Parse(tb_jumlahKorbanLansia.Text);
            jumlahKorban_new = jumlahKorbanAnak + jumlahKorbanDewasa + jumlahKorbanLansia;
            jumlahLukaRingan_new = Int32.Parse(tb_jumlahLukaRingan.Text);
            jumlahLukaBerat_new = Int32.Parse(tb_jumlahLukaBerat.Text);
            jumlahMeninggal_new = Int32.Parse(tb_jumlahMeninggal.Text);

            /* Tampilkan Validation Box */
            string title_validation = "Insert Data";
            string mess_validation = "Apakah data yang telah anda input yakin sudah benar?\n" +
                "(Data yang telah anda masukkan tidak akan bisa diedit kembali. Anda dapat mengajukan perubahan data ke petugas)";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(mess_validation, title_validation, buttons);
            if (result.Equals(DialogResult.Yes))
            {
                /* Tampilkan data yang di Update */
                MessageBox.Show("Bencana: " + jenisBencana_new +
                                "\nTanggal: " + tanggalWaktu_new.Substring(0, 10) +
                                "\nWaktu: " + tanggalWaktu_new.Substring(11, 8) +
                                "\nKecamatan: " + kecamatan_new +
                                "\nDesa/Kelurahan: " + desaKelurahan_new +
                                "\nDusun/Lingkungan: " + dusunLingkungan_new +
                                "\nFasilitas: " + fasilitas_new +
                                "\nKeterangan Fasilitas: " + keteranganFasilitas_new +
                                "\nTingkat Kerusakan: " + tingkatKerusakan_new +
                                "\nJumlah KK: " + jumlahKk_new +
                                "\nJumlah Korban: " + jumlahKorban_new +
                                "\nJumlah Korban Anak: " + jumlahKorbanAnak_new +
                                "\nJumlah Korban Dewasa: " + jumlahKorbanDewasa_new +
                                "\nJumlah Korban Lansia: " + jumlahKorbanLansia_new +
                                "\nJumlah Korban Luka Ringan: " + jumlahLukaRingan_new +
                                "\nJumlah Korban Luka Berat: " + jumlahLukaBerat_new +
                                "\nJumlah Korban Meninggal: " + jumlahMeninggal_new +
                                "\nInputter: " + Login.uname);

                //string connString = "server = DESKTOP-IVR81VU\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    //string updateDataQuery = "UPDATE sikdeliserdang SET " +
                    //"CONVERT(date, '" + tanggalWaktu.Substring(0, 10) + "', 103), '" +
                    //tanggalWaktu.Substring(11, 8) + "', '" +
                    //jenisBencana + "', '" +
                    //kecamatan + "', '" +
                    //desaKelurahan + "', '" +
                    //dusunLingkungan + "', '" +
                    //alamat + "', '" +
                    //fasilitas + "', '" +
                    //tingkatKerusakan + "', " +
                    //jumlahKk + ", " +
                    //jumlahKorban + ", " +
                    //jumlahKorbanAnak + ", " +
                    //jumlahKorbanDewasa + ", " +
                    //jumlahKorbanLansia + ", " +
                    //jumlahLukaRingan + ", " +
                    //jumlahLukaBerat + ", " +
                    //jumlahMeninggal + ", id_user FROM sik_users_petugas_tm WHERE username = '" + Login.uname + "' ";

                    string updateDataQuery = "UPDATE sikdeliserdang SET " +
                        "tanggal = CONVERT(date, '" + tanggalWaktu_new.Substring(0, 10) + "', 103), " +
                        "waktu = '" + tanggalWaktu_new.Substring(11, 8) + "', " +
                        "jenis_bencana = '" + jenisBencana_new + "', " +
                        "kecamatan = '" + kecamatan_new + "', " +
                        "desa_kelurahan = '" + desaKelurahan_new + "', " + 
                        "dusun_lingkungan = '" + dusunLingkungan_new + "', " +
                        "alamat = '" + alamat_new + "', " + 
                        "fasilitas = '" + fasilitas_new + "', " + 
                        "keterangan_fasilitas = '" + keteranganFasilitas_new + "', " +
                        "tingkat_kerusakan = '" + tingkatKerusakan_new + "', " +
                        "jumlah_kk = '" + jumlahKk_new + "', " +
                        "jumlah_korban_anak = '" + jumlahKorbanAnak_new + "', " + 
                        "jumlah_korban_dewasa = '" + jumlahKorbanDewasa_new + "', " + 
                        "jumlah_korban_lansia = '" + jumlahKorbanLansia_new + "', " + 
                        "jumlah_lukaringan = '" + jumlahLukaRingan_new + "', " + 
                        "jumlah_lukaberat = '" + jumlahLukaBerat_new + "', " + 
                        "jumlah_meninggal = '" + jumlahMeninggal_new + "' " +
                        "WHERE id_data = " + Home_Petugas.idData;


                    SqlCommand cmdUpdateData = new SqlCommand(updateDataQuery, conn);
                    cmdUpdateData.Connection.Open();

                    cmdUpdateData.CommandText = updateDataQuery;
                    cmdUpdateData.ExecuteNonQuery();

                }
                this.Close();
            }
            else
            {
                // Do Nothing, back to "Insert Data" Form
            }

        }

    }
}

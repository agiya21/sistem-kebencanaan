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
    public partial class InsertData : Form
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

        int     jumlahKk,
                jumlahKorban,
                jumlahLukaRingan,
                jumlahLukaBerat,
                jumlahMeninggal;
        

        public InsertData()
        {
            InitializeComponent();
            tb_jumlahKorban.KeyPress += new KeyPressEventHandler(tb_jumlahKorban_KeyPress);
            tb_jumlahKk.KeyPress += new KeyPressEventHandler(tb_jumlahKk_KeyPress);
            tb_jumlahLukaRingan.KeyPress += new KeyPressEventHandler(tb_jumlahLukaRingan_KeyPress);
            tb_jumlahLukaBerat.KeyPress += new KeyPressEventHandler(tb_jumlahLukaBerat_KeyPress);
            tb_jumlahMeninggal.KeyPress += new KeyPressEventHandler(tb_jumlahMeninggal_KeyPress);

            
        }

        /* Handle Event untuk perubahan isi ComboBox Desa/Kelurahan, dan Dusun/Lingkungan */
        private void cb_kecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb_kecamatan = (ComboBox)sender;
            string pilihanKecamatan = (string)cb_kecamatan.SelectedItem;

            string connString = "server = DESKTOP-FVOSJ6B\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string idKecamatanQuery = "SELECT id_kecamatan FROM kecamatan_tm WHERE nama_kecamatan = '" + pilihanKecamatan + "'";

                SqlCommand cmd = new SqlCommand(idKecamatanQuery, conn);
                cmd.Connection.Open();

                cmd.CommandText = idKecamatanQuery;
                string idKec = (string)cmd.ExecuteScalar();

                SqlCommand cmdDesKel;
                string itemDesaKelurahanQuery = "SELECT nama_desakelurahan FROM desa_kelurahan_tm WHERE id_kecamatan = '" + idKec + "'";
                SqlDataReader dr;

                switch (idKec)
                {
                    case "A01":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();
                        cb_desaKelurahan.Items.Clear();

                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A02":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A03":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A04":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A05":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A06":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A07":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A08":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A09":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A10":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A11":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A12":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A13":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A14":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A15":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A16":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A17":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A18":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A19":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A20":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A21":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    case "A22":
                        cmdDesKel = new SqlCommand(itemDesaKelurahanQuery, conn);
                        //cmdDesKel.Connection.Open();

                        cmdDesKel.CommandText = itemDesaKelurahanQuery;
                        dr = cmdDesKel.ExecuteReader();

                        cb_desaKelurahan.Items.Clear();
                        while (dr.Read())
                        {
                            cb_desaKelurahan.Items.Add((string)dr["nama_desakelurahan"]);
                        }
                        break;
                    default:
                        cb_desaKelurahan.Items.Add("");
                        break;
                }
            }
        }

        /* Event handler for numeric only textbox */
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

        private void AddComboBoxItemDesaKelurahan(string kodeKecamatan)
        {

        }


        /* Load "Insert Data" Form content */
        private void InsertData_Load(object sender, EventArgs e)
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
            string connString = "server = DESKTOP-FVOSJ6B\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
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

            }

        }



        /* Submit Data with Submit Button*/
        private void btn_submitInsertData_Click(object sender, EventArgs e)
        {
            /* Set Default value for numeric textbox */
            if (string.IsNullOrEmpty(tb_jumlahKk.Text))
            {
                tb_jumlahKk.Text = "0";
            }
            if (string.IsNullOrEmpty(tb_jumlahKorban.Text))
            {
                tb_jumlahKorban.Text = "0";
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

            /* Isi variabel dengan data dari Form */
            jenisBencana = cb_jenisBencana.Text;
            tanggalWaktu = dtp_waktuKejadian.Text;
            kecamatan = cb_kecamatan.Text;
            desaKelurahan = cb_desaKelurahan.Text;
            //dusunLingkungan = cb_dusunLingkungan.Text;
            alamat = rtb_alamat.Text;
            fasilitas = cb_fasilitas.Text;
            keteranganFasilitas = tb_keteranganFasilitas.Text;
            if (cb_tingkatKerusakan.Text == "Ringan (Kerusakan < 20%)")
            {
                tingkatKerusakan = "Ringan";
            } else if (cb_tingkatKerusakan.Text == "Sedang (Kerusakan antara 20% s/d 50%)")
            {
                tingkatKerusakan = "Sedang";
            }
            else
            {
                tingkatKerusakan = "Berat";
            }
            jumlahKk = Int32.Parse(tb_jumlahKk.Text);
            jumlahKorban = Int32.Parse(tb_jumlahKorban.Text);
            jumlahLukaRingan = Int32.Parse(tb_jumlahLukaRingan.Text);
            jumlahLukaBerat = Int32.Parse(tb_jumlahLukaBerat.Text);
            jumlahMeninggal = Int32.Parse(tb_jumlahMeninggal.Text);

            /* Tampilkan Validation Box */
            string title_validation = "Insert Data";
            string mess_validation = "Apakah data yang telah anda input yakin sudah benar?\n" +
                "(Data yang telah anda masukkan tidak akan bisa diedit kembali. Anda dapat mengajukan perubahan data ke petugas)";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(mess_validation, title_validation, buttons);
            if (result.Equals(DialogResult.Yes))
            {
                /* Tampilkan data yang di Insert */
                MessageBox.Show("Bencana: " + jenisBencana +
                                "\nTanggal: " + tanggalWaktu.Substring(0, 10) +
                                "\nWaktu: " + tanggalWaktu.Substring(11, 8) +
                                "\nKecamatan: " + kecamatan +
                                "\nDesa/Kelurahan: " + desaKelurahan +
                                "\nDusun/Lingkungan: " + dusunLingkungan +
                                "\nFasilitas: " + fasilitas +
                                "\nKeterangan Fasilitas: " + keteranganFasilitas +
                                "\nTingkat Kerusakan: " + tingkatKerusakan +
                                "\nJumlah KK: " + jumlahKk +
                                "\nJumlah Korban: " + jumlahKorban +
                                "\nJumlah Korban Luka Ringan: " + jumlahLukaRingan +
                                "\nJumlah Korban Luka Berat: " + jumlahLukaBerat +
                                "\nJumlah Korban Meninggal: " + jumlahMeninggal);
                this.Close();
            }
            else
            {
                // Do Nothing, back to "Insert Data" Form
            }
            
        }
    }
}

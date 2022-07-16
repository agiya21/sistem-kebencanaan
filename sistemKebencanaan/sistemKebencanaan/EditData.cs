using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        int jumlahKk,
                jumlahKorban,
                jumlahKorbanAnak,
                jumlahKorbanDewasa,
                jumlahKorbanLansia,
                jumlahLukaRingan,
                jumlahLukaBerat,
                jumlahMeninggal;
        int jumlahKk_new,
                jumlahKorban_new,
                jumlahKorbanAnak_new,
                jumlahKorbanDewasa_new,
                jumlahKorbanLansia_new,
                jumlahLukaRingan_new,
                jumlahLukaBerat_new,
                jumlahMeninggal_new;

        public EditData()
        {
            InitializeComponent();

        }

        private void EditData_Load(object sender, EventArgs e)
        {

        }
    }
}

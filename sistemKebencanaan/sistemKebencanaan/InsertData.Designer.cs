namespace sistemKebencanaan
{
    partial class InsertData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_jenisBencana = new System.Windows.Forms.ComboBox();
            this.dtp_waktuKejadian = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_kecamatan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_desaKelurahan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_dusunLingkungan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtb_alamat = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_fasilitas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_tingkatKerusakan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_jumlahKk = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_jumlahLukaRingan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_jumlahLukaBerat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_jumlahMeninggal = new System.Windows.Forms.TextBox();
            this.btn_submitInsertData = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_keteranganFasilitas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_jumlahKorbanAnak = new System.Windows.Forms.TextBox();
            this.tb_jumlahKorbanDewasa = new System.Windows.Forms.TextBox();
            this.tb_jumlahKorbanLansia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Data Kebencanaan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Bencana :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Waktu Kejadian :";
            // 
            // cb_jenisBencana
            // 
            this.cb_jenisBencana.FormattingEnabled = true;
            this.cb_jenisBencana.Location = new System.Drawing.Point(218, 51);
            this.cb_jenisBencana.Name = "cb_jenisBencana";
            this.cb_jenisBencana.Size = new System.Drawing.Size(227, 21);
            this.cb_jenisBencana.TabIndex = 3;
            // 
            // dtp_waktuKejadian
            // 
            this.dtp_waktuKejadian.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtp_waktuKejadian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_waktuKejadian.Location = new System.Drawing.Point(217, 79);
            this.dtp_waktuKejadian.Name = "dtp_waktuKejadian";
            this.dtp_waktuKejadian.Size = new System.Drawing.Size(228, 20);
            this.dtp_waktuKejadian.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lokasi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kecamatan :";
            // 
            // cb_kecamatan
            // 
            this.cb_kecamatan.FormattingEnabled = true;
            this.cb_kecamatan.Location = new System.Drawing.Point(217, 126);
            this.cb_kecamatan.Name = "cb_kecamatan";
            this.cb_kecamatan.Size = new System.Drawing.Size(228, 21);
            this.cb_kecamatan.TabIndex = 7;
            this.cb_kecamatan.SelectedIndexChanged += new System.EventHandler(this.cb_kecamatan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desa/Kelurahan :";
            // 
            // cb_desaKelurahan
            // 
            this.cb_desaKelurahan.FormattingEnabled = true;
            this.cb_desaKelurahan.Location = new System.Drawing.Point(217, 154);
            this.cb_desaKelurahan.Name = "cb_desaKelurahan";
            this.cb_desaKelurahan.Size = new System.Drawing.Size(228, 21);
            this.cb_desaKelurahan.TabIndex = 9;
            this.cb_desaKelurahan.SelectedIndexChanged += new System.EventHandler(this.cb_desaKelurahan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dusun/Lingkungan :";
            // 
            // cb_dusunLingkungan
            // 
            this.cb_dusunLingkungan.FormattingEnabled = true;
            this.cb_dusunLingkungan.Location = new System.Drawing.Point(217, 182);
            this.cb_dusunLingkungan.Name = "cb_dusunLingkungan";
            this.cb_dusunLingkungan.Size = new System.Drawing.Size(228, 21);
            this.cb_dusunLingkungan.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Alamat :";
            // 
            // rtb_alamat
            // 
            this.rtb_alamat.Location = new System.Drawing.Point(217, 210);
            this.rtb_alamat.Name = "rtb_alamat";
            this.rtb_alamat.Size = new System.Drawing.Size(228, 96);
            this.rtb_alamat.TabIndex = 13;
            this.rtb_alamat.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fasilitas :";
            // 
            // cb_fasilitas
            // 
            this.cb_fasilitas.FormattingEnabled = true;
            this.cb_fasilitas.Location = new System.Drawing.Point(217, 316);
            this.cb_fasilitas.Name = "cb_fasilitas";
            this.cb_fasilitas.Size = new System.Drawing.Size(228, 21);
            this.cb_fasilitas.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tingkat Kerusakan :";
            // 
            // cb_tingkatKerusakan
            // 
            this.cb_tingkatKerusakan.FormattingEnabled = true;
            this.cb_tingkatKerusakan.Location = new System.Drawing.Point(217, 371);
            this.cb_tingkatKerusakan.Name = "cb_tingkatKerusakan";
            this.cb_tingkatKerusakan.Size = new System.Drawing.Size(228, 21);
            this.cb_tingkatKerusakan.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Jumlah KK :";
            // 
            // tb_jumlahKk
            // 
            this.tb_jumlahKk.Location = new System.Drawing.Point(217, 400);
            this.tb_jumlahKk.Name = "tb_jumlahKk";
            this.tb_jumlahKk.Size = new System.Drawing.Size(228, 20);
            this.tb_jumlahKk.TabIndex = 19;
            this.tb_jumlahKk.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 516);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Jumlah Luka Ringan :";
            // 
            // tb_jumlahLukaRingan
            // 
            this.tb_jumlahLukaRingan.Location = new System.Drawing.Point(217, 511);
            this.tb_jumlahLukaRingan.Name = "tb_jumlahLukaRingan";
            this.tb_jumlahLukaRingan.Size = new System.Drawing.Size(228, 20);
            this.tb_jumlahLukaRingan.TabIndex = 23;
            this.tb_jumlahLukaRingan.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 540);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Jumlah Luka Berat :";
            // 
            // tb_jumlahLukaBerat
            // 
            this.tb_jumlahLukaBerat.Location = new System.Drawing.Point(217, 537);
            this.tb_jumlahLukaBerat.Name = "tb_jumlahLukaBerat";
            this.tb_jumlahLukaBerat.Size = new System.Drawing.Size(228, 20);
            this.tb_jumlahLukaBerat.TabIndex = 25;
            this.tb_jumlahLukaBerat.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(93, 566);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Jumlah Meninggal :";
            // 
            // tb_jumlahMeninggal
            // 
            this.tb_jumlahMeninggal.Location = new System.Drawing.Point(217, 563);
            this.tb_jumlahMeninggal.Name = "tb_jumlahMeninggal";
            this.tb_jumlahMeninggal.Size = new System.Drawing.Size(228, 20);
            this.tb_jumlahMeninggal.TabIndex = 27;
            this.tb_jumlahMeninggal.Text = "0";
            // 
            // btn_submitInsertData
            // 
            this.btn_submitInsertData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submitInsertData.Location = new System.Drawing.Point(217, 600);
            this.btn_submitInsertData.Name = "btn_submitInsertData";
            this.btn_submitInsertData.Size = new System.Drawing.Size(110, 43);
            this.btn_submitInsertData.TabIndex = 28;
            this.btn_submitInsertData.Text = "Submit Data";
            this.btn_submitInsertData.UseVisualStyleBackColor = true;
            this.btn_submitInsertData.Click += new System.EventHandler(this.btn_submitInsertData_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 347);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Keterangan Fasilitas :";
            // 
            // tb_keteranganFasilitas
            // 
            this.tb_keteranganFasilitas.Location = new System.Drawing.Point(217, 344);
            this.tb_keteranganFasilitas.Name = "tb_keteranganFasilitas";
            this.tb_keteranganFasilitas.Size = new System.Drawing.Size(228, 20);
            this.tb_keteranganFasilitas.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(82, 458);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Jumlah Korban Dewasa :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(82, 431);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Jumlah Korban Anak :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(82, 486);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Jumlah Korban Lansia :";
            // 
            // tb_jumlahKorbanAnak
            // 
            this.tb_jumlahKorbanAnak.Location = new System.Drawing.Point(217, 428);
            this.tb_jumlahKorbanAnak.Name = "tb_jumlahKorbanAnak";
            this.tb_jumlahKorbanAnak.Size = new System.Drawing.Size(228, 20);
            this.tb_jumlahKorbanAnak.TabIndex = 34;
            this.tb_jumlahKorbanAnak.Text = "0";
            this.tb_jumlahKorbanAnak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_jumlahKorbanAnak_KeyPress);
            // 
            // tb_jumlahKorbanDewasa
            // 
            this.tb_jumlahKorbanDewasa.Location = new System.Drawing.Point(217, 456);
            this.tb_jumlahKorbanDewasa.Name = "tb_jumlahKorbanDewasa";
            this.tb_jumlahKorbanDewasa.Size = new System.Drawing.Size(228, 20);
            this.tb_jumlahKorbanDewasa.TabIndex = 35;
            this.tb_jumlahKorbanDewasa.Text = "0";
            // 
            // tb_jumlahKorbanLansia
            // 
            this.tb_jumlahKorbanLansia.Location = new System.Drawing.Point(217, 483);
            this.tb_jumlahKorbanLansia.Name = "tb_jumlahKorbanLansia";
            this.tb_jumlahKorbanLansia.Size = new System.Drawing.Size(228, 20);
            this.tb_jumlahKorbanLansia.TabIndex = 36;
            this.tb_jumlahKorbanLansia.Text = "0";
            // 
            // InsertData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 661);
            this.Controls.Add(this.tb_jumlahKorbanLansia);
            this.Controls.Add(this.tb_jumlahKorbanDewasa);
            this.Controls.Add(this.tb_jumlahKorbanAnak);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_keteranganFasilitas);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_submitInsertData);
            this.Controls.Add(this.tb_jumlahMeninggal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_jumlahLukaBerat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_jumlahLukaRingan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_jumlahKk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_tingkatKerusakan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_fasilitas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtb_alamat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_dusunLingkungan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_desaKelurahan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_kecamatan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_waktuKejadian);
            this.Controls.Add(this.cb_jenisBencana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertData";
            this.Text = "InsertData - Sistem Informasi Kebencanaan Deli Serdang";
            this.Load += new System.EventHandler(this.InsertData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_jenisBencana;
        private System.Windows.Forms.DateTimePicker dtp_waktuKejadian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_kecamatan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_desaKelurahan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_dusunLingkungan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtb_alamat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_fasilitas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_tingkatKerusakan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_jumlahKk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_jumlahLukaRingan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_jumlahLukaBerat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_jumlahMeninggal;
        private System.Windows.Forms.Button btn_submitInsertData;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_keteranganFasilitas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_jumlahKorbanAnak;
        private System.Windows.Forms.TextBox tb_jumlahKorbanDewasa;
        private System.Windows.Forms.TextBox tb_jumlahKorbanLansia;
    }
}
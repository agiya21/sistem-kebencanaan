namespace sistemKebencanaan
{
    partial class Home_Petugas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_insertData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_searchJenisBencana = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_searchTanggal = new System.Windows.Forms.DateTimePicker();
            this.cb_searchKecamatan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_searchDesaKelurahan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_searchDusunLingkungan = new System.Windows.Forms.ComboBox();
            this.cb_searchFasilitas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_searchData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1115, 297);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_insertData
            // 
            this.btn_insertData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertData.Location = new System.Drawing.Point(545, 64);
            this.btn_insertData.Name = "btn_insertData";
            this.btn_insertData.Size = new System.Drawing.Size(126, 41);
            this.btn_insertData.TabIndex = 4;
            this.btn_insertData.Text = "Insert Data";
            this.btn_insertData.UseVisualStyleBackColor = true;
            this.btn_insertData.Click += new System.EventHandler(this.btn_insertData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Informasi Kebencanaan Deli Serdang";
            // 
            // cb_searchJenisBencana
            // 
            this.cb_searchJenisBencana.FormattingEnabled = true;
            this.cb_searchJenisBencana.Location = new System.Drawing.Point(37, 145);
            this.cb_searchJenisBencana.Name = "cb_searchJenisBencana";
            this.cb_searchJenisBencana.Size = new System.Drawing.Size(121, 21);
            this.cb_searchJenisBencana.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jenis Bencana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tanggal:";
            // 
            // dtp_searchTanggal
            // 
            this.dtp_searchTanggal.CustomFormat = "dd/MM/yyyy";
            this.dtp_searchTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_searchTanggal.Location = new System.Drawing.Point(181, 145);
            this.dtp_searchTanggal.Name = "dtp_searchTanggal";
            this.dtp_searchTanggal.ShowCheckBox = true;
            this.dtp_searchTanggal.Size = new System.Drawing.Size(138, 20);
            this.dtp_searchTanggal.TabIndex = 10;
            // 
            // cb_searchKecamatan
            // 
            this.cb_searchKecamatan.FormattingEnabled = true;
            this.cb_searchKecamatan.Location = new System.Drawing.Point(347, 144);
            this.cb_searchKecamatan.Name = "cb_searchKecamatan";
            this.cb_searchKecamatan.Size = new System.Drawing.Size(136, 21);
            this.cb_searchKecamatan.TabIndex = 11;
            this.cb_searchKecamatan.SelectedIndexChanged += new System.EventHandler(this.cb_searchKecamatan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kecamatan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Desa/Kelurahan:";
            // 
            // cb_searchDesaKelurahan
            // 
            this.cb_searchDesaKelurahan.FormattingEnabled = true;
            this.cb_searchDesaKelurahan.Location = new System.Drawing.Point(510, 143);
            this.cb_searchDesaKelurahan.Name = "cb_searchDesaKelurahan";
            this.cb_searchDesaKelurahan.Size = new System.Drawing.Size(131, 21);
            this.cb_searchDesaKelurahan.TabIndex = 14;
            this.cb_searchDesaKelurahan.SelectedIndexChanged += new System.EventHandler(this.cb_searchDesaKelurahan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dusun/Lingkungan:";
            // 
            // cb_searchDusunLingkungan
            // 
            this.cb_searchDusunLingkungan.FormattingEnabled = true;
            this.cb_searchDusunLingkungan.Location = new System.Drawing.Point(666, 142);
            this.cb_searchDusunLingkungan.Name = "cb_searchDusunLingkungan";
            this.cb_searchDusunLingkungan.Size = new System.Drawing.Size(137, 21);
            this.cb_searchDusunLingkungan.TabIndex = 16;
            // 
            // cb_searchFasilitas
            // 
            this.cb_searchFasilitas.FormattingEnabled = true;
            this.cb_searchFasilitas.Location = new System.Drawing.Point(830, 142);
            this.cb_searchFasilitas.Name = "cb_searchFasilitas";
            this.cb_searchFasilitas.Size = new System.Drawing.Size(135, 21);
            this.cb_searchFasilitas.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(830, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fasilitas:";
            // 
            // btn_searchData
            // 
            this.btn_searchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchData.Location = new System.Drawing.Point(997, 125);
            this.btn_searchData.Name = "btn_searchData";
            this.btn_searchData.Size = new System.Drawing.Size(112, 41);
            this.btn_searchData.TabIndex = 19;
            this.btn_searchData.Text = "Search Data";
            this.btn_searchData.UseVisualStyleBackColor = true;
            this.btn_searchData.Click += new System.EventHandler(this.btn_searchData_Click);
            // 
            // Home_Petugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 510);
            this.Controls.Add(this.btn_searchData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_searchFasilitas);
            this.Controls.Add(this.cb_searchDusunLingkungan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_searchDesaKelurahan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_searchKecamatan);
            this.Controls.Add(this.dtp_searchTanggal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_searchJenisBencana);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_insertData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home_Petugas";
            this.Text = "Home Petugas - Sistem Kebencanaan Deli Serdang";
            this.Load += new System.EventHandler(this.Home_Petugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insertData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_searchJenisBencana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_searchTanggal;
        private System.Windows.Forms.ComboBox cb_searchKecamatan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_searchDesaKelurahan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_searchDusunLingkungan;
        private System.Windows.Forms.ComboBox cb_searchFasilitas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_searchData;
    }
}
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string uname;

        private void button1_Click(object sender, EventArgs e)
        {
            uname = tb_username.Text;
            string password = tb_password.Text;

            // Buat connection string untuk connect ke database
            string connString = "server = DESKTOP-FVOSJ6B\\MSSQLAGI; database = info_kebencanaan; Integrated Security = True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Buat query untuk response code hasil SP User Login
                // 1. Buat string query memanggil SP
                string spQuery = "DECLARE @resCode INT EXEC dbo.userLoginSIK @pLoginName = '" + uname +
                    "', @pPassword = '" + password + 
                    "', @responseCode = @resCode OUTPUT  select @resCode ";

                // 2. Buat object command untuk execute query dalam hasil scalar
                SqlCommand cmd = new SqlCommand(spQuery, conn);
                cmd.Connection.Open();

                // 3. Execute query untuk return data scalar 
                cmd.CommandText = spQuery;
                Int32 resCode = (Int32)cmd.ExecuteScalar();

                if (resCode == 1)
                {
                    string isPetugasQuery = "SELECT isPetugas FROM sik_users_petugas_tm WHERE username = '" + uname + "'" ;
                    cmd.CommandText = isPetugasQuery;
                    string petugasCode = (string)cmd.ExecuteScalar();
                    if (petugasCode == "Y")
                    {
                        MessageBox.Show("Tampilkan Form Petugas");
                    } 
                    else
                    {
                        Home home = new Home();
                        this.Hide();
                        home.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Warning");
                }

            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ecofootprint_final
{
    public partial class Signup : Form
    {
        string mysqlcon = "server=localhost;user=root;database=ecofootprint;password=";
        public Signup()
        {
            InitializeComponent();
        }

        private void signupAcc_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            string cpassword = cpasswordBox.Text.Trim();
            string email = emailBox.Text.Trim();

            if (username == "" || password == "" || email == "")
            {
                MessageBox.Show("All Fields Required!");
                return;
            }
            else if (password != cpassword)
            {
                MessageBox.Show("Password doesn't match!");
                return;
            }
            else
            {
                try
                { 
                    MySqlConnection con = new MySqlConnection(mysqlcon);
                    using (con)
                    {
                        con.Open();
                        string query = "INSERT INTO accounts(username, email, password) values (@username, @email, @password)";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue ("@email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int status = cmd.ExecuteNonQuery();
                        if (status > 0)
                        {
                            MessageBox.Show("Account Created!");
                            con.Close();
                            login log = new login();
                            log.Show();
                            this.Close();

                            return;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

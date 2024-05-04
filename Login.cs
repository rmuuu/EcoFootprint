using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ecofootprint_final
{
    public partial class login : Form
    {
        string mysqlcon = "server=localhost;user=root;database=ecofootprint;password=";
        public login()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password Required!");
                return;
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(mysqlcon);
                    using (conn)
                    {
                        conn.Open();
                        string query = "SELECT username, password FROM accounts WHERE username=@username AND password=@password LIMIT 1";
                        MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
                        ada.SelectCommand.Parameters.AddWithValue("@username",  username);
                        ada.SelectCommand.Parameters.AddWithValue("@password", password);
                        
                        DataTable table = new DataTable();
                        ada.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            conn.Close();
                            MainMenu mm = new MainMenu();
                            mm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Details!");
                            conn.Close();
                            return;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
            this.Hide();
        }
    }
}

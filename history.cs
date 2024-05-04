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
    public partial class history : Form
    {
        string mysqlcon = "server=localhost;user=root;database=ecofootprint;password=";
        public history()
        {
            InitializeComponent();
        }
        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Close();
        }
        private void find_Click(object sender, EventArgs e)
        {
            string building = buildingBox.Text;
            string month = monthBox.Text;
            string year = yearBox.Text;

            if (building == "" ||  month == "" ||  year == "")
            {
                MessageBox.Show("All Fields Required!");
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
                        string query = "SELECT pc, aircon, lightbulb, fan, viewboard, fuel, distance, time, footprint from data " +
                            "where building = '" + buildingBox.Text + "' AND month = '" + monthBox.Text + "' AND year ='" + yearBox.Text + "'";
                        MySqlCommand com = new MySqlCommand(query, con);
                        MySqlDataReader reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                            pcBox.Text = reader.GetValue(0).ToString();
                            acBox.Text = reader.GetValue(1).ToString();
                            lbBox.Text = reader.GetValue(2).ToString();
                            fanBox.Text = reader.GetValue(3).ToString();
                            vbBox.Text = reader.GetValue(4).ToString();
                            fuelBox.Text = reader.GetValue(5).ToString();
                            disBox.Text = reader.GetValue(6).ToString();
                            timeBox.Text = reader.GetValue(7).ToString();
                            cfBox.Text = reader.GetValue(8).ToString();
                        }
                        con.Close();
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

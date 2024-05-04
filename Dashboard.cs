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
    public partial class Dashboard : Form
    {
        string mysqlcon = "server=localhost;user=root;database=ecofootprint;password=";
        public Dashboard()
        {
            InitializeComponent();            
        }

        private void find_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(mysqlcon);
            using (con)
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM data WHERE month ='" + monthBox.Text + "' AND year ='" + yearBox.Text + "'";
                    MySqlCommand coms = new MySqlCommand(query, con);
                    MySqlDataReader red = coms.ExecuteReader();
                    while (red.Read())
                    {
                        this.chart1.Series["Carbon Footprint"].Points.AddXY(red.GetString("building"), red.GetDouble("footprint"));
                    }
                    con.Close();

                    con.Open();
                    string query4 = "SELECT building FROM data WHERE MAX(footprint) AND month ='" + monthBox.Text + "' AND year ='" + yearBox.Text + "'";
                    MySqlCommand coms4 = new MySqlCommand(query, con);
                    MySqlDataReader red4 = coms4.ExecuteReader();
                    while (red4.Read())
                    {
                        highBox.Text = red4.GetString("building");
                    }
                    con.Close();

                    con.Open();
                    string query2 = "SELECT SUM(pc), SUM(aircon), SUM(lightbulb), SUM(fan), SUM(viewboard) FROM data WHERE month ='" + monthBox.Text + "' AND year ='" + yearBox.Text + "'";
                    MySqlCommand coms2 = new MySqlCommand(query2, con);
                    MySqlDataReader red2 = coms2.ExecuteReader();
                    while (red2.Read())
                    {
                        this.chart2.Series["Electricity"].Points.AddXY("PC", red2.GetDouble("SUM(pc)"));
                        this.chart2.Series["Electricity"].Points.AddXY("Aircon", red2.GetDouble("SUM(aircon)"));
                        this.chart2.Series["Electricity"].Points.AddXY("Lightbulb", red2.GetDouble("SUM(lightbulb)"));
                        this.chart2.Series["Electricity"].Points.AddXY("Fan", red2.GetDouble("SUM(fan)"));
                        this.chart2.Series["Electricity"].Points.AddXY("Viewboard", red2.GetDouble("SUM(viewboard)"));
                    }
                    con.Close();

                    con.Open();
                    string query3 = "SELECT * FROM data WHERE month ='" + monthBox.Text + "' AND year ='" + yearBox.Text + "'";
                    MySqlCommand coms3 = new MySqlCommand(query3, con);
                    MySqlDataReader red3 = coms3.ExecuteReader();
                    while (red3.Read())
                    {
                        this.chart3.Series["Distance"].Points.AddXY(red3.GetString("building"), red3.GetDouble("distance"));
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Close();
        }
    }
}

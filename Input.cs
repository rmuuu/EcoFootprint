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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ecofootprint_final
{
    public partial class Input : Form
    {
        string mysqlcon = "server=localhost;user=root;database=ecofootprint;password=";
        public Input()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string building = buildingBox.Text.Trim();
            string month = monthBox.Text.Trim();
            string year = yearBox.Text.Trim();
            double pc = double.Parse(pcBox.Text);
            double aircon = double.Parse(airconBox.Text);
            double lightbulb = double.Parse(lightbulbBox.Text);
            double fan = double.Parse(fanBox.Text);
            double viewboard = double.Parse(viewboardBox.Text);
            string fuel = fuelBox.Text.Trim();
            double distance = double.Parse(distanceBox.Text);
            double time = double.Parse(timeBox.Text);

            if (building == "" || month == "" || year == "" || fuel == "")
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
                        string query = "INSERT INTO data(building, month, year, pc, aircon, lightbulb, fan, viewboard, fuel, distance, time, footprint) values (@building, @month, @year, @pc, @aircon, @lightbulb, @fan, @viewboard, @fuel, @distance, @time, @footprint)";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@building", building);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@pc", pc);
                        cmd.Parameters.AddWithValue("@aircon", aircon);
                        cmd.Parameters.AddWithValue("@lightbulb", lightbulb);
                        cmd.Parameters.AddWithValue("@fan", fan);
                        cmd.Parameters.AddWithValue("@viewboard", viewboard);
                        cmd.Parameters.AddWithValue("@fuel", fuel);
                        cmd.Parameters.AddWithValue("@distance", distance);
                        cmd.Parameters.AddWithValue("@time", time);

                        pc *= 8.69;
                        aircon *= 5.7;
                        lightbulb *= 1.6;
                        fan *= 4.34;
                        viewboard *= 5.37;
                        double kph = distance / time;
                        double gass = 0;
                        if (fuel == "Gas")
                        {
                            if (kph < 10)
                            {
                                gass = 58.1;
                            }
                            else if (kph < 20)
                            {
                                gass = 49.5;
                            }
                            else
                            {
                                gass = 39.4;
                            }
                        }
                        if (fuel == "Diesel")
                        {
                            if (kph < 10)
                            {
                                gass = 3.0;
                            }
                            else if (kph < 20)
                            {
                                gass = 2.5;
                            }
                            else
                            {
                                gass = 2.3;
                            }
                        }
                        if (fuel == "None")
                        {
                            gass = 0;
                        }

                        double footprint = pc + aircon + lightbulb + fan + viewboard + gass;
                        cmd.Parameters.AddWithValue("@footprint", footprint);

                        int status = cmd.ExecuteNonQuery();
                        if (status > 0)
                        {
                            MessageBox.Show($"Carbon Footprint = {footprint}!");
                            con.Close();
                            DialogResult result = MessageBox.Show("Do you want to create a new input?", "Question", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                this.Refresh();
                            }
                            else
                            {
                                MainMenu mm = new MainMenu();
                                mm.Show();
                                this.Close();
                            }
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

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Close();
        }
    }
}

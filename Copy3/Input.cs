using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EcoFootprint
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            StreamWriter write = File.AppendText(Application.StartupPath + "\\storage\\" + "ecofootprint.csv");
            StreamWriter w = File.AppendText(Application.StartupPath + "\\storage\\" + "values.csv");

            try
            {
                
                write.Write(monthBox.Text + " " + yearBox.Text + "\n");
                write.Write("Location Size: " + sizeBox.Text + "\n");
                write.Write("Population:" + population.Text + "\n");
                write.Write("Electric Consumption: " + bill.Text + "\n");
                write.Write("Gasoline Consumption: " + gas.Text +   "\n");
                write.Write("Waste Disposed: " + waste.Text + "\n");
                write.Write("Materials Recycled: " + recycle.Text + "\n");


                int footprint = ((int.Parse(bill.Text) / 277800) * 20) + (int.Parse(gas.Text) * 18);
                if (int.Parse(recycle.Text) > 1)
                {
                    footprint += 260;
                }
                write.Write("Carbon Footprint: " + footprint + "\n");
                write.WriteLine();

                w.WriteLine($"{monthBox.Text},{yearBox.Text},{sizeBox.Text},{pop.Text},{bill.Text},{gas.Text},{waste.Text},{recycle.Text},{footprint}");


                MessageBox.Show("Saved Successfully.\nCalculated Carbon Footprint = " + footprint);
                w.Close();
                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

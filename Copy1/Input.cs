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
            StreamWriter write = File.AppendText(Application.StartupPath + "\\storage\\" + "ecofootprint.txt");
            
            try
            {
                write.WriteLine(monthBox.Text + " " + yearBox.Text);
                write.WriteLine("Location Size: " + sizeBox.Text);
                write.WriteLine("Population:" + population.Text);
                write.WriteLine("Electric Consumption: " + bill.Text);
                write.WriteLine("Gasoline Consumption: " + gas.Text);
                write.WriteLine("Waste Disposed: " + waste.Text);
                write.WriteLine("Materials Recycled: " + recycle.Text);

                int footprint = ((int.Parse(bill.Text) / 277800) * 20) + (int.Parse(gas.Text) * 18);
                if (int.Parse(recycle.Text) > 1)
                {
                    footprint += 260;
                }
                write.WriteLine("Carbon Footprint: " + footprint);
                write.WriteLine();

                MessageBox.Show("Saved Successfully.\nCalculated Carbon Footprint = " + footprint);
                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

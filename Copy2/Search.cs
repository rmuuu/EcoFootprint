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
using System.Threading;

namespace EcoFootprint
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath + "\\storage\\" + "ecofootprint.csv";
            ofd.Filter = "CSV | *.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(Application.StartupPath + "\\storage\\" + "ecofootprint.csv");
                
                foreach (string s in lines)
                {
                    if (searchBox.Text == s)
                    {
                        textBox.AppendText(s + "\n");
                        lines = s.Split(',');
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}

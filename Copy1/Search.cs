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
            string[] filecontents = File.ReadAllLines(Application.StartupPath + "\\storage\\" + "ecofootprint.txt");
            for (var i = 0; i < filecontents.Length; i++)
            {
                if (filecontents.Contains(searchBox.Text))
                {
                    for (var j = i; j < j + 7; j++)
                    {
                        textBox.Text = filecontents[j];
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

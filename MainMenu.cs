using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecofootprint_final
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {
            Input input = new Input();
            input.Show();
            this.Hide();
        }

        private void logoutBox_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        }

        private void history_Click(object sender, EventArgs e)
        {
            history histor = new history();
            histor.Show();
            this.Close();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Close();
        }
    }
}

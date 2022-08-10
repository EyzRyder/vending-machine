using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vending_machine
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splashbar.ForeColor = Color.Gold;
            splashbar.BackColor = Color.Black;
            if (splashbar.Value < 100)
            {
                splashbar.Value = splashbar.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Form2 visivel = new Form2();
                visivel.ShowDialog();
                Application.Exit();
            }
        }

        private void splashbar_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SySHub
{
    public partial class SySHubS : Form
    {
        public SySHubS()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SySHub syshub = new SySHub();
            syshub.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.io/ITokyo");

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void siticoneGradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneGradientCircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneGradientCircleButton2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

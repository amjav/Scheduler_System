using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Scheduler_Prototype
{
    public partial class participantDisplay : Form
    {
        public participantDisplay()
        {
            InitializeComponent();
        }

        private void participantDisplay_Load(object sender, EventArgs e)
        {

        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class Initiator : Form

    {
        public Initiator()
        {
            InitializeComponent();
            InitializeMeetings();
        }

        public void InitializeMeetings()
        {
            TableLayoutControlCollection controls = tableLayoutPanel1.Controls;

            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is Label)
                {
                    controls[i].Text = "hello";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.form.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void Initiator_Load(object sender, EventArgs e)
        {

        }
    }
}

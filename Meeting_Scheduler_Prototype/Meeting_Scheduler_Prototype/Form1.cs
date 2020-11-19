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
    public partial class Form1 : Form
    {
        //low flexibility = not able to be very flexible in changing their timetable to compensate the meeting
        //high flexibilty = can easily change their timetable to attend the meeting
        Participant p1 = new Participant("Lauren", "low", true, "ps");
        Participant p2 = new Participant("Amina", "low", false, "ps");
        Participant p3 = new Participant("Soraya","high", true ,"in");
        Participant p4 = new Participant("Sanaa", "high", false, "ps");


        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

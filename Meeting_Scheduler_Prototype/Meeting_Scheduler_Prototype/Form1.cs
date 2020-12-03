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

        //lauren is the intiator
        Participant p1 = new Participant("Lauren", "low", true, "ps", true);

        //participants
        Participant p2 = new Participant("Amina", "low", false, "ps", false);
        Participant p3 = new Participant("Soraya","high", true ,"in", false);
        Participant p4 = new Participant("Sanaa", "high", false, "ps", false);
        Participant p5 = new Participant("Rudolf", "high", false, "ps", false);
        Participant p6 = new Participant("Jack Skellington", "high", false, "ps", false);

        //to run the duntions in the classes
        Participant p =  new Participant();

        //initiate List that stores all users
        List<Participant> allUsers = new List<Participant>();


        public Form1()
        {
            InitializeComponent();
            RunStart();

        }

       
        private void RunStart()
        {

            for (int i = 0; i < p.GetNames().Count; i++)
            {
                comboBox1.Items.Add(p.GetNames()[i]);
            }

            //create all users list
            allUsers = p.AllPs();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int current = comboBox1.SelectedIndex;

            foreach (Participant par in allUsers)
            {

                if (current == allUsers.IndexOf(par))
                {
                    if (par.getType() == true)
                    {
                        string output = "Initiator";
                        label2.Text = output;
                    }

                    else
                    {
                        string output = "Participant";
                        label2.Text = output;
                    }

                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void checkIntiator()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
    }
}

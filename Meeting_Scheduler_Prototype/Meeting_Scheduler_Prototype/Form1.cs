  using System;
using System.Collections.Generic;
using System.Collections;
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
        
       
        List<Participant> allUsers = new List<Participant>();
        List<Meeting> MeetingsAll = new List<Meeting>();


        //lauren is the intiator
        Participant p1 = new Participant("Lauren", "low", true, "ps", true);
        Participant p7 = new Participant("Santa Claus", "low", true, "ps", true);


        //participants
        Participant p2 = new Participant("Mrs Claus", "low", false, "ps", false);
        Participant p3 = new Participant("Soraya", "high", true, "in", false);
        Participant p4 = new Participant("Sanaa", "high", false, "ps", false);
        Participant p5 = new Participant("Rudolf", "high", false, "ps", false);
        Participant p6 = new Participant("Jack Skellington", "high", false, "ps", false);


        //to run the duntions in the classes
        Participant p =  new Participant();
        Meeting m = new Meeting();

        //initiate List that stores all users

        string loginButt = "";

        public static Form1 form;

        public Form1()
        {
            form = this;

            InitializeComponent();
            AddMeeting1();
            AddMeeting2();
            AddMeeting3();
            RunStart();
            
        }

        private void AddMeeting3()
        {
            List<string> slots = new List<string>();

            slots.Add("S1");
            slots.Add("S2");
            slots.Add("S3");
            slots.Add("S4");

            Meeting m3 = new Meeting(p7.GetName(), "North Pole", "Rudolf's Nose Surgery", true, slots);

            m3.RequestAddPs(p2);
            m3.RequestAddPs(p6);


            

        }


        private void AddMeeting2()
        {
            List<String> slot = new List<string>();
            slot.Add("S1");
            slot.Add("S2");
            slot.Add("S3");
            slot.Add("S4");

            Meeting m2 = new Meeting(p7.GetName(), "North Pole", "Christmas Dinner", true, slot);
            m2.RequestAddPs(p2);
            m2.RequestAddPs(p6);



        }

        private void AddMeeting1()
        {
            //true is a higher status than false

            List<String> slot = new List<string>();

            slot.Add("S1");
            slot.Add("S2");
            slot.Add("S3");
            slot.Add("S4");
            slot.Add("S5");

            Meeting meet1 = new Meeting(p1.GetName(),"Owen 225", "Reindeer Route Planning", true, slot);
            meet1.RequestAddPs(p2);
            meet1.RequestAddPs(p4);
            meet1.RequestAddPs(p5);


        }


        private void RunStart()
        {

            for (int i = 0; i < p.GetNames().Count; i++)
            {
                comboBox1.Items.Add(p.GetNames()[i]);
            }

            //create all users list
            allUsers = p.AllPs();
            MeetingsAll = m.returnAllList();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int current = comboBox1.SelectedIndex;
            Button1.Enabled = true;

            foreach (Participant par in allUsers)
            {

                if (current == allUsers.IndexOf(par))
                {
                    if (par.getType() == true)
                    {
                        loginButt = "Initiator";
                        label2.Text = loginButt;
                    }

                    else
                    {
                        loginButt = "Participant";
                        label2.Text = loginButt;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            if (loginButt == "Initiator")
            {
                Initiator n = new Initiator(allUsers, MeetingsAll);
                this.Hide();
                n.Show();
            }
            else
            {
                participantDisplay ps = new participantDisplay();
                this.Hide();
                ps.Show();

            }
            
        }
    }
}

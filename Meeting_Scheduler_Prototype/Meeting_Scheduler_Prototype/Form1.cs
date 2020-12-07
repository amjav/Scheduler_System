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
        List<Participant> RequestedAttendees = new List<Participant>();
        List<Participant> MeetingAttendees = new List<Participant>();
        //private static List<Meeting> InvitedMeetings = new List<Meeting>();






        //lauren is the intiator
        //static List<Meeting> p1InvitedMeetings = new List<Meeting>();
        //static List<Meeting> p1ScheduledMeetings = new List<Meeting>();

        Participant p1 = new Participant("Lauren", "low", true, "ps", true, new List<string> { "S4", "S9", "S11" });

        //static List<Meeting> p7InvitedMeetings = new List<Meeting>();
        //static List<Meeting> p7ScheduledMeetings = new List<Meeting>();

        Participant p7 = new Participant("Santa Claus", "low", true, "ps", true, new List<string> { "S1", "S2", "S3" });


        //participants
        //static List<Meeting> p2InvitedMeetings = new List<Meeting>();
        //static List<Meeting> p2ScheduledMeetings = new List<Meeting>();

        Participant p2 = new Participant("Mrs Claus", "low", false, "ps", false, new List<string> {"S1","S2","S3"});

        //static List<Meeting> p3InvitedMeetings = new List<Meeting>();
        //static List<Meeting> p3ScheduledMeetings = new List<Meeting>();

        Participant p3 = new Participant("Soraya", "high", true, "in", false, new List<string> { "S10", "S5", "S8"});

        //static List<Meeting> p4InvitedMeetings = new List<Meeting>();
        //static List<Meeting> p4ScheduledMeetings = new List<Meeting>();

        Participant p4 = new Participant("Sanaa", "high", false, "ps", false, new List<string> { "S1", "S3", "S5" });

        //static List<Meeting> p5InvitedMeetings = new List<Meeting>();
        //static List<Meeting> p5ScheduledMeetings = new List<Meeting>();

        Participant p5 = new Participant("Rudolf", "high", false, "ps", false, new List<string> { "", "", "" });

        //static List<Meeting> p6InvitedMeetings = new List<Meeting>();
        //static List<Meeting> p6ScheduledMeetings = new List<Meeting>();

        Participant p6 = new Participant("Jack Skellington", "high", false, "ps", false, new List<string> { "", "", "" });




        //to run the duntions in the classes
        Participant p = new Participant();
        Meeting m = new Meeting();

        //initiate List that stores all users

        string loginButt = "";
        public string myString = "";
        Participant User;

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
            List<Participant> requestAttendee = new List<Participant>();
            List<Participant> meetingAttendee = new List<Participant>();

            slots.Add("S1");
            slots.Add("S2");
            slots.Add("S3");
            slots.Add("S4");

            requestAttendee.Add(p2);
            requestAttendee.Add(p6);


            Meeting m3 = new Meeting(p7.GetName(), "North Pole", "Rudolf's Nose Surgery", true, slots, meetingAttendee, requestAttendee);

            p2.AddToMeetingListInvited(m3);
            p6.AddToMeetingListInvited(m3);

            

        }


        private void AddMeeting2()
        {


            List<String> slot = new List<string>();
            List<Participant> requestAttendee = new List<Participant>();
            List<Participant> meetingAttendee = new List<Participant>();

            slot.Add("S1");
            slot.Add("S2");
            slot.Add("S3");
            slot.Add("S4");


            requestAttendee.Add(p2);
            requestAttendee.Add(p6);
            requestAttendee.Add(p3);

            Meeting m2 = new Meeting(p7.GetName(), "North Pole", "Christmas Dinner", true, slot, meetingAttendee, requestAttendee);
            p2.AddToMeetingListInvited(m2);
            p6.AddToMeetingListInvited(m2);
            p3.AddToMeetingListInvited(m2);


        }

        private void AddMeeting1()
        {
            //true is a higher status than false

            List<String> slot = new List<string>();
            List<Participant> requestAttendee = new List<Participant>();
            List<Participant> meetingAttendee = new List<Participant>();

            slot.Add("S1");
            slot.Add("S2");
            slot.Add("S3");
            slot.Add("S4");
            slot.Add("S5");

            requestAttendee.Add(p2);
            requestAttendee.Add(p4);
            requestAttendee.Add(p5);


            Meeting meet1 = new Meeting(p1.GetName(), "Owen 225", "Reindeer Route Planning", true, slot, meetingAttendee, requestAttendee);

            p2.AddToMeetingListInvited(meet1);
            p4.AddToMeetingListInvited(meet1);
            p5.AddToMeetingListInvited(meet1);

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
            myString = comboBox1.SelectedItem.ToString();
            Button1.Enabled = true;

            

            foreach (Participant par in allUsers)
            {

                if (current == allUsers.IndexOf(par))
                {
                    if (par.getType() == true)
                    {
                        loginButt = "Initiator";
                        User = par;
                        label2.Text = loginButt;
                    }

                    else if (par.getType() == false)
                    {
                        loginButt = "Participant";
                        User = par;
                        label2.Text = loginButt;
                    }
                    else
                    {
                        this.Close();
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
                Initiator n = new Initiator(allUsers, MeetingsAll, RequestedAttendees, MeetingAttendees);
                this.Hide();
                n.Show();
            }
            else
            {
                participantDisplay ps = new participantDisplay(myString, allUsers, MeetingsAll, MeetingAttendees, User);
                this.Hide();
                ps.Show();

            }

        }
    }
}

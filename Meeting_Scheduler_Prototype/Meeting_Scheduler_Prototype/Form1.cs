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


        List<Participant> allUsers = new List<Participant>();
        List<Meeting> MeetingsAll = new List<Meeting>();
        List<Participant> RequestedAttendees = new List<Participant>();
        List<Participant> MeetingAttendees = new List<Participant>();

        //lauren is the intiator
        Participant p1 = new Participant("Lauren", "low", true, "Initiator", true, new List<string> { "S4", "S2", "S5" });
        Participant p7 = new Participant("Santa Claus", "low", true, "Initiator", true, new List<string> { "S1", "S2", "S3" });

        //participants
        Participant p2 = new Participant("Mrs Claus", "low", true, "Participant", false, new List<string> {"S1","S2","S3"});
        Participant p3 = new Participant("Soraya", "high", true, "Guest Speaker", false, new List<string> { "S1", "S5", "S3"});
        Participant p4 = new Participant("Sanaa", "high", false, "Participant", false, new List<string> { "S1", "S3", "S5" });
        Participant p5 = new Participant("Rudolf", "high", false, "Participant", false, new List<string> { null, null, null });
        Participant p6 = new Participant("Jack Skellington", "high", false, "Participant", false, new List<string> { null, null, null });

        //to run the duntions in the classes
        Participant p = new Participant();
        Meeting m = new Meeting();

        //initiate List that stores all users

        string loginButt = "";
        public string myString = "";
        int current;
        Participant User;
        

        // form instances
        public static List<Form> forms = new List<Form>();

        public static Form1 form;

        public Form Pcurrent = null;
        

        public Form1()
        {
            form = this;

            

            InitializeComponent();
            AddMeeting1();
            AddMeeting2();
            AddMeeting3();
            AddMeeting4();
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

            requestAttendee.Add(p5);
            requestAttendee.Add(p6);


            Meeting m3 = new Meeting(p7.GetName(), "North Pole", "Rudolf's Nose Surgery", "Pending", slots, meetingAttendee, requestAttendee);

            p5.AddToMeetingListInvited(m3);
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

            Meeting m2 = new Meeting(p7.GetName(), "North Pole", "Christmas Dinner", "Pending", slot, meetingAttendee, requestAttendee);
            p2.AddToMeetingListInvited(m2);
            p6.AddToMeetingListInvited(m2);
            p3.AddToMeetingListInvited(m2);


        }

        private void AddMeeting1()
        {
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


            Meeting meet1 = new Meeting(p1.GetName(), "Owen 225", "Reindeer Route Planning", "Pending", slot, meetingAttendee, requestAttendee);

            p2.AddToMeetingListInvited(meet1);
            p4.AddToMeetingListInvited(meet1);
            p5.AddToMeetingListInvited(meet1);

        }

        private void AddMeeting4()
        {
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


            Meeting meet1 = new Meeting(p1.GetName(), "Owen 225", "Sledge Repairs", "Pending", slot, meetingAttendee, requestAttendee);

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
            current = comboBox1.SelectedIndex;
            Button1.Enabled = true;

            //make current global.

            foreach (Participant par in allUsers)
            {

                if (current == allUsers.IndexOf(par))
                {
                    //current = user index 
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


        private void Button1_Click_1(object sender, EventArgs e)
        {
            

            if (loginButt == "Initiator")
            {
                Initiator n = new Initiator(allUsers, MeetingsAll, RequestedAttendees, MeetingAttendees, User);
                this.Hide();
                n.Show();
            }

            else
            {

                foreach (Form f in Application.OpenForms)
                {
                   participantDisplay ps;

                    Type F = typeof(participantDisplay);

                    if (f.GetType() == F)
                    {
                       

                        ps = (participantDisplay)f;

                        
                        if (ps.GetUser() == allUsers[current])
                        {
                            Pcurrent = ps.GetThis();

                        }
                        else
                        {
                            Pcurrent = null;
                        }    

                    }
                }

                if (Pcurrent != null)
                {
                    this.Hide();
                    Pcurrent.Show();
                }
                else
                {
                    participantDisplay ps = new participantDisplay(allUsers, MeetingsAll, MeetingAttendees, User);
                    forms.Add(ps);
                    this.Hide();
                    ps.Show();
                    Pcurrent = ps;
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
    }
}

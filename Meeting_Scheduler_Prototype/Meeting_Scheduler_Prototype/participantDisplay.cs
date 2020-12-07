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
        Meeting m = new Meeting();
        Participant p = new Participant();

        public List<Meeting> allMeetings = new List<Meeting>();
        public List<Meeting> InvitedMeeting = new List<Meeting>();
        public List<Meeting> ScheduledMeeting = new List<Meeting>();
        Participant User;


        public participantDisplay(List<Participant> allUsers, List<Meeting> MeetingAll, List<Participant> MeetingAttendees, Participant user)
        {
            User = user;
            allMeetings = m.returnAllList();
            InvitedMeeting = User.GetInvites();
            ScheduledMeeting = user.GetSchedule();
            InitializeComponent();
            InitializeMeetings();

        }

        public void InitializeMeetings()
        {
            label52.Text = User.GetName();
            Meeting m1 = new Meeting();
            Participant p = new Participant();


            for (int i = 0; i <= this.tableLayoutPanel2.ColumnCount; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel2.RowCount; j++)
                {
                    Control c = this.tableLayoutPanel2.GetControlFromPosition(i, j);

                    //ROW ONE

                    if (i < 4 && j == 0)
                    {
                        if (0 < InvitedMeeting.Count)
                        {
                            if (InvitedMeeting.Count > 0 && InvitedMeeting[0] != null)
                            {
                                m1 = InvitedMeeting[0];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {

                                    c.Text = m1.GetLocation();
                                }
                            }
                        }

                    }


                    if (i == 4 && j == 0)
                    {
                        if (InvitedMeeting.Count > 0 && InvitedMeeting[0] != null)
                        {
                            m1 = InvitedMeeting[0];


                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox1.Items.Add(m1.GetSlot()[k]);
                            }
                        }

                    }


                    if (i == 5 && j == 0)
                    {
                        List<string> p1 = new List<string>();
                        List<string> s1 = new List<string>();

                        p1 = User.GetPreferredSlots();
                        s1 = m1.GetSlot();

                        for (int k = 0; k < p1.Count; k++)
                        {
                            for (int t = 0; t < s1.Count; t++)
                            {
                                if (p1[k] == s1[t])
                                {
                                    listBox2.Items.Add(p1[k]);
                                }

                            }

                        }

                    }

                    //ROW 2

                    if (i < 4 && j == 1)
                    {
                        if (1 < InvitedMeeting.Count)
                        {
                            if (InvitedMeeting.Count > 1 && InvitedMeeting[1] != null)
                            {
                                m1 = InvitedMeeting[1];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {
                                    c.Text = m1.GetLocation();
                                }
                            }
                        }
                    }

                    if (i == 4 && j == 1)
                    {
                        if (1 < InvitedMeeting.Count)
                        {
                            if (InvitedMeeting.Count > 1 && InvitedMeeting[1] != null)
                            {
                                m1 = InvitedMeeting[1];

                                for (int k = 0; k < m1.GetSlot().Count; k++)
                                {
                                    listBox5.Items.Add(m1.GetSlot()[k]);
                                }
                            }
                        }
                    }

                    if (i == 5 && j == 1)
                    {

                        List<string> p1 = new List<string>();
                        List<string> s1 = new List<string>();

                        p1 = User.GetPreferredSlots();
                        s1 = m1.GetSlot();

                        for (int k = 0; k < p1.Count; k++)
                        {
                            for (int t = 0; t < s1.Count; t++)
                            {
                                if (p1[k] == s1[t])
                                {
                                    listBox3.Items.Add(p1[k]);
                                }

                            }

                        }


                    }

                    //ROW 3
                    if (i < 4 && j == 2)
                    {

                        if (2 < InvitedMeeting.Count)
                        {

                            if (InvitedMeeting.Count > 2 && InvitedMeeting[2] != null)
                            {

                                m1 = InvitedMeeting[2];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {
                                    c.Text = m1.GetLocation();
                                }
                            }
                        }
                    }

                    if (i == 4 && j == 2)
                    {
                        if (InvitedMeeting.Count > 2 && InvitedMeeting[2] != null)
                        {
                            m1 = InvitedMeeting[2];

                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox4.Items.Add(m1.GetSlot()[k]);
                            }
                        }

                    }

                    if (i == 5 && j == 2)
                    {
                        List<string> p1 = new List<string>();
                        List<string> s1 = new List<string>();

                        p1 = User.GetPreferredSlots();
                        s1 = m1.GetSlot();

                        for (int k = 0; k < p1.Count; k++)
                        {
                            for (int t = 0; t < s1.Count; t++)
                            {
                                if (p1[k] == s1[t])
                                {
                                    listBox8.Items.Add(p1[k]);
                                }

                            }

                        }
                    }

                    //ROW 4

                    if (i < 4 && j == 3)
                    {

                        if (2 < InvitedMeeting.Count)
                        {

                            if (InvitedMeeting.Count > 3 && InvitedMeeting[3] != null)
                            {

                                m1 = InvitedMeeting[3];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {
                                    c.Text = m1.GetLocation();
                                }
                            }
                        }
                    }

                    if (i == 4 && j == 3)
                    {
                        if (InvitedMeeting.Count > 3 && InvitedMeeting[3] != null)
                        {
                            m1 = InvitedMeeting[3];

                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox4.Items.Add(m1.GetSlot()[k]);
                            }
                        }

                    }

                    if (i == 5 && j == 3)
                    {
                        List<string> p1 = new List<string>();
                        List<string> s1 = new List<string>();

                        p1 = User.GetPreferredSlots();
                        s1 = m1.GetSlot();

                        for (int k = 0; k < p1.Count; k++)
                        {
                            for (int t = 0; t < s1.Count; t++)
                            {
                                if (p1[k] == s1[t])
                                {
                                    listBox8.Items.Add(p1[k]);
                                }

                            }

                        }
                    }

                    //ROW 5

                    if (i < 4 && j == 4)
                    {

                        if (2 < InvitedMeeting.Count)
                        {

                            if (InvitedMeeting.Count > 4 && InvitedMeeting[4] != null)
                            {

                                m1 = InvitedMeeting[4];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {
                                    c.Text = m1.GetLocation();
                                }
                            }
                        }
                    }

                    if (i == 4 && j == 4)
                    {
                        if (InvitedMeeting.Count > 4 && InvitedMeeting[4] != null)
                        {
                            m1 = InvitedMeeting[4];

                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox4.Items.Add(m1.GetSlot()[k]);
                            }
                        }

                    }

                    if (i == 5 && j == 4)
                    {
                        List<string> p1 = new List<string>();
                        List<string> s1 = new List<string>();

                        p1 = User.GetPreferredSlots();
                        s1 = m1.GetSlot();

                        for (int k = 0; k < p1.Count; k++)
                        {
                            for (int t = 0; t < s1.Count; t++)
                            {
                                if (p1[k] == s1[t])
                                {
                                    listBox8.Items.Add(p1[k]);
                                }

                            }

                        }

                    }
                }
            }

            //TABLE LAYOUT PANEL 2
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount; j++)
                {
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);

                    //ROW ONE

                    if (i < 4 && j == 0)
                    {
                        if (0 < ScheduledMeeting.Count)
                        {
                            if (ScheduledMeeting.Count > 0 && ScheduledMeeting[0] != null)
                            {
                                m1 = ScheduledMeeting[0];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {

                                    c.Text = m1.GetLocation();
                                }
                            }
                        }

                    }

                    //ROW TWO

                    if (i < 4 && j == 1)
                    {
                        if (1 < ScheduledMeeting.Count)
                        {
                            if (ScheduledMeeting.Count > 1 && ScheduledMeeting[1] != null)
                            {
                                m1 = ScheduledMeeting[1];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {

                                    c.Text = m1.GetLocation();
                                }
                            }
                        }
                    }

                    //ROW 3

                    if (i < 4 && j == 2)
                    {
                        if (2 < ScheduledMeeting.Count)
                        {
                            if (ScheduledMeeting.Count > 2 && ScheduledMeeting[2] != null)
                            {
                                m1 = ScheduledMeeting[2];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {

                                    c.Text = m1.GetLocation();
                                }
                            }
                        }
                    }

                    //ROW 4

                    if (i < 4 && j == 3)
                    {
                        if (3 < ScheduledMeeting.Count)
                        {
                            if (ScheduledMeeting.Count > 3 && ScheduledMeeting[3] != null)
                            {
                                m1 = ScheduledMeeting[3];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {

                                    c.Text = m1.GetLocation();
                                }
                            }
                        }
                    }

                    //ROW 5
                    if (i < 4 && j == 4)
                    {
                        if (4 < ScheduledMeeting.Count)
                        {
                            if (ScheduledMeeting.Count > 4 && ScheduledMeeting[4] != null)
                            {
                                m1 = ScheduledMeeting[4];

                                if (i == 0)
                                {
                                    c.Text = m1.GetInitiator();
                                }

                                if (i == 1)
                                {
                                    c.Text = m1.GetTitle();
                                }

                                if (i == 2)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }

                                if (i == 3)
                                {

                                    c.Text = m1.GetLocation();
                                }
                            }
                        }
                    }

                }
            }
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

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comment. adds to scheduled list however the index changes mean that when accepting multiple meetings it errors.
            Meeting m1 = new Meeting();
            m1 = InvitedMeeting[0];
            User.AddToMeetingListScheduled(m1);
            User.RemoveFromInivitedList(m1);
            InitializeMeetings();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Meeting m1 = new Meeting();
            m1 = InvitedMeeting[1];
            User.AddToMeetingListScheduled(m1);
            User.RemoveFromInivitedList(m1);
            InitializeMeetings();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Meeting m1 = new Meeting();
            m1 = InvitedMeeting[2];
            User.AddToMeetingListScheduled(m1);
            User.RemoveFromInivitedList(m1);
            InitializeMeetings();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Meeting m1 = new Meeting();
            m1 = InvitedMeeting[3];
            User.AddToMeetingListScheduled(m1);
            User.RemoveFromInivitedList(m1);
            InitializeMeetings();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Meeting m1 = new Meeting();
            m1 = InvitedMeeting[4];
            User.AddToMeetingListScheduled(m1);
            User.RemoveFromInivitedList(m1);
            InitializeMeetings();
        }
    }
}

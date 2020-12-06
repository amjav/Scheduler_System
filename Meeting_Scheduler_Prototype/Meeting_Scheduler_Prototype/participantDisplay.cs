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

        List<Participant> AllUsers = new List<Participant>();
        public List<Meeting> allMeetings = new List<Meeting>();
        public List<Meeting> InvitedMeeting = new List<Meeting>();

        string UserName;

        public participantDisplay(String name, List<Participant> allUsers, List<Meeting> MeetingAll, List<Meeting> invitedMeeting, List<Participant> MeetingAttendees)
        {
            AllUsers = p.AllPs();
            allMeetings = m.returnAllList();
            InvitedMeeting = p.GetInvites();
            UserName = name;
            InitializeComponent();
            InitializeMeetings();
        }

        public void InitializeMeetings()
        {
            Meeting m1 = new Meeting();
            Participant p = new Participant();


            for (int i = 0; i <= this.tableLayoutPanel2.ColumnCount; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel2.RowCount; j++)
                {
                    Control c = this.tableLayoutPanel2.GetControlFromPosition(i, j);

                    foreach(Participant part in AllUsers)
                    {
                            List<Meeting> currentMeet = new List<Meeting>();

                            currentMeet = part.GetInvites();
                        //comment for push
                    }

                    //        if (i < 4 && j == 1)
                    //        {
                    //            if (0 < InvitedMeeting.Count)
                    //            {
                    //                m1 = InvitedMeeting[0];

                    //                if (i == 0)
                    //                {
                    //                    c.Text = m1.GetInitiator();
                    //                }

                    //                if (i == 1)
                    //                {
                    //                    c.Text = m1.GetTitle();
                    //                }

                    //                if (i == 2)
                    //                {
                    //                    c.Text = m1.GetStatus().ToString();
                    //                }

                    //                if (i == 3)
                    //                {
                    //                    //status is a bool needs converting to a string
                    //                    c.Text = m1.GetLocation();
                    //                }

                    //            }

                    //        }


                    //        if (i == 4 && j == 1)
                    //        {
                    //            m1 = InvitedMeeting[0];


                    //            for (int k = 0; k < m1.GetSlot().Count; k++)
                    //            {
                    //                listBox1.Items.Add(m1.GetSlot()[k]);
                    //            }

                    //        }

                    //        //needs changing
                    //        if (i == 4 && j == 1)
                    //        {
                    //            List<Participant> p1 = new List<Participant>();

                    //            p1 = InvitedMeeting[0].GetRequestedPs();

                    //            for (int k = 0; k < p1.Count; k++)

                    //            {
                    //                listBox2.Items.Add(p1[k].GetName());
                    //            }

                    //        }


                    //        if (i < 4 && j == 2)
                    //        {
                    //            if (1 < InvitedMeeting.Count)
                    //            {
                    //                m1 = InvitedMeeting[1];

                    //                if (i == 0)
                    //                {
                    //                    c.Text = m1.GetInitiator();
                    //                }

                    //                if (i == 1)
                    //                {
                    //                    c.Text = m1.GetTitle();
                    //                }

                    //                if (i == 2)
                    //                {
                    //                    c.Text = m1.GetStatus().ToString();
                    //                }

                    //                if (i == 3)
                    //                {
                    //                    c.Text = m1.GetLocation();
                    //                }
                    //            }
                    //        }

                    //        if (i == 4 && j == 2)
                    //        {
                    //            m1 = InvitedMeeting[1];


                    //            for (int k = 0; k < m1.GetSlot().Count; k++)
                    //            {
                    //                listBox5.Items.Add(m1.GetSlot()[k]);
                    //            }

                    //        }

                    //        if (i == 4 && j == 2)
                    //        {
                    //            List<Participant> p1 = new List<Participant>();

                    //            p1 = InvitedMeeting[1].GetRequestedPs();

                    //            for (int k = 0; k < p1.Count; k++)

                    //            {
                    //                listBox3.Items.Add(p1[k].GetName());
                    //            }

                    //        }

                    //        if (i < 4 && j == 3)
                    //        {
                    //            if (2 < InvitedMeeting.Count)
                    //            {
                    //                m1 = InvitedMeeting[2];

                    //                if (i == 0)
                    //                {
                    //                    c.Text = m1.GetInitiator();
                    //                }

                    //                if (i == 1)
                    //                {
                    //                    c.Text = m1.GetTitle();
                    //                }

                    //                if (i == 2)
                    //                {
                    //                    c.Text = m1.GetStatus().ToString();
                    //                }

                    //                if (i == 3)
                    //                {
                    //                    c.Text = m1.GetLocation();
                    //                }
                    //            }
                    //        }

                    //        if (i == 4 && j == 3)
                    //        {
                    //            m1 = InvitedMeeting[2];


                    //            for (int k = 0; k < m1.GetSlot().Count; k++)
                    //            {
                    //                listBox4.Items.Add(m1.GetSlot()[k]);
                    //            }

                    //        }

                    //        if (i == 4 && j == 3)
                    //        {
                    //            List<Participant> p1 = new List<Participant>();

                    //            p1 = InvitedMeeting[2].GetRequestedPs();

                    //            for (int k = 0; k < p1.Count; k++)

                    //            {
                    //                listBox8.Items.Add(p1[k].GetName());
                    //            }

                    //        }

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
    }
}

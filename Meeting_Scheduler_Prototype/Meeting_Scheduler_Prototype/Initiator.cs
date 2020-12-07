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

namespace Meeting_Scheduler_Prototype
{
    public partial class Initiator : Form

    {
        Meeting m = new Meeting();
        Participant p = new Participant();

        List<Participant> AllUsers = new List<Participant>();
        public List<Meeting> allMeetings = new List<Meeting>();
        public List<Participant> requestPs = new List<Participant>();


        public Initiator(List<Participant> allUsers, List<Meeting> MeetingAll, List <Participant> RequestedAttendees, List <Participant> MeetingAttendees)
        {
            AllUsers = p.AllPs();
            allMeetings = m.returnAllList();
            requestPs = m.GetRequestedPs();
            InitializeComponent();
            InitializeMeetings();
            
        }

        

        public void InitializeMeetings()
        {
            Meeting m1 = new Meeting();
            Participant p = new Participant();

            //TableLayoutControlCollection controls = tableLayoutPanel1.Controls;

            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount; j++)
                {
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);


                    //ROW 1

                    if (i < 4 && j == 1)
                    {
                        if (0 < allMeetings.Count)
                        {
                            if (allMeetings.Count > 0 && allMeetings[0] != null)
                            {
                                m1 = allMeetings[0];

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
                                    c.Text = m1.GetLocation();
                                }

                                if (i == 3)
                                {

                                    c.Text = m1.GetStatus().ToString();
                                }
                            }
                        }

                    }


                    if (i == 4 && j == 1)
                    {
                        if (allMeetings.Count > 0 && allMeetings[0] != null)
                        {
                            m1 = allMeetings[0];


                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox1.Items.Add(m1.GetSlot()[k]);
                            }
                        }

                    }


                    if (i == 4 && j == 1)
                    {

                        List<Participant> p1 = new List<Participant>();

                        if (allMeetings.Count > 0 && allMeetings[0] != null)
                        {

                            p1 = allMeetings[0].GetRequestedPs();

                            for (int k = 0; k < p1.Count; k++)

                            {
                                listBox2.Items.Add(p1[k].GetName());
                            }
                        }

                    }


                    //ROW 2
                    if (i < 4 && j == 2)
                    {
                        if (1 < allMeetings.Count)
                        {
                            if (allMeetings.Count > 1 && allMeetings[1] != null)
                            {

                                m1 = allMeetings[1];

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
                                    c.Text = m1.GetLocation();
                                }

                                if (i == 3)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }
                            }
                        }
                    }

                    if (i == 4 && j == 2)
                    {
                        if (allMeetings.Count > 1 && allMeetings[1] != null)
                        {
                            m1 = allMeetings[1];


                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox4.Items.Add(m1.GetSlot()[k]);
                            }
                        }

                    }

                    if (i == 4 && j == 2)
                    {

                        List<Participant> p1 = new List<Participant>();
                        if (allMeetings.Count > 1 && allMeetings[1] != null)
                        {

                            p1 = allMeetings[1].GetRequestedPs();

                            for (int k = 0; k < p1.Count; k++)

                            {
                                listBox5.Items.Add(p1[k].GetName());
                            }
                        }

                    }


                    //ROW 3
                    if (i < 4 && j == 3)
                    {
                        if (2 < allMeetings.Count)
                        {
                            if (allMeetings.Count > 2 && allMeetings[2] != null)
                            {
                                m1 = allMeetings[2];

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
                                    c.Text = m1.GetLocation();
                                }

                                if (i == 3)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }
                            }
                        }
                    }

                    if (i == 4 && j == 3)
                    {
                        if (allMeetings.Count > 2 && allMeetings[2] != null)
                        {
                            m1 = allMeetings[2];


                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox7.Items.Add(m1.GetSlot()[k]);
                            }

                        }
                    }

                    if (i == 4 && j == 3)
                    {


                        List<Participant> p1 = new List<Participant>();
                        if (allMeetings.Count > 2 && allMeetings[2] != null)
                        {

                            p1 = allMeetings[2].GetRequestedPs();

                            for (int k = 0; k < p1.Count; k++)
                            {
                                listBox8.Items.Add(p1[k].GetName());
                            }
                        }


                    }

                    //ROW 4
                    if (i < 4 && j == 4)
                    {
                        if (3 < allMeetings.Count)
                        {
                            if (allMeetings.Count > 3 && allMeetings[3] != null)
                            {

                                m1 = allMeetings[3];

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
                                    c.Text = m1.GetLocation();
                                }

                                if (i == 3)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }
                            }
                        }
                    }

                    if (i == 4 && j == 4)
                    {
                        if (allMeetings.Count > 3 && allMeetings[3] != null)
                        {
                            m1 = allMeetings[3];


                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox4.Items.Add(m1.GetSlot()[k]);
                            }
                        }

                    }

                    if (i == 4 && j == 4)
                    {

                        List<Participant> p1 = new List<Participant>();

                        if (allMeetings.Count > 3 && allMeetings[3] != null)
                        { 
                                p1 = allMeetings[3].GetRequestedPs();

                            for (int k = 0; k < p1.Count; k++)

                            {
                                listBox5.Items.Add(p1[k].GetName());
                            }
                        }

                    }

                    //ROW 5
                    if (i < 4 && j == 5)
                    {
                        if (4 < allMeetings.Count)
                        {
                            if (allMeetings.Count > 4 && allMeetings[4] != null)
                            {

                                m1 = allMeetings[4];

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
                                    c.Text = m1.GetLocation();
                                }

                                if (i == 3)
                                {
                                    c.Text = m1.GetStatus().ToString();
                                }
                            }
                        }
                    }

                    if (i == 4 && j == 5)
                    {
                        if (allMeetings.Count > 4 && allMeetings[4] != null)
                        {
                            m1 = allMeetings[4];


                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox4.Items.Add(m1.GetSlot()[k]);
                            }
                        }

                    }

                    if (i == 4 && j == 5)
                    {

                        List<Participant> p1 = new List<Participant>();
                        if (allMeetings.Count > 4 && allMeetings[4] != null)
                        {
                            p1 = allMeetings[4].GetRequestedPs();

                            for (int k = 0; k < p1.Count; k++)

                            {
                                listBox5.Items.Add(p1[k].GetName());
                            }

                        }

                    }
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

        private void Initiator_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}

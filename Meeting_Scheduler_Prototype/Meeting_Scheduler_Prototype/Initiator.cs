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
        public List<Meeting> allMeetings = new List<Meeting>();


        public Initiator(List<Participant> allUsers, List<Meeting> MeetingAll)
        {
            allMeetings = m.returnAllList();
            InitializeComponent();
            InitializeMeetings();
            
        }

        

        public void InitializeMeetings()
        {
            Meeting m1 = new Meeting();

            //TableLayoutControlCollection controls = tableLayoutPanel1.Controls;

            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount; j++)
                {
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);


                    if (i < 4 && j == 1)
                    {
                        if (0 < allMeetings.Count)
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
                                //status is a bool needs converting to a string
                                c.Text = m1.GetStatus().ToString();
                            }

                        }
                        
                    }


                        if (i == 4 && j == 1)
                        {
                            m1 = allMeetings[0];


                            for (int k = 0; k < m1.GetSlot().Count; k++)
                                {
                                    listBox1.Items.Add(m1.GetSlot()[k]);
                                }

                        }

                    if (i < 4 && j == 2)
                    {
                        if (1 < allMeetings.Count)
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

                    if (i == 4 && j == 2)
                    {
                        m1 = allMeetings[1];


                        for (int k = 0; k < m1.GetSlot().Count; k++)
                        {
                            listBox4.Items.Add(m1.GetSlot()[k]);
                        }

                    }

                    if (i < 4 && j == 3)
                    {
                        if (2 < allMeetings.Count)
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

                    if (i == 4 && j == 3)
                    {
                        m1 = allMeetings[2];


                        for (int k = 0; k < m1.GetSlot().Count; k++)
                        {
                            listBox7.Items.Add(m1.GetSlot()[k]);
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
    }
}

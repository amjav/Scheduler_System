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
        public List<Meeting> CancelMeeting = new List<Meeting>();

        public List<Participant> requestPs = new List<Participant>();
        public List<Participant> meetingAttendees = new List<Participant>();
        public static Participant User;


        public Initiator(List<Participant> allUsers, List<Meeting> MeetingAll, List <Participant> RequestedAttendees, List <Participant> MeetingAttendees, Participant user)
        {
            User = user;
            AllUsers = p.AllPs();
            allMeetings = m.returnAllList();
            requestPs = m.GetRequestedPs();
            meetingAttendees = m.GetMeetingAttendees();
            InitializeComponent();
            InitializeMeetings();
            
        }

        public void UpdateLists()
        {
            AllUsers = p.AllPs();
            allMeetings = m.returnAllList();
            requestPs = m.GetRequestedPs();
            meetingAttendees = m.GetMeetingAttendees();
        }

        

        public void InitializeMeetings()
        {
            //clear listBoxes
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            listBox11.Items.Clear();
            listBox12.Items.Clear();

            label26.Text = User.GetPsType() + " " + User.GetName();

            Meeting m1 = new Meeting();
            Participant p = new Participant();

            foreach(Meeting m in allMeetings)
            {
                if(CheckImportance(m) == false)
                {
                    MessageBox.Show(m.GetTitle() + " will be cancelled as there is no important participant attending");

                    CancelMeeting.Add(m);
                    //allMeetings.Remove(m);

                    foreach(Participant par in AllUsers)
                    {
                        if (par.GetInvites().Contains(m))
                        {
                            par.RemoveFromInivitedList(m);
                        }

                        if (par.GetPending().Contains(m))
                        {
                            par.RemoveFromMeetingPending(m);
                        }

                    }
                }
            }

            foreach(Meeting m in CancelMeeting)
            {
                allMeetings.Remove(m);
            }

            UpdateLists();

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
                            if (allMeetings[0] != null)
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
                        else
                        {
                            if (i == 0)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 1)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 2)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 3)
                            {

                                c.Text = "N/A";
                            }
                        }

                    }


                    if (i == 4 && j == 1)
                    {
                        if(0< allMeetings.Count)
                        {
                            if (allMeetings[0] != null)
                            {
                                m1 = allMeetings[0];


                                for (int k = 0; k < m1.GetSlot().Count; k++)
                                {
                                    listBox1.Items.Add(m1.GetSlot()[k]);
                                }
                            }

                        }
                        else
                        {
                            listBox1.Items.Clear();
                        }
                    }


                    if (i == 5 && j == 1)
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
                        else
                        {
                            listBox2.Items.Clear();
                        }

                    }

                    if (i == 6 && j == 1)
                    {
                        List<Participant> p1 = new List<Participant>();
                        if (0 < allMeetings.Count){

                            if (allMeetings[0] != null)
                            {

                                p1 = allMeetings[0].GetMeetingAttendees();

                                for (int k = 0; k < p1.Count; k++)

                                {
                                    listBox3.Items.Add(p1[k].GetName());
                                }
                            }
                        }
                      
                    }

                    if(i == 7 && j == 1)
                    {
                        List<Control> b = new List<Control>();

                        for (int r = 0; r < flowLayoutPanel1.Controls.Count; r++)
                        {
                            b.Add(flowLayoutPanel1.Controls[r]);
                        }

                        List<string> p1 = new List<string>();
                        if (0 < allMeetings.Count)
                        {
                            if (allMeetings[0] != null)
                            {
                                int s = 0;

                                p1 = CheckSlots(allMeetings[0]);

                                
                                    foreach (string a in p1)
                                    {
                                        b[s].Text = a;
                                        s++;
                                    }
                                     
                                    for (int w = p1.Count; w < flowLayoutPanel1.Controls.Count; w++)
                                    {
                                        b[w].Enabled = false;
                                        b[w].Text = "-";
                                    }

                                

                                

                            }
                        }
                        else
                        {
                            for (int w = 0; w < flowLayoutPanel1.Controls.Count; w++)
                            {
                                b[w].Enabled = false;
                                b[w].Text = "-";
                            }
                        }
                    }


                    //ROW 2
                    if (i < 4 && j == 2)
                    {
                        if (1 < allMeetings.Count)
                        {
                            if (allMeetings[1] != null)
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
                        else
                        {
                            if (i == 0)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 1)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 2)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 3)
                            {

                                c.Text = "N/A";
                            }
                        }
                    }

                    if (i == 5 && j == 2)
                    {
                        if (allMeetings.Count > 1 && allMeetings[1] != null)
                        {
                            m1 = allMeetings[1];


                            for (int k = 0; k < m1.GetSlot().Count; k++)
                            {
                                listBox4.Items.Add(m1.GetSlot()[k]);
                            }
                        }
                        else
                        {
                            listBox4.Items.Clear();
                        }

                    }

                    if (i == 6 && j == 2)
                    {

                        List<Participant> p1 = new List<Participant>();
                        if (1 < allMeetings.Count)
                        {
                            if (allMeetings[1] != null)
                            {

                                p1 = allMeetings[1].GetRequestedPs();

                                for (int k = 0; k < p1.Count; k++)

                                {
                                    listBox5.Items.Add(p1[k].GetName());
                                }
                            }
                        }
                        else
                        {
                            listBox5.Items.Clear();
                        }

                    }

                    if (i == 7 && j == 1)
                    {

                        List<Participant> p1 = new List<Participant>();

                        if (1 < allMeetings.Count){

                            if (allMeetings[1] != null)
                            {

                                p1 = allMeetings[1].GetMeetingAttendees();

                                for (int k = 0; k < p1.Count; k++)

                                {
                                    listBox3.Items.Add(p1[k].GetName());
                                }
                            }
                        }
                        else
                        {
                            listBox3.Items.Clear();
                        }

                    }

                    if (i == 8 && j == 1)
                    {
                        List<Control> b = new List<Control>();

                        for (int r = 0; r < flowLayoutPanel2.Controls.Count; r++)
                        {
                            b.Add(flowLayoutPanel2.Controls[r]);
                        }

                        List<string> p1 = new List<string>();
                        if (1 < allMeetings.Count)
                        {

                            if (allMeetings[1] != null)
                            {

                                int s = 0;

                                p1 = CheckSlots(allMeetings[1]);

                                foreach (string a in p1)
                                {
                                    b[s].Text = a;
                                    s++;
                                }


                                for (int w = p1.Count; w < flowLayoutPanel2.Controls.Count; w++)
                                {
                                    b[w].Enabled = false;
                                    b[w].Text = "-";
                                }
                            }
                        }
                        else 
                        {
                            for (int w = 0; w < flowLayoutPanel2.Controls.Count; w++)
                            {
                                b[w].Enabled = false;
                                b[w].Text = "-";
                            }
                        }
                    }



                    //ROW 3
                    if (i < 4 && j == 3)
                    {
                        if (2 < allMeetings.Count)
                        {
                            if (allMeetings[2] != null)
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
                        
                            else
                            {
                                if (i == 0)
                                {
                                    c.Text = "N/A";
                                }

                                if (i == 1)
                                {
                                    c.Text = "N/A";
                                }

                                if (i == 2)
                                {
                                    c.Text = "N/A";
                                }

                                if (i == 3)
                                {

                                    c.Text = "N/A";
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
                        else
                        {
                            listBox7.Items.Clear();
                        }
                    }

                    if (i == 5 && j == 3)
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
                        else
                        {
                            listBox8.Items.Clear();
                        }


                    }

                    if (i == 6 && j == 1)
                    {

                        List<Participant> p1 = new List<Participant>();
                        if(2< allMeetings.Count)
                        {

                            if (allMeetings[2] != null)
                            {

                                p1 = allMeetings[2].GetMeetingAttendees();

                                for (int k = 0; k < p1.Count; k++)

                                {
                                    listBox9.Items.Add(p1[k].GetName());
                                }
                            }
                        }
                        else
                        {
                            listBox9.Items.Clear();
                        }

                    }

                    if (i == 7 && j == 1)
                    {
                        List<Control> b = new List<Control>();

                        for (int r = 0; r < flowLayoutPanel3.Controls.Count; r++)
                        {
                            b.Add(flowLayoutPanel3.Controls[r]);
                        }

                        List<string> p1 = new List<string>();

                        if (2 < allMeetings.Count)
                        {
                            if (allMeetings[2] != null)
                            {
                                int s = 0;

                                p1 = CheckSlots(allMeetings[2]);

                                foreach (string a in p1)
                                {
                                    b[s].Text = a;
                                    s++;
                                }

                                for (int w = p1.Count; w < flowLayoutPanel3.Controls.Count; w++)
                                {
                                    b[w].Enabled = false;
                                    b[w].Text = "-";
                                }
                            }
                        }
                        else
                        {

                            for (int w = 0; w < flowLayoutPanel4.Controls.Count; w++)
                            {
                                b[w].Enabled = false;
                                b[w].Text = "-";
                            }

                        }
                    }
                    


                    //ROW 4
                    if (i < 4 && j == 4)
                    {
                        if (3 < allMeetings.Count)
                        {
                            if (allMeetings[3] != null)
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
                        else
                        {
                            if (i == 0)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 1)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 2)
                            {
                                c.Text = "N/A";
                            }

                            if (i == 3)
                            {

                                c.Text = "N/A";
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
                                listBox10.Items.Add(m1.GetSlot()[k]);
                            }
                        }
                        else
                        {
                            listBox10.Items.Clear();
                        }

                    }

                    if (i == 5 && j == 4)
                    {

                        List<Participant> p1 = new List<Participant>();

                        if (allMeetings.Count > 3 && allMeetings[3] != null)
                        { 
                                p1 = allMeetings[3].GetRequestedPs();

                            for (int k = 0; k < p1.Count; k++)

                            {
                                listBox11.Items.Add(p1[k].GetName());
                            }
                        }
                        else
                        {
                            listBox11.Items.Clear();
                        }

                    }
                    if (i == 6 && j == 1)
                    {

                        List<Participant> p1 = new List<Participant>();
                        if (3 < allMeetings.Count)
                        {
                            if (allMeetings[3] != null)
                            {

                                p1 = allMeetings[3].GetMeetingAttendees();

                                for (int k = 0; k < p1.Count; k++)

                                {
                                    listBox12.Items.Add(p1[k].GetName());
                                }
                            }
                        }

                    }

                    if (i == 7 && j == 1)
                    {
                        List<Control> b = new List<Control>();
                        List<string> p1 = new List<string>();


                        for (int r = 0; r < flowLayoutPanel4.Controls.Count; r++)
                        {
                            b.Add(flowLayoutPanel4.Controls[r]);
                        }

                        if (3 < allMeetings.Count)
                        {

                            if (allMeetings[3] != null)
                            {
         

                                int s = 0;

                                p1 = CheckSlots(allMeetings[3]);

                                foreach (string a in p1)
                                {
                                    b[s].Text = a;
                                    s++;
                                }

                                for (int w = p1.Count; w < flowLayoutPanel4.Controls.Count; w++)
                                {
                                    b[w].Enabled = false;
                                    b[w].Text = "-";
                                }

                            }
                        }
                       
                        else
                        {
                            
                            for (int w = 0; w < flowLayoutPanel4.Controls.Count; w++)
                            {
                                b[w].Enabled = false;
                                b[w].Text = "-";
                            }
                            
                        }
                    }
                    
                }
            }

        }

        public List<string> CheckSlots(Meeting m)
        {
            
            List<string> Matchedslots = new List<string>();

            List<Participant> mAttendees = m.GetMeetingAttendees();

            List<Participant> NotAvailable = m.GetUnavailable();

            List<string> slots = m.GetSlot();

            List<List<string>> allslots = new List<List<string>>();

            for (int z = 0; z < mAttendees.Count; z++)
            {
                allslots.Add(mAttendees[z].GetPreferredSlots());
            }

            foreach(Participant par in mAttendees)
            {
                if (par.GetPreferredSlots().Contains(null))
                {
                    m.AddUnavailable(par);
                }
            }

            foreach(Participant par in NotAvailable)
            {
                m.RemoveAttendee(par);
            }

            foreach (List<string> s in allslots)
            {
                if( s.Contains(null) || s.Contains(" ")){
                   
                    continue;
                }
                else
                {
                    Matchedslots = slots.Intersect(s).ToList();
                    slots = Matchedslots;
                }
               
            } 

            if(m.GetStatus() == "Scheduled")
            {
                Matchedslots.Clear();
                return Matchedslots;
            }
            else
            {
                return Matchedslots;

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

        //New Meeting Button
        private void button1_Click(object sender, EventArgs e)
        {
            string MeetingTitle = Microsoft.VisualBasic.Interaction.InputBox("Title of meeting?", "Title", "Default Text");
            string Location = Microsoft.VisualBasic.Interaction.InputBox("Location of meeting?", "Title", "Default Text");
            string status = Microsoft.VisualBasic.Interaction.InputBox("Status of meeting?", "Title", "Default Text");

            List<Participant> requestAttendee = new List<Participant>();
            List<Participant> meetingAttendee = new List<Participant>();

            List<string> meetingSlots = new List<string>();
        
            bool AnsStat = false;

            do
            {
                DialogResult dialogResult = MessageBox.Show("Add a Meeting Slot?", "Cancel Meeting", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string slot = Microsoft.VisualBasic.Interaction.InputBox("Slot name?", "Title", "Default Text");
                    meetingSlots.Add(slot);
                }

                else if (dialogResult == DialogResult.No)
                {
                    AnsStat = true;
                }

            } while (!AnsStat);

            foreach (Participant par in AllUsers)
            {
                if(par.returnInitiator() == true)
                {
                    continue;
                }
                else{

                    DialogResult requestAttendeeDialog = MessageBox.Show("Add " + par.GetName() + " to Meeting?", "Cancel Meeting", MessageBoxButtons.YesNo);

                    if (requestAttendeeDialog == DialogResult.Yes)
                    {
                        requestAttendee.Add(par);
                    }
                }
                
            }


            Meeting m = new Meeting(User.GetName(), Location, MeetingTitle, status, meetingSlots, meetingAttendee, requestAttendee);
            

            foreach (Participant v in requestAttendee)
            {
                v.AddToMeetingListInvited(m);

            }


            //allMeetings.Add(m);
            UpdateLists();
            InitializeMeetings();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }



        public bool CheckImportance(Meeting m)
        {
            bool attendance = false;

            List<Participant> meetingPart = m.GetRequestedPs();

            foreach(Participant par in meetingPart)
            {
                if(par.GetImportance() == true)
                {
                    List<string> slots = par.GetPreferredSlots();

                    foreach (string slot in slots)
                    {
                        if (m.GetSlot().Contains(slot))
                        {
                            attendance = true;
                        }
                    }
                }
            }

            return attendance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = button3.Text;

            Meeting m = allMeetings[0];

            string l = m.GetLocation();

            bool criteria = true;


            foreach(Meeting meet in allMeetings)
            {
                if(l == meet.GetLocation())
                {
                    if(meet.GetStatus() == "Scheduled")
                    {
                        if(s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false) { 
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {   
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                { 
                
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);
                
                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = button2.Text;

            Meeting m = allMeetings[0];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                            
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == true) { 

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = button5.Text;

            Meeting m = allMeetings[0];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                           
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == true){

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
               
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = button1.Text;

            Meeting m = allMeetings[0];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }


            if (criteria == true)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = button4.Text;

            Meeting m = allMeetings[0];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == true)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = button6.Text;

            Meeting m = allMeetings[0];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == true)
            {

            List<Participant> NotAvailable = new List<Participant>();
            NotAvailable = m.GetUnavailable();
            foreach (Participant par in NotAvailable)
            {
                MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
            }

            DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                m.SetAllAccepted();
                m.SetScheduledSlot(s);

                foreach (Participant par in m.GetMeetingAttendees())
                {
                    par.AddToMeetingListScheduled(m);
                    par.RemoveFromMeetingPending(m);
                }

            }

            UpdateLists();
            InitializeMeetings();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = button7.Text;

            Meeting m = allMeetings[1];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }


            if (criteria == true)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = button8.Text;

            Meeting m = allMeetings[1];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                            
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == true)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();

                foreach(Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s = button9.Text;

            Meeting m = allMeetings[1];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == true)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = button10.Text;

            Meeting m = allMeetings[1];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                            
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == true)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }


                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string s = button11.Text;

            Meeting m = allMeetings[1];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                            
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == false)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string s = button12.Text;

            Meeting m = allMeetings[1];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                           
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria == false)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string s = button7.Text;

            Meeting m = allMeetings[2];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }


            if (criteria == true)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string s = button14.Text;

            Meeting m = allMeetings[2];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                            
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }


            if (criteria == true){

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string s = button15.Text;

            Meeting m = allMeetings[2];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string s = button16.Text;

            Meeting m = allMeetings[2];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string s = button17.Text;

            Meeting m = allMeetings[2];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string s = button18.Text;

            Meeting m = allMeetings[2];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string s = button19.Text;

            Meeting m = allMeetings[3];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                            
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string s = button20.Text;

            Meeting m = allMeetings[3];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                           
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }
            }

            UpdateLists();
            InitializeMeetings();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string s = button21.Text;

            Meeting m = allMeetings[3];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string s = button22.Text;

            Meeting m = allMeetings[3];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string s = button23.Text;

            Meeting m = allMeetings[3];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                        }
                    }
                }


            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {

                
                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string s = button24.Text;

            Meeting m = allMeetings[3];

            string l = m.GetLocation();

            bool criteria = true;

            foreach (Meeting meet in allMeetings)
            {
                if (l == meet.GetLocation())
                {
                    if (meet.GetStatus() == "Scheduled")
                    {
                        if (s == meet.GetScheduledSlot())
                        {
                            MessageBox.Show("This Meeting cannot be scheduled. Please select a new slot");
                            criteria = false;

                         
                        }
                    }
                }
            }

            if (CheckImportance(m) == false)
            {
                MessageBox.Show("This Meeting cannot be scheduled. Important Participant cannot attend");
                criteria = false;
            }

            if (criteria != false)
            {

                List<Participant> NotAvailable = new List<Participant>();
                NotAvailable = m.GetUnavailable();
                foreach (Participant par in NotAvailable)
                {
                    MessageBox.Show("Participant " + par.GetName() + " cannot make the meeting and will be removed if this slot is selected!");
                }

                DialogResult result = MessageBox.Show("Do you want to schedule meeting " + allMeetings[0].GetTitle() + " in slot " + s + " ?", "Button", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    m.SetAllAccepted();
                    m.SetScheduledSlot(s);

                    foreach (Participant par in m.GetMeetingAttendees())
                    {
                        par.AddToMeetingListScheduled(m);
                        par.RemoveFromMeetingPending(m);
                    }

                }

                UpdateLists();
                InitializeMeetings();
            }
        }
    }
}

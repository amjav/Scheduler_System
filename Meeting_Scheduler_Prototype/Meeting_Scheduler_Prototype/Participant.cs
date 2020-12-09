using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    public class Participant
    {
        private string Name;
        //public string Status;
        private string Flexibility;
        private bool Importance;
        private string Type;
        private bool Initiator;

        public static List<Participant> users = new List<Participant>();
        public List<Meeting> InvitedMeetings = new List<Meeting>();
        public List<Meeting> PendingMeetings = new List<Meeting>();
        public List<Meeting> ScheduledMeetings = new List<Meeting>();
        public List<string> PreferredSlots = new List<string>();

        // List <Meeting>

        // Commented out status for now as we need to determine what it is?

        public Participant(string name, string flex, bool importance,string PsType, bool initiator, List<string> preferredSlots)
        {
            Name = name;
            Flexibility = flex;
            Importance = importance;
            Type = PsType;
            //Status = status;
            Initiator = initiator;
            PreferredSlots = preferredSlots;
            //create list of meetings participant has been invited to
            InvitedMeetings = new List<Meeting>();
            //
            PendingMeetings = new List<Meeting>();
            // create list of meetings participant has been Scheduled to attend
            ScheduledMeetings = new List<Meeting>();
            ////add name to a list of users
            users.Add(this);

        }

       

        public bool returnInitiator()
        {
            return Initiator;
        }

        public void AddToMeetingListInvited(Meeting m)
        {
            InvitedMeetings.Add(m);
        }

        public void AddtoMeetingPending (Meeting m)
        {
            PendingMeetings.Add(m);
        }

        public void RemoveFromMeetingPending(Meeting m)
        {
            PendingMeetings.Remove(m);
        }
        public Participant()
        {

        }

        public void RemoveFromInivitedList(Meeting p)
        {
            InvitedMeetings.Remove(p);
        }

        public void AddToMeetingListScheduled(Meeting m)
        {
            ScheduledMeetings.Add(m);
        }

        public bool getType()
        {
            return Initiator;
        }


        public string GetName()
        {
            return Name;
        }


        //public string GetStatus()
        //{
        //    return Status;
        //}

        public string GetFlexibility()
        {
            return Flexibility;
        }

        public bool GetImportance()
        {
            return Importance;
        }

        public List<Meeting> GetInvites()
        {
            return InvitedMeetings;
        }

        public List<Meeting> GetPending()
        {
            return PendingMeetings;
        }
        public List<Meeting> GetSchedule()
        {
            return ScheduledMeetings;
        }

        public List<string> GetPreferredSlots()
        {
            return PreferredSlots;
        }

        public List<String> GetNames()
        {
            List<string> names = new List<string>();
            //done just to fill in return parameter
            foreach( Participant participant in users)
            {
                names.Add(participant.GetName());
            }

            return names;
        }

        public List<Participant> AllPs()
        {
            return users;
        }

        public void search(string name)
        {
            //a paramater name would be taken in and looped through participants for a match?
        }
    }
}

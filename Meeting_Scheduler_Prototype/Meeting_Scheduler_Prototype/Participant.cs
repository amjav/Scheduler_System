using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    class Participant
    {
        private string Name;
        //public string Status;
        private string Flexibility;
        private bool Importance;
        private string Type;
        private bool Initiator;

        public static List<Participant> users = new List<Participant>();

        // Commented out status for now as we need to determine what it is?

        public Participant(string name, string flex, bool importance,string PsType, bool initiator)
        {
            Name = name;
            Flexibility = flex;
            Importance = importance;
            Type = PsType;
            //Status = status;
            Initiator = initiator;
            //add name to a list of users
            users.Add(this);

        }

        public Participant()
        {

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

        public string GetMeeting()
        {
            return null;
        }

        public string GetSchedule()
        {
            return null;
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

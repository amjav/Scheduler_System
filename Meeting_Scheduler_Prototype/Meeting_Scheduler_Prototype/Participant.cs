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

        public List<string> users = new List<string>();

        // Commented out status for now as we need to determine what it is?

        public Participant(string name, string flex, bool importance,string type)
        {
            Name = name;
            Flexibility = flex;
            Importance = importance;
            Type = type;
            //Status = status;

            users.Add(GetName());

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
    }
}

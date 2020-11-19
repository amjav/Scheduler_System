using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    class Participant
    {
        public string Name;
        public string Status;
        public string Flexibility;
        public string Importance;

        public string GetName()
        {
            return Name;
        }

        public string GetStatus()
        {
            return Status;
        }

        public string GetFlexibility()
        {
            return Flexibility;
        }

        public string GetImportance()
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

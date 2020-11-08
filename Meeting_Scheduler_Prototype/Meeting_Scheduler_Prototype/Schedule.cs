using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    class Schedule
    {
        public List<DateTime> schedule = new List<DateTime>();
        public List<DateTime> preference = new List<DateTime>();
        public List<DateTime> exclusion = new List<DateTime>();

        public void AddMeeting(DateTime date)
        {
            
        }

        public bool attend(DateTime date)
        {
            //some sort of if statement placed here
            return true;
        }

        public void AddPreference()
        {

        }

        public void AddExclusion()
        {

        }

    }
}

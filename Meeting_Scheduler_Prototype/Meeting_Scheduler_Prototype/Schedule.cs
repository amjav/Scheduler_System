using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    class Schedule
    {
        public List<Meeting> schedule = new List<Meeting>();
        //holds the meetings that have been scheduled that are going to happen.
        public List<DateTime> preference = new List<DateTime>();
        // list of dates of which participant is able to attend
        public List<DateTime> exclusion = new List<DateTime>();
        //cannot attend the meeting

        public void AddMeeting(DateTime date)
        {
            
        }

        public bool attend(DateTime date)
        {
            //some sort of if statement placed here
            return true;
        }

        public void AddPreference(DateTime date)
        {

        }

        public void AddExclusion()
        {

        }

    }
}

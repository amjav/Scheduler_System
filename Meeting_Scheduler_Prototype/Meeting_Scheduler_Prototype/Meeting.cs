using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    class Meeting
    {
        public List<DateTime> DateHourRange = new List<DateTime>();
        //contains a range of date hours in which the meeting could be

        public List<Participant> MeetingAttendees = new List<Participant>();
        //list of participants that can attend the meeting

        public List<Participant> RequestAttend = new List<Participant>();
    }
}

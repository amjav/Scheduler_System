using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    class Meeting
    {
        public DateTime[] DateHourRange = new DateTime[5];
        //contains a range of date hours in which the meeting could be

        public List<Participant> MeetingAttendees = new List<Participant>();
        //list of participants that can attend the meeting

        public List<Participant> RequestAttend = new List<Participant>();

        public string Location;
        public string Initiator;

        public Meeting(string intiator, string location, DateTime[] datehourrange)
        {
            Initiator = intiator;
            Location = location;
            DateHourRange = datehourrange;
        }

        public void RequestAddPs(Participant p)
        {
            RequestAttend.Add(p);
        }

        public void MeetingAttend (Participant p)
        {
            MeetingAttendees.Add(p);
        }


    }
}

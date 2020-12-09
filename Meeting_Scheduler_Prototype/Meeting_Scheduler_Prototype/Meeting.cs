using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    public class Meeting
    {
        public static List<Meeting> AllMeetingList = new List<Meeting>();

        public List<string> MeetingSlot = new List<string>();
        //contains a range of date hours in which the meeting could be

        public List<Participant> MeetingAttendees = new List<Participant>();
        //list of participants that can attend the meeting

        public List<Participant> RequestAttend = new List<Participant>();

        public string Location;
        public string Initiator;
        string Title;
        string Status;

        public Meeting(string intiator, string location, string title, string status, List<string> MeetingSlots, List <Participant> meetingattendees, List<Participant> requestattend)
        {
            Initiator = intiator;
            Location = location;
            Title = title;
            Status = status;
            MeetingSlot = MeetingSlots;

            MeetingAttendees = meetingattendees;

            RequestAttend = requestattend;

            
            AllMeetingList.Add(this);
        }

        public Meeting()
        {
            //empty constructor to intialise.
        }

        public List<string> GetSlot()
        {
            
            return MeetingSlot;
        }

        public List<Participant> GetRequestedPs()
        {
            return RequestAttend;
        }

        public List<Participant> GetMeetingAttendees()
        {
            return MeetingAttendees;
        }

        public void AddSlot(string slotName)
        {
            MeetingSlot.Add(slotName);
        }

        public void RequestAddPs(Participant p)
        {
            RequestAttend.Add(p);
        }

        public void AddMeetingAttend (Participant p)
        {
            MeetingAttendees.Add(p);
        }

        public List<Meeting> returnAllList()
        {
            return AllMeetingList;
        }


        public string GetLocation()
        {
            return Location;
        }

        public string GetInitiator()
        {
            return Initiator;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetStatus()
        {
            return Status;
        }

        public void SetAllAccepted()
        {
           Status = "All confirmed";

          
        }
    }
}

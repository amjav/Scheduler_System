using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    class Participants : Participant //inherits participant?

    {

        public Participants(string name, string flex, bool importance, string PsType, bool initiator) : base( name,  flex,  importance, PsType,initiator)
        {
            
        }


        //public void search(string name)
        //{
        //    //a paramater name would be taken in and looped through participants for a match?
        //}
    }
}

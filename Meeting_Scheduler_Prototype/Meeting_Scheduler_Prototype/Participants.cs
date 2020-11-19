using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduler_Prototype
{
    class Participants : Participant //inherits participant?

    {

        public Participants(string name, string flex, bool importance, string type): base( name,  flex,  importance,  type)
        {
            
        }


        

        public string GetNames()
        {
            //done just to fill in return parameter
            return "hello";
        }

        public void search(string name)
        {
            //a paramater name would be taken in and looped through participants for a match?
        }
    }
}

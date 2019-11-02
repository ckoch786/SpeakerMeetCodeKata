using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakerMeet.API
{
    public class Speaker
    {

        public Speaker(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates.Models
{
    public class Video
    {
        public string Title { get; set; }
        public List<string> Tags { get; set; }
        public float Duration { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2organize.Models
{
    public class TimeSlot
    {
        public int TimeSlotId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

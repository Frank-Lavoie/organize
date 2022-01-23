using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2organize.Models
{
    public class Disponibility
    {
        public int DisponibilityId { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public bool IsPeriodic { get; set; }
        public UserExtension User { get; set; }
    }
}

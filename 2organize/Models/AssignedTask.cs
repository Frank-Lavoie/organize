using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2organize.Models
{
    public class AssignedTask
    {
        public int AssignedTaskId { get; set; }
        public HomeTask HomeTask { get; set; }
        public UserExtension ResponsiblePersion { get; set; }
        public bool Done { get; set; }
        public TimeSlot TimeSlot { get; set; }
    }
}

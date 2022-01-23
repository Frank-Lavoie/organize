using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2organize.Models
{
    public class UserExtension
    {
        public int UserExtensionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Family Family { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4Task
{
    public class Emloyee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredData { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public int OfficeId { get; set; }
        public int TitleId { get; set; }
    }
}

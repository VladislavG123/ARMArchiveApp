using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMArchiveApp.Models
{
    public class Subscriber
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FullName { get; set; }

        // Отдел
        public string Department { get; set; }

        public string Phone { get; set; }

        public DateTime GettingDate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMArchiveApp.Models
{
    public class Delivery
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Документ
        public Document Document { get; set; }

        // Дата выдачи
        public DateTime GettingDate { get; set; }

        // Кому выдан
        public Subscriber Subscriber { get; set; }
    }
}

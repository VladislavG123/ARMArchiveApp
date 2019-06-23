using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMArchiveApp.Models
{
    public class Archive
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Стелаж
        public int Rack { get; set; }

        // Полка
        public int Shelf { get; set; }

        // Ячейка
        public int Cell { get; set; }

        public int Fullness { get; set; }
    }
}

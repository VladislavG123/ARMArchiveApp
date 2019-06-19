using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMArchiveApp.Models
{
    public class Document
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// Номер документа
        /// </summary>
        public int Number { get; set; }
        // Название
        /// <summary>
        /// Название документа
        /// </summary>
        public string Name { get; set; }
        public List<string> Themes { get; set; }
        /// <summary>
        /// Ячейка
        /// </summary>
        public int Cell { get; set; }
        public int Amount { get; set; }
        // Дата выдачи.
        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime GettingDate { get; set; }
        // Дата поступления
        /// <summary>
        /// Дата поступления
        /// </summary>
        public DateTime ReceiptDate { get; set; }

    }
}

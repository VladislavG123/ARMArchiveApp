using ARMArchiveApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMArchiveApp
{
    public partial class AddArchiveForm : Form
    {
        public AddArchiveForm()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (int.TryParse(cellTextBox.Text, out int cell)
                && int.TryParse(shelfTextBox.Text, out int shelf)
                && int.TryParse(rackTextBox.Text, out int rack)
                && cell > 0 && shelf > 0 && rack > 0)
            {
                Archive archive = new Archive
                {
                    Cell = cell,
                    Shelf = shelf,
                    Rack = rack,
                    Fullness = 0
                };
                using (var context = new ArchiveContext())
                {
                    foreach (var item in context.Archives.ToList())
                    {
                        if (!(item.Rack == archive.Rack && item.Shelf == archive.Shelf && item.Cell == archive.Cell))
                        {
                            context.Archives.Add(archive);
                            context.SaveChanges();
                            Close();
                            return;
                        }
                        MessageBox.Show("Данное раположение уже занято!");
                        return;
                    }
                    // Если context пуст, тогда forech не сработает, в этом случае сробатывает эта команда
                    context.Archives.Add(archive);
                    context.SaveChanges();
                    Close();
                    return;
                }
            }
            MessageBox.Show("Данные введены не верно!");

        }
    }
}

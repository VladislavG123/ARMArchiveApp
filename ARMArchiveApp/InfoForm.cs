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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoFormLoad(object sender, EventArgs e)
        {

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            new AddArchiveForm().Show();
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ArchiveContext())
                {
                    var archives = context.Archives.ToList();

                    dataGridView.DataSource = archives;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"ERROR: {exception.Message}");
            }
        }

        private void DataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(dataGridView.CurrentCell.ColumnIndex + " " + dataGridView.CurrentCell.RowIndex + " " + dataGridView.CurrentCell.Value.ToString());
            
            switch (dataGridView.CurrentCell.ColumnIndex)
            {
                case 0:
                    MessageBox.Show("Значение ID изменять нельзя!");
                    UpdateButtonClick(null, null);
                    return;
                case 1:
                    using (var context = new ArchiveContext())
                    {
                        // Rack
                        if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int rack)
                            && rack > 0 && rack != (context.Archives.ToList())[dataGridView.CurrentCell.RowIndex].Rack)
                        {
                            context.Archives.ToList()[dataGridView.CurrentCell.RowIndex].Rack = rack;
                            context.SaveChanges();
                        }
                        return;
                    }
                case 2:
                    // Shelf
                    using (var context = new ArchiveContext())
                    {
                        if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int shelf)
                            && shelf > 0 && shelf != (context.Archives.ToList())[dataGridView.CurrentCell.RowIndex].Shelf)
                        {
                            context.Archives.ToList()[dataGridView.CurrentCell.RowIndex].Shelf = shelf;
                            context.SaveChanges();
                        }
                        return;
                    }
                case 3:
                    //Cell
                    using (var context = new ArchiveContext())
                    {
                        if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int cell)
                            && cell > 0 && cell != (context.Archives.ToList())[dataGridView.CurrentCell.RowIndex].Cell)
                        {
                            context.Archives.ToList()[dataGridView.CurrentCell.RowIndex].Cell = cell;
                            context.SaveChanges();
                        }
                        return;
                    }
                case 4:
                    //Fullness
                    using (var context = new ArchiveContext())
                    {
                        if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int fullness)
                            && fullness >= 0 && fullness <= 100 && fullness != (context.Archives.ToList())[dataGridView.CurrentCell.RowIndex].Fullness)
                        {
                            context.Archives.ToList()[dataGridView.CurrentCell.RowIndex].Fullness = fullness;
                            context.SaveChanges();
                        }
                        return;
                    }
            }

        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            using (var context = new ArchiveContext())
            {
                context.Archives.Remove(context.Archives.ToList()[dataGridView.CurrentCell.RowIndex]);
                context.SaveChanges();
            }
        }
    }
}

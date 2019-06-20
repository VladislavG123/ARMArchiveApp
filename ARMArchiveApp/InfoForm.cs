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
        private MenuItems menuItem;

        public InfoForm()
        {
            InitializeComponent();
            menuItem = MenuItems.Archive;
        }

        private void InfoFormLoad(object sender, EventArgs e)
        {

        }

        private void AddButtonClick(object sender, EventArgs e)
        {

            switch (menuItem)
            {
                case MenuItems.Archive:
                    new AddArchiveForm().Show();
                    break;
                case MenuItems.Delivery:
                    new AddDeliveryForm().Show();
                    break;
                case MenuItems.Document:
                    new AddDocumentForm().Show();
                    break;
                case MenuItems.Subscriber:
                    new AddSubscriberForm().Show();
                    break;
            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ArchiveContext())
                {
                    dynamic data;
                    switch (menuItem)
                    {
                        case MenuItems.Archive:
                            data = context.Archives.ToList();
                            dataGridView.DataSource = data as List<Archive>;
                            break;
                        case MenuItems.Delivery:
                            data = context.Deliveries.ToList();
                            dataGridView.DataSource = data as List<Delivery>;
                            break;
                        case MenuItems.Document:
                            data = context.Documents.ToList();
                            dataGridView.DataSource = data as List<Document>;
                            break;
                        case MenuItems.Subscriber:
                            data = context.Subscribers.ToList();
                            dataGridView.DataSource = data as List<Subscriber>;
                            break;
                    }


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
                switch (menuItem)
                {
                    case MenuItems.Archive:
                        context.Archives.Remove(context.Archives.ToList()[dataGridView.CurrentCell.RowIndex]);
                        break;
                    case MenuItems.Delivery:
                        context.Deliveries.Remove(context.Deliveries.ToList()[dataGridView.CurrentCell.RowIndex]);
                        break;
                    case MenuItems.Document:
                        context.Documents.Remove(context.Documents.ToList()[dataGridView.CurrentCell.RowIndex]);
                        break;
                    case MenuItems.Subscriber:
                        context.Subscribers.Remove(context.Subscribers.ToList()[dataGridView.CurrentCell.RowIndex]);
                        break;
                }
                context.SaveChanges();
            }
        }

        private void DocumentsToolStripMenuItemClick(object sender, EventArgs e)
        {
            menuItem = MenuItems.Document;
        }

        private void ArchiveToolStripMenuItemClick(object sender, EventArgs e)
        {
            menuItem = MenuItems.Archive;
        }

        private void DeliveryToolStripMenuItemClick(object sender, EventArgs e)
        {
            menuItem = MenuItems.Delivery;
        }

        private void SubscriberToolStripMenuItemClick(object sender, EventArgs e)
        {
            menuItem = MenuItems.Subscriber;
        }

        private void AboutMeToolStripMenuItemClick(object sender, EventArgs e)
        {
            new AboutMeForm().Show();
        }
    }
}

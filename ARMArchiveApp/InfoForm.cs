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
            UpdateButtonClick(null, null);
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
            UpdateButtonClick(null, null);
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

                            dataGridView.Columns.Clear();
                            dataGridView.Columns.Add("rackColumn", "Стелаж");
                            dataGridView.Columns.Add("shelfColumn", "Полка");
                            dataGridView.Columns.Add("cellColumn", "Ячейка");
                            dataGridView.Columns.Add("fullnessColumn", "Заполненость");
                            foreach (var archive in data as List<Archive>)
                            {
                                dataGridView.Rows.Add(new object[] { archive.Rack, archive.Shelf, archive.Cell, archive.Fullness });
                            }
                            break;
                        case MenuItems.Delivery:
                            data = context.Deliveries.ToList();

                            dataGridView.Columns.Clear();
                            dataGridView.Columns.Add("documentNameColumn", "Документ");
                            dataGridView.Columns.Add("gettingDateColumn", "Дата выдачи");
                            dataGridView.Columns.Add("subscriverNameColumn", "Абонент");
                            foreach (var delivery in data as List<Delivery>)
                            {
                                dataGridView.Rows.Add(new object[] { delivery.Document.Name, delivery.GettingDate.ToString("dd.MM.yyyy"), delivery.Subscriber.FullName });
                            }

                            break;
                        case MenuItems.Document:
                            data = context.Documents.ToList();

                            dataGridView.Columns.Clear();
                            dataGridView.Columns.Add("numberDocumentColumn", "Номер");
                            dataGridView.Columns.Add("documentNameColumn", "Название");
                            dataGridView.Columns.Add("documentThemeColumn", "Тема");
                            dataGridView.Columns.Add("documentCellColumn", "Ячейка");
                            dataGridView.Columns.Add("amountDocumentColumn", "Количество");
                            dataGridView.Columns.Add("resDateColumn", "Дата поступления");
                            foreach (var document in data as List<Document>)
                            {
                                dataGridView.Rows.Add(new object[] { document.Number, document.Name, document.Theme, document.Cell, document.Amount, document.ReceiptDate.ToString("dd.MM.yyyy") });
                            }

                            break;
                        case MenuItems.Subscriber:
                            data = context.Subscribers.ToList();

                            dataGridView.Columns.Clear();
                            dataGridView.Columns.Add("fullNameColumn", "ФИО");
                            dataGridView.Columns.Add("departmentColumn", "Отдел");
                            dataGridView.Columns.Add("phoneColumn", "Номер телефона");
                            foreach (var subscriber in data as List<Subscriber>)
                            {
                                dataGridView.Rows.Add(new object[] { subscriber.FullName, subscriber.Department, subscriber.Phone });
                            }
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
            try
            {
                switch (menuItem)
                {
                    case MenuItems.Archive:
                        switch (dataGridView.CurrentCell.ColumnIndex)
                        {
                            case 0:
                                using (var context = new ArchiveContext())
                                {
                                    // Rack
                                    if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int rack)
                                        && rack > 0 && rack != (context.Archives.ToList())[dataGridView.CurrentCell.RowIndex].Rack)
                                    {
                                        context.Archives.ToList()[dataGridView.CurrentCell.RowIndex].Rack = rack;
                                        context.SaveChanges();
                                    }
                                    break;
                                }
                            case 1:
                                // Shelf
                                using (var context = new ArchiveContext())
                                {
                                    if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int shelf)
                                        && shelf > 0 && shelf != (context.Archives.ToList())[dataGridView.CurrentCell.RowIndex].Shelf)
                                    {
                                        context.Archives.ToList()[dataGridView.CurrentCell.RowIndex].Shelf = shelf;
                                        context.SaveChanges();
                                    }
                                    break;
                                }
                            case 2:
                                //Cell
                                using (var context = new ArchiveContext())
                                {
                                    if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int cell)
                                        && cell > 0 && cell != (context.Archives.ToList())[dataGridView.CurrentCell.RowIndex].Cell)
                                    {
                                        context.Archives.ToList()[dataGridView.CurrentCell.RowIndex].Cell = cell;
                                        context.SaveChanges();
                                    }
                                    break;
                                }
                            case 3:
                                //Fullness
                                using (var context = new ArchiveContext())
                                {
                                    if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int fullness)
                                        && fullness >= 0 && fullness <= 100 && fullness != (context.Archives.ToList())[dataGridView.CurrentCell.RowIndex].Fullness)
                                    {
                                        context.Archives.ToList()[dataGridView.CurrentCell.RowIndex].Fullness = fullness;
                                        context.SaveChanges();
                                    }
                                    break;
                                }
                        }
                        break;
                    case MenuItems.Delivery:
                        switch (dataGridView.CurrentCell.ColumnIndex)
                        {
                            case 0:
                                using (var context = new ArchiveContext())
                                {
                                    context.Deliveries.ToList()[dataGridView.CurrentCell.RowIndex].Document.Name = dataGridView.CurrentCell.Value.ToString();
                                    context.SaveChanges();
                                }
                                break;
                            case 1:
                                using (var context = new ArchiveContext())
                                {
                                    MessageBox.Show("Значение даты выдачи изменять нельзя!");
                                    break;
                                }
                            case 2:
                                using (var context = new ArchiveContext())
                                {
                                    context.Deliveries.ToList()[dataGridView.CurrentCell.RowIndex].Subscriber.FullName = dataGridView.CurrentCell.Value.ToString();
                                    context.SaveChanges();
                                }
                                break;
                        }
                        break;
                    case MenuItems.Document:
                        switch (dataGridView.CurrentCell.ColumnIndex)
                        {
                            case 0:
                                using (var context = new ArchiveContext())
                                {
                                    // Number
                                    if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int number)
                                        && number > 0 && number != (context.Documents.ToList())[dataGridView.CurrentCell.RowIndex].Number)
                                    {
                                        context.Documents.ToList()[dataGridView.CurrentCell.RowIndex].Number = number;
                                        context.SaveChanges();
                                    }
                                    break;
                                }
                            case 1:
                                // Name
                                using (var context = new ArchiveContext())
                                {
                                    context.Documents.ToList()[dataGridView.CurrentCell.RowIndex].Name = dataGridView.CurrentCell.Value.ToString();
                                    context.SaveChanges();
                                }
                                break;
                            case 2:
                                // Theme
                                using (var context = new ArchiveContext())
                                {
                                    context.Documents.ToList()[dataGridView.CurrentCell.RowIndex].Theme = dataGridView.CurrentCell.Value.ToString();
                                    context.SaveChanges();
                                }
                                break;
                            case 3:
                                using (var context = new ArchiveContext())
                                {
                                    // Cell
                                    if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int cell)
                                        && cell > 0 && cell != (context.Documents.ToList())[dataGridView.CurrentCell.RowIndex].Cell)
                                    {
                                        context.Documents.ToList()[dataGridView.CurrentCell.RowIndex].Cell = cell;
                                        context.SaveChanges();
                                    }
                                    break;
                                }
                            case 4:
                                using (var context = new ArchiveContext())
                                {
                                    // Amount
                                    if (int.TryParse(dataGridView.CurrentCell.Value.ToString(), out int amount)
                                        && amount > 0 && amount != (context.Documents.ToList())[dataGridView.CurrentCell.RowIndex].Amount)
                                    {
                                        context.Documents.ToList()[dataGridView.CurrentCell.RowIndex].Amount = amount;
                                        context.SaveChanges();
                                    }
                                    break;
                                }
                            case 5:
                                using (var context = new ArchiveContext())
                                {
                                    MessageBox.Show("Значение даты изменять нельзя!");
                                    UpdateButtonClick(null, null);
                                    break;
                                }
                        }
                        break;
                    case MenuItems.Subscriber:
                        switch (dataGridView.CurrentCell.ColumnIndex)
                        {
                            case 0:
                                // FullName
                                using (var context = new ArchiveContext())
                                {
                                    context.Subscribers.ToList()[dataGridView.CurrentCell.RowIndex].FullName = dataGridView.CurrentCell.Value.ToString();
                                    context.SaveChanges();
                                }
                                break;
                            case 1:
                                // Department
                                using (var context = new ArchiveContext())
                                {
                                    context.Subscribers.ToList()[dataGridView.CurrentCell.RowIndex].Department = dataGridView.CurrentCell.Value.ToString();
                                    context.SaveChanges();
                                }
                                break;
                            case 2:
                                // Phone
                                using (var context = new ArchiveContext())
                                {
                                    context.Subscribers.ToList()[dataGridView.CurrentCell.RowIndex].Phone = dataGridView.CurrentCell.Value.ToString();
                                    context.SaveChanges();
                                }
                                break;

                        }
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка.");
            }

            UpdateButtonClick(null, null);

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
                UpdateButtonClick(null, null);
            }
        }

        private void DocumentsToolStripMenuItemClick(object sender, EventArgs e)
        {
            menuItem = MenuItems.Document;
            UpdateButtonClick(null, null);
        }

        private void ArchiveToolStripMenuItemClick(object sender, EventArgs e)
        {
            menuItem = MenuItems.Archive;
            UpdateButtonClick(null, null);
        }

        private void DeliveryToolStripMenuItemClick(object sender, EventArgs e)
        {
            menuItem = MenuItems.Delivery;
            UpdateButtonClick(null, null);
        }

        private void SubscriberToolStripMenuItemClick(object sender, EventArgs e)
        {
            menuItem = MenuItems.Subscriber;
            UpdateButtonClick(null, null);
        }

        private void AboutMeToolStripMenuItemClick(object sender, EventArgs e)
        {
            new AboutMeForm().Show();
        }

        private void FindEmptyCellButtonClick(object sender, EventArgs e)
        {
            string result = "Пустые ячейки:\r";
            List<int> cells = new List<int>();
            using (var context = new ArchiveContext())
            {
                foreach (var archive in context.Archives.ToList())
                {
                    if (archive.Fullness == 0)
                    {
                        cells.Add(archive.Cell);
                    }
                }
            }
            foreach (var cell in cells)
            {
                result += cell + "\r";
            }
            MessageBox.Show(result);
        }

        private void FindCellButtonClick(object sender, EventArgs e)
        {
            try
            {
                string documentName = documentNameTextBox.Text;
                using (var context = new ArchiveContext())
                {
                    foreach (var document in context.Documents.ToList())
                    {
                        if (document.Name == documentName)
                        {
                            MessageBox.Show($"Документ найден. Он находится в ячейке номер {document.Cell}");
                            return;
                        }
                    }
                    MessageBox.Show("Документ не найден.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка.\r\r" + exception.Message);
            }
        }
    }
}

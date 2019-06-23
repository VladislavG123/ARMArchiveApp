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
    public partial class AddDocumentForm : Form
    {
        public AddDocumentForm()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                Document document = new Document();
                if (int.TryParse(numberTextBox.Text, out int number) && number > 0
                    && nameTextBox.Text.Length > 0
                    && themeTextBox.Text.Length > 0
                    && int.TryParse(cellTextBox.Text, out int cell) && cell > 0
                    && int.TryParse(amountTextBox.Text, out int amount) && amount > 0
                    && DateTime.TryParse(receiptDatePicker.Text, out DateTime receiptDate))
                {
                    using (var context = new ArchiveContext())
                    {
                        bool isCellCreated = false;
                        foreach (var archive in context.Archives)
                        {
                            if (archive.Cell == cell)
                            {
                                isCellCreated = true;
                            }
                        }
                        if (!isCellCreated)
                        {
                            MessageBox.Show("Данной ячейки не существует!");
                            return;
                        }
                        foreach (var item in context.Documents.ToList())
                        {
                            if (item.Number == number)
                            {
                                MessageBox.Show("Данный номер документа уже занят!");
                                return;
                            }
                            if (item.Name == nameTextBox.Text)
                            {
                                MessageBox.Show("Данное имя файла уже занято!");
                                return;
                            }
                            if (item.Cell == cell)
                            {
                                MessageBox.Show("Данная ячейка уже занята!");
                                return;
                            }
                            
                        }
                        
                        document.Number = number;
                        document.Name = nameTextBox.Text;
                        document.Theme = themeTextBox.Text;
                        document.Cell = cell;
                        context.Archives.Where(archive => archive.Cell == cell).ToList()[0].Fullness = amount;
                        document.Amount = amount;
                        document.ReceiptDate = receiptDate;

                        context.Documents.Add(document);
                        context.SaveChanges();
                    }

                    Close();
                    return;
                }
                throw new Exception("Данные введены неверно!");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Возникла ошибка!\r\r" + exception.Message);
            }
        }
    }
}

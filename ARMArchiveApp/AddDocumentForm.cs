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
                    && int.TryParse(cellTextBox.Text, out int cell) && cell > 0
                    && int.TryParse(amountTextBox.Text, out int amount) && amount > 0
                    && DateTime.TryParse(receiptDatePicker.Text, out DateTime receiptDate))
                {
                    using (var context = new ArchiveContext())
                    {
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


                        for (int i = 0; i < themesDataGridView.Columns.Count; i++)
                        {
                            if (themesDataGridView.Columns[i].HeaderText.Length > 0)
                            {
                                document.Themes.Add(themesDataGridView.Rows[i].Cells[0].Value as string);
                            }
                        }

                        document.Number = number;
                        document.Name = nameTextBox.Text;
                        document.Cell = cell;
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

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
    public partial class AddSubscriberForm : Form
    {
        public AddSubscriberForm()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                Subscriber subscriber = new Subscriber();
                if (fullnameTextBox.Text.Length > 0 && departmentTextBox.Text.Length > 0 && phoneTextBox.Text.Length > 0
                    && DateTime.TryParse(gettingDatePicker.Text, out DateTime gettingDateTime))
                {
                    subscriber.Department = departmentTextBox.Text;
                    subscriber.FullName = fullnameTextBox.Text;
                    subscriber.Phone = phoneTextBox.Text;
                    subscriber.GettingDate = gettingDateTime;
                    using (var context = new ArchiveContext())
                    {
                        context.Subscribers.Add(subscriber);
                        context.SaveChanges();
                    }
                    Close();
                    return;
                }
                throw new Exception("Данные введены неверно!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка!\r\r" + exception.Message);
            }
          
        }
    }
}

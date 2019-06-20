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
    public partial class AddDeliveryForm : Form
    {
        private List<Subscriber> _subscribers = new List<Subscriber>();
        public AddDeliveryForm()
        {
            InitializeComponent();
            using (var context = new ArchiveContext())
            {
                foreach (var subscriber in context.Subscribers.ToList())
                {
                    _subscribers.Add(subscriber);
                    subscribersComboBox.Items.Add(subscriber.FullName);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                Delivery delivery = new Delivery();

                if (subscribersComboBox.SelectedItem != null)
                {
                    var result = _subscribers.Where(subscriber => subscriber.FullName == subscribersComboBox.Text).ToList();
                    delivery.Subscriber = result[0];
                    delivery.GettingDate = DateTime.Parse(gettingDateTimePicker.Text);

                    using (var context = new ArchiveContext())
                    {
                        context.Deliveries.Add(delivery);
                        context.SaveChanges();
                    }

                    Close();
                    return;
                }
                throw new Exception("Данные введены неверно!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка.\r\r" + exception.Message);
            }
        }
    }
}

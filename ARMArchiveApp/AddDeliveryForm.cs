﻿using ARMArchiveApp.Models;
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
        private List<Document> _documents = new List<Document>();
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
                foreach (var document in context.Documents.ToList())
                {
                    if (document.Amount > 0)
                    {
                        _documents.Add(document);
                        documentComboBox.Items.Add(document.Name);
                    }
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                Delivery delivery = new Delivery();

                using (var context = new ArchiveContext())
                {
                    if (subscribersComboBox.SelectedItem != null)
                    {
                        foreach (var subscriber in _subscribers)
                        {
                            if (subscriber.FullName == subscribersComboBox.Text)
                            {
                                delivery.Subscriber = context.Subscribers.Where(subs => subs.FullName == subscriber.FullName).ToList()[0];
                            }
                        }

                        foreach (var document in _documents)
                        {
                            if (document.Name == documentComboBox.Text)
                            {
                                delivery.Document = context.Documents.Where(doc => doc.Name == document.Name).ToList()[0];
                            }
                        }

                        delivery.GettingDate = DateTime.Parse(gettingDateTimePicker.Text);


                        // Вычитание из количества документов 
                        int index = -1;
                        foreach (var document in _documents)
                        {
                            if (document.Name == documentComboBox.Name)
                            {
                                break;
                            }
                            index++;
                        }

                        context.Documents.ToList()[index].Amount--;

                        context.Archives.Where(arch => arch.Cell == delivery.Document.Cell).ToList()[0].Fullness = context.Documents.ToList()[index].Amount;


                        context.Deliveries.Add(delivery);
                        context.SaveChanges();
                        Close();
                        return;
                    }

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

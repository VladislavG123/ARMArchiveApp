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
                    _documents.Add(document);
                    documentComboBox.Items.Add(document.Name);
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
                                foreach (var archive in context.Archives)
                                {
                                    if (archive.Cell == document.Cell)
                                    {
                                        // TODO Вычитание заполености в архиве
                                        context.Archives.Where(arch => arch.Cell == archive.Cell).ToList()[0].Fullness = document.Amount - 1;
                                    }
                                }
                                break;
                            }
                            index++;
                        }
                        context.Documents.ToList()[index].Amount--;

                        // Если количество меньше или ровно 0, объект удаляется
                        if (context.Documents.ToList()[index].Amount <= 0)
                        {
                            context.Documents.Remove(context.Documents.ToList()[index]);
                        }
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

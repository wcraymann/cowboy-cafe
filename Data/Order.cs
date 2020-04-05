/*
 * Author: William Raymann
 * Class: Order
 * Purpose: To provide a Order object for the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an Order in the Cowboy Cafe.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Stores the last used order number.
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// Stores the entrees, sides, and drinks in the current order.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Returns the items in the List items as a non-generic IEnumerable.
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// Sums up and returns the price of all the order items combined.
        /// </summary>
        public double Subtotal
        {
            get
            {
                var price = 0.0;

                foreach(IOrderItem item in Items)
                {
                    price += item.Price;
                }

                return price;
            }
        }

        private uint orderNumber;
        /// <summary>
        /// Increments static lastOrderNumber and returns its value.
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return orderNumber;
            }
        }

        /// <summary>
        /// Creates as class that represents and Order in the Cowboy Cafe.
        /// </summary>
        public Order()
        {
            orderNumber = ++lastOrderNumber;
        }

        /// <summary>
        /// Event handler for changes in Order data.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds the passed item to the list of order items and notifies
        /// the MainWindow that Items has changed. It also subscribes to the
        /// PropertyChanged event handler in each item so it can invoke its
        /// own PropertyChanged event handler.
        /// </summary>
        /// <param name="item">The element to be added to Items.</param>
        public void Add(IOrderItem item) 
        {
            double preSubtotal = Subtotal;

            items.Add(item);
            item.PropertyChanged += OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if (!(Math.Abs(Subtotal - preSubtotal) < 0.001))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes the passed item from the list of order items and notifies
        /// the MainWindow that Items has changed. It also unsubscribes from
        /// the PropertyChanged event handler in the removed item.
        /// </summary>
        /// <param name="item">The element to remove from Items.</param>
        public void Remove(IOrderItem item) 
        {
            double preSubtotal = Subtotal;

            items.Remove(item);
            item.PropertyChanged -= OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if (!(Math.Abs(Subtotal - preSubtotal) < 0.001)) 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Invokes the current object's PropertyChanged event handler for 
        /// Items whenever it is called by an event handler from
        /// one of the items in Items. It also invokes the current object's
        /// PropertyChanged event handler if a "Price" property form of the
        /// Items' items is sent in the event args e.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if(e.PropertyName=="Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}

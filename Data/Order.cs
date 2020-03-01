/*
 * Author: William Raymann
 * Class: Order
 * Purpose: To provide a Order object for the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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

        /// <summary>
        /// Increments static lastOrderNumber and returns its value.
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                lastOrderNumber++;
                return lastOrderNumber;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds the passed item to the list of order items and notifies
        /// the MainWindow that Items has changed. It also notifies the MainWindow
        /// if Subtotal has changed as a result of the change in Items.
        /// </summary>
        /// <param name="item">The element to be added to Items.</param>
        public void Add(IOrderItem item) 
        {
            double preSubtotal = Subtotal;

            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if (!(Math.Abs(Subtotal - preSubtotal) < 0.001))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes the passed item from the list of order items and notifies
        /// the MainWindow that Items has changed. It also notifies the MainWindow
        /// if Subtotal has changed as a result of the change in Items.
        /// </summary>
        /// <param name="item">The element to remove from Items.</param>
        public void Remove(IOrderItem item) 
        {
            double preSubtotal = Subtotal;

            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

            if (!(Math.Abs(Subtotal - preSubtotal) < 0.001)) 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}

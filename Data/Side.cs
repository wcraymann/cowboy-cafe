/*
 * Author: Nathan Bean
 * Class: Side
 * Prupose: To be a base class for the sides in the Cowboy Cafe
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Side subclass data.
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the size of the side.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of the side.
        /// </summary>
        public List<string> SpecialInstructions => new List<string>();
    }
}

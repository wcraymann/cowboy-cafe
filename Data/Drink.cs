﻿/*
 * Author: William Raymann.
 * Class: Drink.
 * Purpose: To provide an base class for all drinks in the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class for all drinks at the Cowboy Cafe.
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Drink subclass data.
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// A variable that stores the size of a drink. 
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// An abstract variable that will store the inheriting drink's price.
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// An abstract variable that will store the inheriting drink's calorie count.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A variable that is true if there is ice in the current drink.
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// An abstract variable that will store the inheriting drink's special instructions.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}

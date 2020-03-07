/*
 * Author: William Raymann.
 * Class: BakedBeans.
 * Purpose: To store data for a particular Baked Beans entree in the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Baked Beans entree in the Cowboy Cafe.
    /// </summary>
    public class BakedBeans : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Baked Beans data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Stores the size of the Baked Beans entree.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                if(size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        /// <summary>
        /// Returns the price of a Baked Beans entree based on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Return the calories in a Baked Beans entree based on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Baked Beans" preceded by either "Large", "Medium", or "Small".</returns>
        public override string ToString()
        {
            switch(Size)
            {
                case Size.Large:
                    return "Large Baked Beans";
                case Size.Medium:
                    return "Medium Baked Beans";
                case Size.Small:
                    return "Small Baked Beans";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}

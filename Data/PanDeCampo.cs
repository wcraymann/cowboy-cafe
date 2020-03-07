/*
 * Author: William Raymann.
 * Class: PanDeCampo.
 * Purpose: To store data on a particular Pan de Campo entree in the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Pan de Campo entree in the Cowboy Cafe.
    /// </summary>
    public class PanDeCampo : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Pan De Campo data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Stores the size of the Pen de Campo entree.
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
        /// Returns the price of a Pan de Campo entree based on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
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
        /// Returns the calories of a Pan de Campo entree based on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Pan De Campo" preceded by either "Large", "Medium", or "Small".</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                case Size.Small:
                    return "Small Pan de Campo";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}

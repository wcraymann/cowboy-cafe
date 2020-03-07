/*
 * Author: William Raymann.
 * Class: ChiliCheesFries.
 * Prupose: To store data on a particular Chili Cheese Fries entree in the Cowboy Cafe.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries side.
    /// </summary>
    public class ChiliCheeseFries : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Chili Cheese Fries data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Stores the size of the Chili Cheese Fries entree.
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
        /// Returns the Calories in the Chili Cheese Fries side based on size.
        /// </summary>
        public override uint Calories 
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unkown Size");
                }
            }
        }

        /// <summary>
        /// Returns the Chili Cheese Fries Price based on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unkown Size");
                }
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Chili Cheese Fries" preceded by either "Large", "Medium", or "Small".</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Chili Cheese Fries";
                case Size.Medium:
                    return "Medium Chili Cheese Fries";
                case Size.Small:
                    return "Small Chili Cheese Fries";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}

/*
 * Author: William Raymann.
 * Class: Water.
 * Purpose: To provide a Water object for the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing Water at the Cowboy Cafe.
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Water data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// A variable that stores the price of Water at the Cowboy Cafe.
        /// </summary>
        public override double Price
        {
            get { return 0.12; }
        }

        /// <summary>
        /// A variable that stores the calorie count of Water at the Cowboy Cafe.
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Stores the size of the Water.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                if (size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        private bool ice = true;
        /// <summary>
        /// True if the Water should come with ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool lemon = false;
        /// <summary>
        /// A variable that is true if the Water has a lemon in it.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                if(lemon != value)
                {
                    lemon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Returns the special instructions for the Water at the Cowboy Cafe.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();

                if (!Ice) list.Add("Hold Ice");
                if (Lemon) list.Add("Add Lemon");

                return list;
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Water" preceded by either "Large", "Medium", or "Small".</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Small:
                    return "Small Water";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}

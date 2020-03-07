/*
 * Author: William Raymann.
 * Class: CowboyCoffee.
 * Purpose: To provide a Cowboy Coffee object of the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee in the Cowboy Caffee.
    /// </summary>
    public class CowboyCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Cowboy Coffee data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Returns the price of the Cowboy Coffee based on its size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size) {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException("Unkown Size");
                }
            }
        }

        /// <summary>
        /// Returns the calorie count of the Cowboy Coffee base on its size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// Stores the size of the Cowboy Coffee.
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

        private bool ice = false;
        /// <summary>
        /// True if the Cowboy Coffee should come with ice.
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

        private bool decaf = false;
        /// <summary>
        /// A variable that is true if the Cowboy Coffee is decaf.
        /// </summary>
        public bool Decaf 
        { 
            get { return decaf; }
            set
            {
                if(decaf != value)
                {
                    decaf = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                }
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// Returns true if the Cowboy Coffee has room for cream.
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                if(roomForCream != value)
                {
                    roomForCream = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Returns the special instructions of the Cowboy Coffee base on object data.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();

                if (Ice) list.Add("Add Ice");
                if (RoomForCream) list.Add("Room for Cream");

                return list;
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Cowboy Coffee" preceded by either "Large", "Medium", or "Small" and "Decaf" if
        /// the coffee is decaffeinated.</returns>
        public override string ToString()
        {
            var returnString = "Cowboy Coffee";

            if (Decaf) returnString = returnString.Insert(0, "Decaf ");

            switch (Size)
            {
                case Size.Large:
                    return returnString.Insert(0, "Large ");
                case Size.Medium:
                    return returnString.Insert(0, "Medium ");
                case Size.Small:
                    return returnString.Insert(0, "Small ");
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}

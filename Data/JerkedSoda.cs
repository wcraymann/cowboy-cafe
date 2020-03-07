/*
 * Author: William Raymann.
 * Class: JerkedSoda.
 * Purpose: To provide a Jerked Soda object for the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Jerked Soda in the Cowboy Cafe.
    /// </summary>
    public class JerkedSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in Jerked Soda data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Returns the price of the Jerked Soda based on its size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException("Unkown Size");
                }
            }
        }

        /// <summary>
        /// Returns the calorie count of the Jerked Soda based on its size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException("Unkown Size");
                }
            }
        }

        private SodaFlavor flavor = SodaFlavor.CreamSoda;
        /// <summary>
        /// Stores the flavor of the Jerked Soda.
        /// </summary>
        public SodaFlavor Flavor 
        { 
            get { return flavor; }
            set
            {
                if(flavor != value) {
                    flavor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }
                
            } 
        }

        private Size size = Size.Small;
        /// <summary>
        /// Stores the size of the Jerked Soda.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
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

        private bool ice = true;
        /// <summary>
        /// True if the Jerked Soda should come with ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                if(ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Returns the special instructions for the Jerked Soda based on object data.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var list = new List<string>();

                if (!Ice) list.Add("Hold Ice");

                return list;
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Jerked Soda" preceded by either "Large", "Medium", or "Small"
        /// and either "Cream", "Orange", "Sarsaparilla", "Birch Beer", or "Root Beer".</returns>
        public override string ToString()
        {
            var returnString = "Jerked Soda";

            // Add the soda flavor.
            switch(Flavor)
            {
                case SodaFlavor.CreamSoda:
                    returnString = returnString.Insert(0, "Cream Soda ");
                    break;
                case SodaFlavor.OrangeSoda:
                    returnString = returnString.Insert(0, "Orange Soda ");
                    break;
                case SodaFlavor.Sarsaparilla:
                    returnString = returnString.Insert(0, "Sarsaparilla ");
                    break;
                case SodaFlavor.BirchBeer:
                    returnString = returnString.Insert(0, "Birch Beer ");
                    break;
                case SodaFlavor.RootBeer:
                    returnString = returnString.Insert(0, "Root Beer ");
                    break;
                default:
                    throw new NotImplementedException("Unknown Soda Flavor");
            }

            // Add the soda size and return the string.
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

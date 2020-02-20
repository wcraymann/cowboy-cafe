/*
 * Author: William Raymann.
 * Class: JerkedSoda.
 * Purpose: To provide a Jerked Soda object for the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Jerked Soda in the Cowboy Cafe.
    /// </summary>
    public class JerkedSoda : Drink
    {
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

        /// <summary>
        /// Stores the flavor of the Jerked Soda.
        /// </summary>
        public SodaFlavor Flavor { get; set; }

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
                    returnString = returnString.Insert(0, "Cream ");
                    break;
                case SodaFlavor.OrangeSoda:
                    returnString = returnString.Insert(0, "Orange ");
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

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
    }
}

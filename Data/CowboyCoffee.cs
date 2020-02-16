/*
 * Author: William Raymann.
 * Class: CowboyCoffee.
 * Purpose: To provide a Cowboy Coffee object of the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee in the Cowboy Caffee.
    /// </summary>
    public class CowboyCoffee : Drink
    {
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

        /// <summary>
        /// A variable that is true if the Cowboy Coffee is decaf.
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Returns true if the Cowboy Coffee has room for cream.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

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
        /// Constructor to ensure that the 'Ice' property is set to false by default.
        /// </summary>
        public CowboyCoffee()
        {
            Ice = false;
        }
    }
}

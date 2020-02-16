/*
 * Author: William Raymann.
 * Class: Water.
 * Purpose: To provide a Water object for the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing Water at the Cowboy Cafe.
    /// </summary>
    public class Water : Drink
    {
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

        /// <summary>
        /// A variable that is true if the Water has a lemon in it.
        /// </summary>
        public bool Lemon { get; set; } = false;

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
    }
}

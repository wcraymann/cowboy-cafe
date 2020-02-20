/*
 * Author: William Raymann.
 * Class: PecosPulledPork.
 * Prupose: To store data on a particular Pecos Pulled Pork entree in the Cowboy Cafe.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// Stores price for Pecos Pulled Pork.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Stores calorie count for Pecos Pulled Pork.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// True if bread is included in Pecos Pulled Pork.
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// True if pickles are included in Pecos Pulled Pork.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Stores any special instructions for Pecos Pulled Pork.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var specialInstructions = new List<string>();

                if (!Bread) specialInstructions.Add("hold bread");
                if (!Pickle) specialInstructions.Add("hold pickle");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Pecos Pulled Pork".</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}

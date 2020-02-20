/*
 * Author: William Raymann.
 * Class: RustlersRibs.
 * Prupose: To store data on a particular Rustler's Ribs entree in the Cowboy Cafe.
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree.
    /// </summary>
    public class RustlersRibs : Entree
    {

        /// <summary>
        /// The price of Rustler's Ribs.
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of Rustler's Ribs.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Stores special instructions for Rustler's Ribs.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// Converts object to string.
        /// </summary>
        /// <returns>The string "Rustler's Ribs".</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
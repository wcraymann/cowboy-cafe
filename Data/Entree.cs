﻿/* 
 * Author: William Raymann.
 * Class: Entree.
 * Purpose: To serve as a base class for all entrees in the Cowboy Cafe.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree in the Cowboy Cafe.
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Returns the price of an entree.
        /// </summary>
        public virtual double Price { get; }

        /// <summary>
        /// Returns the calories of an entree.
        /// </summary>
        public virtual uint Calories { get; }

        /// <summary>
        /// Returns the special instructions of an entree.
        /// </summary>
        public virtual List<string> SpecialInstructions { get; }
    }
}

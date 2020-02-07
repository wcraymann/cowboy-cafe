/*
 * Author: William Raymann.
 * Class: BakedBeans.
 * Purpose: To store data for a particular Baked Beans entree in the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Baked Beans entree in the Cowboy Cafe.
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// Stores the size of the Baked Beans entree.
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Returns the price of a Baked Beans entree based on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Return the calories in a Baked Beans entree based on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
    }
}

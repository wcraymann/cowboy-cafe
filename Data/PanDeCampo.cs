/*
 * Author: William Raymann.
 * Class: PanDeCampo.
 * Purpose: To store data on a particular Pan de Campo entree in the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Pan de Campo entree in the Cowboy Cafe.
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// Stores the size of the Pen de Campo entree.
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Returns the price of a Pan de Campo entree based on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
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
        /// Returns the calories of a Pan de Campo entree based on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
    }
}

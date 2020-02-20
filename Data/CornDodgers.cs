/*
 * Author: William Raymann.
 * Class: CornDodgers.
 * Prupose: To store data on a particular Corn Dodgers in the Cowboy Cafe.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Corn Dodgers entree in the Cowboy Cafe.
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// Stores the size of the Corn Dodgers entree.
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Returns the price of a Corn Dodgers entree based on size.
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
                        throw new NotImplementedException("Unkown Size");
                }
            }
        }

        /// <summary>
        /// Returns the calories of a Corn Dodgers entree based on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unkown Size");
                }
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Corn Dodgers" preceded by either "Large", "Medium", or "Small".</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Corn Dodgers";
                case Size.Medium:
                    return "Medium Corn Dodgers";
                case Size.Small:
                    return "Small Corn Dodgers";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}

/*
 * Author: William Raymann.
 * Class: TexasTea.
 * Purpose: To provide a object for the Texas Tea in the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the Texas Tea in the Cowboy Cafe.
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// Returns the price of the Texas Tea based on its size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Returns the calorie count of the Texas Tea based on its size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (Sweet) return 10;
                        return 5;
                    case Size.Medium:
                        if (Sweet) return 22;
                        return 11;
                    case Size.Large:
                        if (Sweet) return 36;
                        return 18;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// A variable that is true if the Texas Tea is has sweetner in it.
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// A variable that is true if the Texas Tea has a lemon in it.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Returns the special instructions of the Texas Tea based on object data.
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

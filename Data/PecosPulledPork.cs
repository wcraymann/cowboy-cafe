using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {
        /// <summary>
        /// Stores price for Pecos Pulled Pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Stores calorie count for Pecos Pulled Pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// True if bread is included in Pecos Pulled Pork
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// True if pickles are included in Pecos Pulled Pork 
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Stores any special instructions for Pecos Pulled Pork
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var specialInstructions = new List<string>();

                if (!Bread) specialInstructions.Add("hold bread");
                if (!Pickle) specialInstructions.Add("hold pickle");

                return specialInstructions;
            }
        }
    }
}

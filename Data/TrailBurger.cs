using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trailburger entree
    /// </summary>
    public class TrailBurger
    {
        /// <summary>
        /// Stores the price of the Trailburger
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// Stores the calorie count of the Trailburger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// True if a bun is included in the Trailburger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// True if ketchup is included in the Trailburger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// True if mustard is included in the Trailburger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// True if pickles are included in the Trailburger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// True if cheese is included in the Trailburger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Stores special instructions for the Trailburger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var specialInstructions = new List<string>();

                if (!Bun) specialInstructions.Add("hold bun");
                if (!Ketchup) specialInstructions.Add("hold ketchup");
                if (!Mustard) specialInstructions.Add("hold mustard");
                if (!Pickle) specialInstructions.Add("hold pickle");
                if (!Cheese) specialInstructions.Add("hold cheese");

                return specialInstructions;
            }
        }
    }
}

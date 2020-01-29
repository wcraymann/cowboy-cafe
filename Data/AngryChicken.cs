using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the angry chicken entree
    /// </summary>
    public class AngryChicken
    {
        private bool bread = true;
        /// <summary>
        /// True if the AngryChicken is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// True if the AngryChicken is served with pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        ///  Stores the price in the AngryChicken
        /// </summary>
        public double Price
        {
            get { return 5.99; }
        }

        /// <summary>
        /// Stores the calories in the AngryChicken
        /// </summary>
        public uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// Stores the special instructions for the AngryChicken
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if(!Bread) instructions.Add("hold bread");
                if(!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}

﻿/*
 * Author: William Raymann.
 * Class: AngryChicken.
 * Prupose: To store data on a particular Angry Chicken entree in the Cowboy Cafe.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an angry chicken entree.
    /// </summary>
    public class AngryChicken : Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the AngryChicken is served with bread.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// If the angry chicken is served with a pickle.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// The price of the angry chicken.
        /// </summary>
        public override double Price
        {
            get { return 5.99; }
        }

        /// <summary>
        /// The calories of the angry chicken.
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// The special instructions for preparing the angry chicken.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if(!bread) instructions.Add("hold bread");
                if(!Pickle) instructions.Add("hold pickle"); 

                return instructions;
            }
        }
    }
}

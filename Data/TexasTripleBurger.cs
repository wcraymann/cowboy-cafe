﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger
    {
        /// <summary>
        /// Stores the price of the Texas Triple Burger
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// Stores the calorie count of the Texas Triple Burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// True if a bun is included in the Texas Triple Burger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// True if ketchup is included in the Texas Triple Burger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// True if mustard is included in the Texas Triple Burger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// True if pickles are included in the Texas Triple Burger
        /// </summary>
        public bool Pickel { get; set; } = true;

        /// <summary>
        /// True if cheese is included in the Texas Triple Burger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// True if tomatos are included in the Texas Triple Burger
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// True if lettus is included in the Texas Triple Burger
        /// </summary>
        public bool Lettus { get; set; } = true;

        /// <summary>
        /// True if mayo is included in the Texas Triple Burger
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// True if bacon is included in the Texas Triple Burger
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// True if eggs are included in the Texas Triple Burger
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Stores special instructions for the Texas Triple Burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var specialInstructions = new List<string>();

                if (!Bun) specialInstructions.Add("hold bun");
                if (!Ketchup) specialInstructions.Add("hold ketchup");
                if (!Mustard) specialInstructions.Add("hold mustard");
                if (!Pickel) specialInstructions.Add("hold pickel");
                if (!Cheese) specialInstructions.Add("hold cheese");
                if (!Tomato) specialInstructions.Add("hold tomato");
                if (!Lettus) specialInstructions.Add("hold lettus");
                if (!Mayo) specialInstructions.Add("hold mayo");
                if (!Bacon) specialInstructions.Add("hold bacon");
                if (!Egg) specialInstructions.Add("hold egg");

                return specialInstructions;
            }
        }
    }
}
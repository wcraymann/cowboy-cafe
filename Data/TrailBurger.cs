/*
 * Author: William Raymann.
 * Class: TrailBurger.
 * Prupose: To store data on a particular Trail Burger entree in the Cowboy Cafe.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trailburger entree.
    /// </summary>
    public class TrailBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Trail Burger data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores the price of the Trailburger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// Stores the calorie count of the Trailburger.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        private bool bun = true;
        /// <summary>
        /// True if a bun is included in the Trail Burger.
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                if (bun != value)
                {
                    bun = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// True if ketchup is included in the Trail Burger.
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                if (ketchup != value)
                {
                    ketchup = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool mustard = true;
        /// <summary>
        /// True if mustard is included in the Trail Burger.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                if (mustard != value)
                {
                    mustard = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool pickle = true;
        /// <summary>
        /// True if pickles are included in the Trail Burger.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                if (pickle != value)
                {
                    pickle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }

        }

        private bool cheese = true;
        /// <summary>
        /// True if cheese is included in the Trail Burger.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if (cheese != value)
                {
                    cheese = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Stores special instructions for the Trail Burger.
        /// </summary>
        public override List<string> SpecialInstructions
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

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Trail Burger".</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}

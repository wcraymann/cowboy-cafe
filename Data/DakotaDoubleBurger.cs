/*
 * Author: William Raymann.
 * Class: DakotaDoubleBurber.
 * Prupose: To store data on a particular Dakota Double Burger entree in the Cowboy Cafe.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a Dakota Double Burger entree.
    /// </summary>
    public class DakotaDoubleBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Dakota Double Burger data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores the price of the Dakota Double Burger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// Stores the calorie count of the Dakota Double Burger.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        private bool bun = true;
        /// <summary>
        /// True if a bun is included in the Dakota Double Burger.
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                if(bun != value)
                {
                    bun = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// True if ketchup is included in the Dakota Double Burger.
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                if(ketchup != value)
                {
                    ketchup = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool mustard = true;
        /// <summary>
        /// True if mustard is included in the Dakota Double Burger.
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                if(mustard != value)
                {
                    mustard = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool pickle = true;
        /// <summary>
        /// True if pickles are included in the Dakota Double Burger.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                if(pickle != value)
                {
                    pickle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }

        }

        private bool cheese = true;
        /// <summary>
        /// True if cheese is included in the Dakota Double Burger.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if(cheese != value)
                {
                    cheese = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool tomato = true;
        /// <summary>
        /// True if tomatos are included in the Dakota Double Burger.
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                if(tomato != value)
                {
                    tomato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// True if lettuce is included in the Dakota Double Burger.
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                if(lettuce != value)
                {
                    lettuce = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool mayo = true;
        /// <summary>
        /// True if mayo is included in the Dakota Double Burger.
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                if(mayo != value)
                {
                    mayo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Stores special instructions for the Dakota Double Burger.
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
                if (!Tomato) specialInstructions.Add("hold tomato");
                if (!Lettuce) specialInstructions.Add("hold lettuce");
                if (!Mayo) specialInstructions.Add("hold mayo");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Dakota Double Burger".</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}

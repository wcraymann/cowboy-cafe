/*
 * Author: William Raymann.
 * Class: PecosPulledPork.
 * Prupose: To store data on a particular Pecos Pulled Pork entree in the Cowboy Cafe.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Pecos Pulled Pork data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores price for Pecos Pulled Pork.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Stores calorie count for Pecos Pulled Pork.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        private bool bread = true;
        /// <summary>
        /// True if bread is included in Pecos Pulled Pork.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                if(bread != value)
                {
                    bread = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool pickle = true;
        /// <summary>
        /// True if pickles are included in Pecos Pulled Pork.
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

        /// <summary>
        /// Stores any special instructions for Pecos Pulled Pork.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var specialInstructions = new List<string>();

                if (!Bread) specialInstructions.Add("hold bread");
                if (!Pickle) specialInstructions.Add("hold pickle");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Pecos Pulled Pork".</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}

/*
 * Author: William Raymann.
 * Class: AngryChicken.
 * Prupose: To store data on a particular Angry Chicken entree in the Cowboy Cafe.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an angry chicken entree.
    /// </summary>
    public class AngryChicken : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Angry Chicken data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        private bool bread = true;
        /// <summary>
        /// If the AngryChicken is served with bread.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set {
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
        /// If the angry chicken is served with a pickle.
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

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "AngryChicken".</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}

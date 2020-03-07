/*
 * Author: William Raymann.
 * Class: TexasTea.
 * Purpose: To provide a object for the Texas Tea in the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the Texas Tea in the Cowboy Cafe.
    /// </summary>
    public class TexasTea : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in Texas Tea data.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

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

        private Size size = Size.Small;
        /// <summary>
        /// Stores the size of the Texas Tea.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                if (size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        private bool ice = true;
        /// <summary>
        /// True if the Texas Tea should come with ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        private bool sweet = true;
        /// <summary>
        /// A variable that is true if the Texas Tea is has sweetner in it.
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                if(sweet != value)
                {
                    sweet = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecilaInstructions"));
                }
            }
        }

        private bool lemon = false;
        /// <summary>
        /// A variable that is true if the Texas Tea has a lemon in it.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                if(lemon != value)
                {
                    lemon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

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

        /// <summary>
        /// Converts the object to a string.
        /// </summary>
        /// <returns>The string "Texas Tea" preceded by either "Large", "Medium", or "Small".</returns>
        public override string ToString()
        {
            var returnString = "Tea";

            if (Sweet) returnString = returnString.Insert(0, "Sweet ");
            else returnString = returnString.Insert(0, "Plain ");

            switch (Size)
            {
                case Size.Large:
                    return returnString.Insert(0, "Large Texas ");
                case Size.Medium:
                    return returnString.Insert(0, "Medium Texas ");
                case Size.Small:
                    return returnString.Insert(0, "Small Texas ");
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}

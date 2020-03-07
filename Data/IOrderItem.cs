/*
 * Author: William Raymann
 * Class: IOrderItem
 * Purpose: To provide an interface for all entrees, sides, and drinks in the Cowboy Cafe.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface for all the entrees, sides, and drinks in the Cowboy Cafe.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// All entrees, sides, and drinks must have a price.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// All entrees, sides, and drinks must have special instructions.
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}

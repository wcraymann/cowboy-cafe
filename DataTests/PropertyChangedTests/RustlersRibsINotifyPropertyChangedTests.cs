/*
 * Author: William Raymann.
 * Class: RustlersRibsINotifyPropertyChangedTests.
 * Purpose: To test whether the RustlersRibs class properly implements
 *          the INotifyPropertyChanged interface.
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    /// <summary>
    /// Tests to determine whether the RustlersRibs class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class RustlersRibsINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether RustlersRibs implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void RustlersRibsShouldImplementINotifyPropertyChanged()
        {
            var rustlersRibs = new RustlersRibs();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(rustlersRibs);
        }
    }
}

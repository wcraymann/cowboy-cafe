/*
 * Author: William Raymann.
 * Class: PecosPulledPorkINotifyPropertyChangedTests.
 * Purpose: To test whether the PecosPulledPork class properly implements
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
    /// Tests to determine whether the PecosPulledPork class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class PecosPulledPorkINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether the PecosPulledPork implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var pecosPulledPork = new PecosPulledPork();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(pecosPulledPork);
        }

        /// <summary>
        /// Tests if the PecosPulledPork class invokes INotifyPropertyChanged
        /// for the "Bread" property when the "Bread" property is changed.
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var pecosPulledPork = new PecosPulledPork();

            Assert.PropertyChanged(pecosPulledPork, "Bread", () =>
            {
                pecosPulledPork.Bread = false;
            });
        }

        /// <summary>
        /// Tests if the PecosPulledPork class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Bread" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecosPulledPork = new PecosPulledPork();

            Assert.PropertyChanged(pecosPulledPork, "SpecialInstructions", () =>
            {
                pecosPulledPork.Bread = false;
            });
        }

        /// <summary>
        /// Tests if the PecosPulledPork class invokes INotifyPropertyChanged
        /// for the "Pickle" property when the "Pickle" property changed
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedEventForPickle()
        {
            var pecosPulledPork = new PecosPulledPork();

            Assert.PropertyChanged(pecosPulledPork, "Pickle", () =>
            {
                pecosPulledPork.Pickle = false;
            });
        }

        /// <summary>
        /// Test if the PecosPulledPork class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property is the "Pickle" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecosPulledPork = new PecosPulledPork();

            Assert.PropertyChanged(pecosPulledPork, "SpecialInstructions", () =>
            {
                pecosPulledPork.Pickle = false;
            });
        }
    }
}

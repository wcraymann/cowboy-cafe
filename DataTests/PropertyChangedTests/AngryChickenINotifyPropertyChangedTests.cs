/*
 * Author: William Raymann.
 * Class: AngryChickenINotifyPropertyChangedTest.
 * Purpose: To test whether the AngryChicken class is properly implementing
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
    /// Tests to determine whether the AngryChicken class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class AngryChickenINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether AngryChicken implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var angryChicken = new AngryChicken();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(angryChicken);
        }

        /// <summary>
        /// Tests if AngryChicken class invokes INotifyPropertyChanged
        /// for the "Bread" property when the "Bread" property is changed.
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var angryChicken = new AngryChicken();

            Assert.PropertyChanged(angryChicken, "Bread", () =>
            {
                angryChicken.Bread = false;
            });
        }

        /// <summary>
        /// Tests if AngryChicken class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Bread" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var angryChicken = new AngryChicken();

            Assert.PropertyChanged(angryChicken, "SpecialInstructions", () =>
            {
                angryChicken.Bread = false;
            });
        }

        /// <summary>
        /// Tests if AngryChicken class invokes INotifyPropertyChanged
        /// for the "Pickle" property when the "Pickle" property changed
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedEventForPickle()
        {
            var angryChicken = new AngryChicken();

            Assert.PropertyChanged(angryChicken, "Pickle", () =>
            {
                angryChicken.Pickle = false;
            });
        }

        /// <summary>
        /// Test if AngryChicken class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property is the "Pickle" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var angryChicken = new AngryChicken();

            Assert.PropertyChanged(angryChicken, "SpecialInstructions", () =>
            {
                angryChicken.Pickle = false;
            });
        }
    }
}

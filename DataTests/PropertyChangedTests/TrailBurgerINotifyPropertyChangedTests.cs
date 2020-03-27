/*
 * Author: William Raymann.
 * Class: TrailBurgerINotifyPropertyChangedTests.
 * Purpose: To test whether the TrailBurger class properly implements
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
    /// Tests to determine whether the TrailBurger class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class TrailBurgerINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether TrailBurger implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var trailBurger = new TrailBurger();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(trailBurger);
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "Bun" property when the "Bun" property is changed.
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "Bun", () =>
            {
                trailBurger.Bun = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Bun" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () =>
            {
                trailBurger.Bun = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "Ketchup" property when the "Ketchup" property is changed.
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "Ketchup", () =>
            {
                trailBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Ketchup" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () =>
            {
                trailBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "Mustard" property when the "Mustard" property is changed.
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "Mustard", () =>
            {
                trailBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Mustard" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () =>
            {
                trailBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "Pickle" property when the "Pickle" property is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "Pickle", () =>
            {
                trailBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Pickle" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () =>
            {
                trailBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "Cheese" property when the "Cheese" property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "Cheese", () =>
            {
                trailBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if TrailBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Cheese" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();

            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () =>
            {
                trailBurger.Cheese = false;
            });
        }
    }
}

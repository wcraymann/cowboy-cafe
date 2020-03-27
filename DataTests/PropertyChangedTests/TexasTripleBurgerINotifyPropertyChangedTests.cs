/*
 * Author: William Raymann.
 * Class: TexasTripleBurgerINotifyPropertyChangedTests.
 * Purpose: To test whether the TexasTripleBurger class properly implements
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
    /// Tests to determine whether the TexasTripleBurger class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class TexasTripleBurgerINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether TexasTripleBurger implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTripleBurger);
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Bun" property when the "Bun" property is changed.
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Bun", () =>
            {
                texasTripleBurger.Bun = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Bun" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Bun = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Ketchup" property when the "Ketchup" property is changed.
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Ketchup", () =>
            {
                texasTripleBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Ketchup" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Mustard" property when the "Mustard" property is changed.
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Mustard", () =>
            {
                texasTripleBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Mustard" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Pickle" property when the "Pickle" property is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Pickle", () =>
            {
                texasTripleBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Pickle" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Cheese" property when the "Cheese" property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Cheese", () =>
            {
                texasTripleBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Cheese" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Tomato" property when the "Tomato" property is changed.
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Tomato", () =>
            {
                texasTripleBurger.Tomato = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Tomato" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Tomato = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Lettuce" property when the "Lettuce" property is changed.
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Lettuce", () =>
            {
                texasTripleBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Lettuce" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Mayo" property when the "Mayo" property is changed.
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Mayo", () =>
            {
                texasTripleBurger.Mayo = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Mayo" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Mayo = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Bacon" property when the "Bacon" property is changed.
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Bacon", () =>
            {
                texasTripleBurger.Bacon = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Bacon" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Bacon = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "Egg" property when the "Egg" property is changed.
        /// </summary>
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "Egg", () =>
            {
                texasTripleBurger.Egg = false;
            });
        }

        /// <summary>
        /// Tests if TexasTripleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Egg" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();

            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () =>
            {
                texasTripleBurger.Egg = false;
            });
        }
    }
}

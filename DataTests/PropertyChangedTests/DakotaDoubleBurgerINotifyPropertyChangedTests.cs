/*
 * Author: William Raymann.
 * Class: DakotaDoubleBurgerINotifyPropertyChangedTests.
 * Purpose: To tests whether the DakotaDoubleBurger class properly implements
 *          the INotifyPropertyChangedInterface.
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
    /// Tests to determine whether the DakotaDoubleBurger class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class DakotaDoubleBurgerINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether DakotaDoubleBurger implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakotaDoubleBurger);
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "Bun" property when the "Bun" property is changed.
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "Bun", () =>
            {
                dakotaDoubleBurger.Bun = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Bun" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () =>
            {
                dakotaDoubleBurger.Bun = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "Ketchup" property when the "Ketchup" property is changed.
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "Ketchup", () =>
            {
                dakotaDoubleBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Ketchup" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () =>
            {
                dakotaDoubleBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "Mustard" property when the "Mustard" property is changed.
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "Mustard", () =>
            {
                dakotaDoubleBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Mustard" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () =>
            {
                dakotaDoubleBurger.Mustard = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "Pickle" property when the "Pickle" property is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "Pickle", () =>
            {
                dakotaDoubleBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Pickle" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () =>
            {
                dakotaDoubleBurger.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "Cheese" property when the "Cheese" property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "Cheese", () =>
            {
                dakotaDoubleBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Cheese" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () =>
            {
                dakotaDoubleBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "Tomato" property when the "Tomato" property is changed.
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "Tomato", () =>
            {
                dakotaDoubleBurger.Tomato = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Tomato" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () =>
            {
                dakotaDoubleBurger.Tomato = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "Lettuce" property when the "Lettuce" property is changed.
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "Lettuce", () =>
            {
                dakotaDoubleBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Lettuce" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () =>
            {
                dakotaDoubleBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "Mayo" property when the "Mayo" property is changed.
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "Mayo", () =>
            {
                dakotaDoubleBurger.Mayo = false;
            });
        }

        /// <summary>
        /// Tests if DakotaDoubleBurger class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Mayo" property
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();

            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () =>
            {
                dakotaDoubleBurger.Mayo = false;
            });
        }
    }
}

/*
 * Author: William Raymann.
 * Class: CowboyCoffeeINotifyPropertyChangedTests.
 * Purpose: To test whether the CowboyCoffee class properly implements
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
    /// Tests to determine whether the CowboyCoffee class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class CowboyCoffeeINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether CowboyCoffee implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var cowboyCoffee = new CowboyCoffee();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowboyCoffee);
        }

        /// <summary>
        /// Tests whether the CowboyCoffee class invokes INotifyPropertyChanged
        /// for the "Size" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize(Size size)
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Size", () =>
            {
                cowboyCoffee.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the CowboyCoffee class invokes INotifyPropertyChanged
        /// for the "Price" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice(Size size)
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Price", () =>
            {
                cowboyCoffee.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the CowboyCoffee class invokes INotifyPropertyChanged
        /// for the "Calories" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories(Size size)
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Calories", () =>
            {
                cowboyCoffee.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the CowboyCoffee class invokes INotifyPropertyChanged
        /// for the "Ice" property when the "Ice" property is changed.
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForIce()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Ice", () =>
            {
                cowboyCoffee.Ice = true;
            });
        }

        /// <summary>
        /// Tests whether the CowboyCoffee class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Ice" property is changed.
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () =>
            {
                cowboyCoffee.Ice = true;
            });
        }

        /// <summary>
        /// Tests whether the CowboyCoffee class invokes INotifyPropertyChanged
        /// for the "Decaf" property when the "Decaf" property is changed.
        /// </summary>
        [Fact]
        public void ChangingDecafShouldInvokeINotifyPropertyChangedForDecaf()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Decaf", () =>
            {
                cowboyCoffee.Decaf = true;
            });
        }

        /// <summary>
        /// Tests whether the CowboyCoffee class invokes INotifyPropertyChanged
        /// for the "RoomForCream" property when the "RoomForCream" property is changed.
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamShouldInvokeINotifyPropertyChangedForRoomForCream()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "RoomForCream", () =>
            {
                cowboyCoffee.RoomForCream = true;
            });
        }

        /// <summary>
        /// Tests whether the CowboyCoffee class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "RoomForCream" property 
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () =>
            {
                cowboyCoffee.RoomForCream = true;
            });
        }
    }
}

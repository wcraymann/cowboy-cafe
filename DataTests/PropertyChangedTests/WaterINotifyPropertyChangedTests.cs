/*
 * Author: William Raymann.
 * Class: WaterINotifyPropertyChangedTests.
 * Purpose: To test whether the Water class properly implements
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
    /// Tests to determine whether the Water class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class WaterINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether Water implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var water = new Water();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        /// <summary>
        /// Tests whether the Water class invokes INotifyPropertyChanged
        /// for the "Size" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize(Size size)
        {
            var water = new Water();

            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the Water class invokes INotifyPropertyChanged
        /// for the "Price" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice(Size size)
        {
            var water = new Water();

            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the Water class invokes INotifyPropertyChanged
        /// for the "Calories" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories(Size size)
        {
            var water = new Water();

            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the Water class invokes INotifyPropertyChanged
        /// for the "Ice" property when the "Ice" property is changed.
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForIce()
        {
            var water = new Water();

            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Tests whether the JerkedSoda class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Ice" property is changed.
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var water = new Water();

            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Tests whether the Water class invokes INotifyPropertyChanged
        /// for the "Lemon" property when the "Lemon" property is changed.
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokeINotifyPropertyChangedForLemon()
        {
            var water = new Water();

            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;
            });
        }

        /// <summary>
        /// Tests whether the JerkedSoda class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Lemon" property is changed.
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var water = new Water();

            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }
    }
}

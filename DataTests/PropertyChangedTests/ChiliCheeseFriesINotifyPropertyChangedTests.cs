/*
 * Author: William Raymann.
 * Class: ChiliCheeseFriesINotifyPropertyChangedTests.
 * Purpose: To test whether the ChiliCheeseFries class properly implements
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
    /// Tests to determine whether the ChiliCheeseFries class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class ChiliCheeseFriesINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether ChiliCheeseFries implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var chiliCheeseFries = new ChiliCheeseFries();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(chiliCheeseFries);
        }

        /// <summary>
        /// Tests whether the ChiliCheeseFries class invokes INotifyPropertyChanged
        /// for the "Size" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize(Size size)
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheeseFries, "Size", () =>
            {
                chiliCheeseFries.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the ChiliCheeseFries class invokes INotifyPropertyChanged
        /// for the "Price" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice(Size size)
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheeseFries, "Price", () =>
            {
                chiliCheeseFries.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the ChiliCheeseFries class invokes INotifyPropertyChanged
        /// for the "Calories" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories(Size size)
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheeseFries, "Calories", () =>
            {
                chiliCheeseFries.Size = size;
            });
        }
    }
}

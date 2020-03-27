/*
 * Author: William Raymann.
 * Class: BakedBeansINotifyPropertyChangedTest.
 * Purpose: To test whether the BakedBeans class properly implements
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
    /// Tests to determine whether the BakedBeans class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class BakedBeansINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether BakedBeans implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var bakedBeans = new BakedBeans();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(bakedBeans);
        }
        /// <summary>
        /// Tests whether the BakedBeans class invokes INotifyPropertyChanged
        /// for the "Size" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize(Size size)
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Size", () =>
            {
                bakedBeans.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the BakedBeans class invokes INotifyPropertyChanged
        /// for the "Price" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice(Size size)
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Price", () =>
            {
                bakedBeans.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the BakedBeans class invokes INotifyPropertyChanged
        /// for the "Calories" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories(Size size)
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Calories", () =>
            {
                bakedBeans.Size = size;
            });
        }
    }
}

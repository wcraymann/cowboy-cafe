/*
 * Author: William Raymann.
 * Class: CornDodgersINotifyPropertyChangedTests
 * Purpose: To test whether the CornDodgers class properly implements
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
    /// Tests to determine whether the CornDodgers class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class CornDodgersINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether CornDodgers implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var cornDodgers = new CornDodgers();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(cornDodgers);
        }

        /// <summary>
        /// Tests whether the CornDodgers class invokes INotifyPropertyChanged
        /// for the "Size" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize(Size size)
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Size", () =>
            {
                cornDodgers.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the CornDodgers class invokes INotifyPropertyChanged
        /// for the "Price" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice(Size size)
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Price", () =>
            {
                cornDodgers.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the CornDodgers class invokes INotifyPropertyChanged
        /// for the "Calories" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories(Size size)
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Calories", () =>
            {
                cornDodgers.Size = size;
            });
        }
    }
}

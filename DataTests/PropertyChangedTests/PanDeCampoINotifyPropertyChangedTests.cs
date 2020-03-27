/*
 * Author: William Raymann.
 * Class: PanDeCampoINotifyPropertyChangedTests.
 * Purpose: To test whether the PanDeCampo class properly implements
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
    /// Tests to determine whether the PanDeCampo class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class PanDeCampoINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether PanDeCampo implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var panDeCampo = new PanDeCampo();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(panDeCampo);
        }
        /// <summary>
        /// Tests whether the PanDeCampo class invokes INotifyPropertyChanged
        /// for the "Size" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize(Size size)
        {
            var panDeCampo = new PanDeCampo();

            Assert.PropertyChanged(panDeCampo, "Size", () =>
            {
                panDeCampo.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the PanDeCampo class invokes INotifyPropertyChanged
        /// for the "Price" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice(Size size)
        {
            var panDeCampo = new PanDeCampo();

            Assert.PropertyChanged(panDeCampo, "Price", () =>
            {
                panDeCampo.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the PanDeCampo class invokes INotifyPropertyChanged
        /// for the "Calories" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories(Size size)
        {
            var panDeCampo = new PanDeCampo();

            Assert.PropertyChanged(panDeCampo, "Calories", () =>
            {
                panDeCampo.Size = size;
            });
        }
    }
}

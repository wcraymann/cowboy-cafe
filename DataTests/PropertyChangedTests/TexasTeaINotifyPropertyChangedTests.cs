/*
 * Author: William Raymann.
 * Class: TexasTeaINotifyPropertyChangedTests.
 * Purpose: To test whether the TexasTea class properly implements
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
    /// Tests to determine whether the TexasTea class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class TexasTeaINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether TexasTea implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var texasTea = new TexasTea();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTea);
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "Size" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize(Size size)
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "Size", () =>
            {
                texasTea.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "Price" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice(Size size)
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "Price", () =>
            {
                texasTea.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "Calories" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories(Size size)
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "Calories", () =>
            {
                texasTea.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "Ice" property when the "Ice" property is changed.
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForIce()
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "Ice", () =>
            {
                texasTea.Ice = false;
            });
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Ice" property is changed.
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "SpecialInstructions", () =>
            {
                texasTea.Ice = false;
            });
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "Sweet" property when the "Sweet" property is changed.
        /// </summary>
        [Fact]
        public void ChangingSweetShouldInvokeINotifyPropertyChangedForSweet()
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "Sweet", () =>
            {
                texasTea.Sweet = false;
            });
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Sweet" property is changed.
        /// </summary>
        [Fact]
        public void ChangingSweetShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "SpecialInstructions", () =>
            {
                texasTea.Sweet = false;
            });
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "Lemon" property when the "Lemon" property is changed.
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokeINotifyPropertyChangedForLemon()
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "Lemon", () =>
            {
                texasTea.Lemon = true;
            });
        }

        /// <summary>
        /// Tests whether the TexasTea class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Lemon" property is changed.
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();

            Assert.PropertyChanged(texasTea, "SpecialInstructions", () =>
            {
                texasTea.Lemon = true;
            });
        }
    }
}

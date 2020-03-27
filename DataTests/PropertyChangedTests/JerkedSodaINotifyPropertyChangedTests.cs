/*
 * Author: William Raymann.
 * Class: JerkedSodaINotifyPropertyChangedTests.
 * Purpose: To test whether the JerkedSoda class properly implements 
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
    /// Tests to determine whether the JerkedSoda class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class JerkedSodaINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether JerkedSoda implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var jerkedSoda = new JerkedSoda();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(jerkedSoda);
        }

        /// <summary>
        /// Tests whether the JerkedSoda class invokes INotifyPropertyChanged
        /// for the "Flavor" property when the "Flavor" property is changed.
        /// </summary>
        [Theory]
        [InlineData(SodaFlavor.OrangeSoda)]
        [InlineData(SodaFlavor.Sarsaparilla)]
        [InlineData(SodaFlavor.BirchBeer)]
        [InlineData(SodaFlavor.RootBeer)]
        public void ChangingFlavorShouldInvokeINotifyPropertyChangedForFlavor(SodaFlavor flavor)
        {
            var jerkedSoda = new JerkedSoda();

            Assert.PropertyChanged(jerkedSoda, "Flavor", () =>
            {
                jerkedSoda.Flavor = flavor;
            });
        }

        /// <summary>
        /// Tests whether the JerkedSoda class invokes INotifyPropertyChanged
        /// for the "Size" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize(Size size)
        {
            var jerkedSoda = new JerkedSoda();

            Assert.PropertyChanged(jerkedSoda, "Size", () =>
            {
                jerkedSoda.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the JerkedSoda class invokes INotifyPropertyChanged
        /// for the "Price" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice(Size size)
        {
            var jerkedSoda = new JerkedSoda();

            Assert.PropertyChanged(jerkedSoda, "Price", () =>
            {
                jerkedSoda.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the JerkedSoda class invokes INotifyPropertyChanged
        /// for the "Calories" property when the "Size" property is changed.
        /// </summary>
        [Theory]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories(Size size)
        {
            var jerkedSoda = new JerkedSoda();

            Assert.PropertyChanged(jerkedSoda, "Calories", () =>
            {
                jerkedSoda.Size = size;
            });
        }

        /// <summary>
        /// Tests whether the JerkedSoda class invokes INotifyPropertyChanged
        /// for the "Ice" property when the "Ice" property is changed.
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForIce()
        {
            var jerkedSoda = new JerkedSoda();

            Assert.PropertyChanged(jerkedSoda, "Ice", () =>
            {
                jerkedSoda.Ice = false;
            });
        }

        /// <summary>
        /// Tests whether the JerkedSoda class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Ice" property is changed.
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "SpecialInstructions", () =>
            {
                jerkedSoda.Ice = false;
            });
        }
    }
}

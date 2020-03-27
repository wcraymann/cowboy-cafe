/*
 * Author: William Raymann.
 * Class: CowpokeChiliINotifyPropertyChangedTests.
 * Purpose: To test whether the CowpokeChili class properly implements
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
    /// Tests to determine whether the CowpokeChili class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class CowpokeChiliINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether CowpokeChili implements the INotifyPropertyChanged
        /// interface.
        /// </summary>
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowpokeChili);
        }

        /// <summary>
        /// Tests if CowpokeChili class invokes INotifyPropertyChanged
        /// for the "Cheese" property when the "Cheese" property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.PropertyChanged(cowpokeChili, "Cheese", () =>
            {
                cowpokeChili.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if CowpokeChili class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "Cheese" property is changed.
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () =>
            {
                cowpokeChili.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if CowpokeChili class invokes INotifyPropertyChanged
        /// for the "SourCream" property when the "SourCream" property is changed.
        /// </summary>
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.PropertyChanged(cowpokeChili, "SourCream", () =>
            {
                cowpokeChili.SourCream = false;
            });
        }

        /// <summary>
        /// Tests if CowpokeChili class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "SourCream" property 
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () =>
            {
                cowpokeChili.SourCream = false;
            });
        }

        /// <summary>
        /// Tests if CowpokeChili class invokes INotifyPropertyChanged
        /// for the "GreenOnions" property when the "GreenOnions" property is changed.
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.PropertyChanged(cowpokeChili, "GreenOnions", () =>
            {
                cowpokeChili.GreenOnions = false;
            });
        }

        /// <summary>
        /// Tests if CowpokeChili class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "GreenOnions" property 
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () =>
            {
                cowpokeChili.GreenOnions = false;
            });
        }

        /// <summary>
        /// Tests if CowpokeChili class invokes INotifyPropertyChanged
        /// for the "TortillaStrips" property when the "TortillaStrips" property 
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.PropertyChanged(cowpokeChili, "TortillaStrips", () =>
            {
                cowpokeChili.TortillaStrips = false;
            });
        }

        /// <summary>
        /// Tests if CowpokeChili class invokes INotifyPropertyChanged
        /// for the "SpecialInstructions" property when the "TortillaStrips" property 
        /// is changed.
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();

            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () =>
            {
                cowpokeChili.TortillaStrips = false;
            });
        }
    }
}

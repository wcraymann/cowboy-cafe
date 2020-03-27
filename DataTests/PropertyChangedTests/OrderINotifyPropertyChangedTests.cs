/*
 * Author: William Raymann.
 * Class: OrderINotifyPropertyChanged.
 * Purpose: To test whether the Order class properly implements the 
 *          INotifyPropertyChanged interface.
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
    /// Tests to determine whether the Order class properly implements
    /// the INotifyPropertyChanged interface.
    /// </summary>
    public class OrderINotifyPropertyChangedTests
    {
        /// <summary>
        /// Tests whether the Order class implements the INotifyPropertyChanged
        /// Interface.
        /// </summary>
        [Fact]
        public void EveryClassShouldImplementINotifyPropertyChanged()
        {
            Order order = new Order();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        /// <summary>
        /// Tests whether the Order class invokes its PropertyChanged event for "Items"
        /// whenever one of the properties of the elements in its "Items" changes.
        /// </summary>
        [Fact]
        public void ChangingItemsElementPropertiesShouldInvokePropertyChangedForItems()
        {
            var angryChicken = new AngryChicken();
            var dakotaDouble = new DakotaDoubleBurger();
            var jerkedSoda = new JerkedSoda();
            var order = new Order();

            order.Add(angryChicken);
            order.Add(dakotaDouble);
            order.Add(jerkedSoda);

            Assert.PropertyChanged(order, "Items", () =>
            {
                angryChicken.Bread = false;
            });

            Assert.PropertyChanged(order, "Items", () =>
            {
                angryChicken.Pickle = false;
            });

            Assert.PropertyChanged(order, "Items", () =>
            {
                dakotaDouble.Cheese = false;
            });

            Assert.PropertyChanged(order, "Items", () =>
            {
                dakotaDouble.Bun = false;
            });

            Assert.PropertyChanged(order, "Items", () =>
            {
                jerkedSoda.Flavor = SodaFlavor.BirchBeer;
            });

            Assert.PropertyChanged(order, "Items", () =>
            {
                jerkedSoda.Size = Size.Medium;
            });
        }

        /// <summary>
        /// Tests whether the Order class invokes its PropertyChanged event for "Subtotal"
        /// when one of the properties for one of the elements of "Items" that affects
        /// cost is changed.
        /// </summary>
        [Fact]
        public void ChangingItemsElementPropertiesThatAffectCostShouldInvokePropertyChangedForSubtotal()
        {
            var jerkedSoda = new JerkedSoda();
            var cornDodgers = new CornDodgers();
            var bakedBeans = new BakedBeans();
            var order = new Order();

            order.Add(jerkedSoda);
            order.Add(cornDodgers);
            order.Add(bakedBeans);

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                jerkedSoda.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                cornDodgers.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                bakedBeans.Size = Size.Medium;
            });
        }
    }
}

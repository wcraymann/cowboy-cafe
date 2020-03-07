/*
 * Author: Nathan Bean & William Raymann.
 * Class: OrderTests.
 * Purpose: To verify correct behavoir in CowboyCafe.Data.Order.
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    /// <summary>
    /// A collection of tests for CowboyCafe.Data.Order.
    /// </summary>
    public class OrderTests
    {
        /// <summary>
        /// An order item to test the Order classes' Items property.
        /// </summary>
        public class MockOrderItem : IOrderItem, INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; } = new List<string>();
        }

        /// <summary>
        /// Tests the Order classes' ability to add new order items.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();

            order.Add(item);
            Assert.Contains(item, order.Items);
        }
        

        /// <summary>
        /// Tests the Order classes' ability to remove order items.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        /// <summary>
        /// Tests the Order classes' ability to return a enumeration of 
        /// the items in the order represented by the Order class.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToGetAnEnumerationOfItems()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();

            order.Add(item0);
            order.Add(item1);
            order.Add(item2);

            Assert.Collection(order.Items,
                item => Assert.Equal(item0, item),
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item));
        }

        /// <summary>
        /// Tests the Order classes' ability to accurately total up the 
        /// sum of all the prices of its items and store that value in 
        /// its Subtotal property.
        /// </summary>
        /// <param name="prices">The prices of the order items in the test.</param>
        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0, 0.3, 0 })]
        [InlineData(new double[] { 199.34, 799 })]
        [InlineData(new double[] { 798 })]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { -4, 10, 8 })]
        [InlineData(new double[] { 3.1345234262})]
        [InlineData(new double[] {  double.NaN })]
        public void SubtotalShouldBeTheSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach (var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem() 
                {
                    Price = price
                });
            }

            Assert.Equal(total, order.Subtotal);
        }

        /// <summary>
        /// Tests the Order classes' ability to trigger the PropertyChanged
        /// event handler when either its Subtotal or Items property is changed
        /// due to an item being added to the order represented by the Order class.
        /// </summary>
        /// <param name="propertyName">The property whose change should trigger
        /// the PropertyChanged event handler.</param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void AddingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            item.Price = 12.00;

            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        /// <summary>
        /// Tests the Order classes' ability to trigger the PropertyChanged
        /// event handler when either the Subtotal or Items property is changed
        /// due to an item being removed from the order represented by the Order class.
        /// </summary>
        /// <param name="propertyName">The property whose change should trigger
        /// the PropertyChanged event handler.</param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            item.Price = 12.00;
            order.Add(item);

            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);

            });
        }

        /// <summary>
        /// Tests the Order classes' ability to assign unique identifiers
        /// to each Order object it implements.
        /// </summary>
        [Fact]
        public void EveryClassShouldHaveAUniqueIdentifier()
        {
            Order[] orders = new Order[30];

            for(var index = 0; index < 30; ++index)
            {
                orders[index] = new Order();
            }

            for (var index = 0; index < 30; ++index)
            {
                Assert.True(orders[index].OrderNumber == index + 1);
            }
        }
    }
}

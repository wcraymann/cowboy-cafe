﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; } = new List<string>();
        }

        [Fact]
        // Should be able to add items.
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();

            order.Add(item);
            Assert.Contains(item, order.Items);
        }
        

        // Should be able to remove items.
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Fact]
        // Should be able to to get Getting enumeration of items.
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
        // Subtotal should be the sum of item prices.
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

        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        // Adding an item should trigger PropertyChanged for Price
        public void AddingAnITemShouldTirggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();

            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);

            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);

            });
        }
    }
}

/*
 * Author: William Raymann.
 * Note: Nathan Bean was an indirect contributer.
 * Class: MenuTests.
 * Purpose: To confirm that the data and functionality of the CowboyCafe.Menu static class is configured for
 *          the expected and appropriate behavior.
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Collections.Immutable;

namespace CowboyCafe.DataTests
{
    /// <summary>
    /// A class that tests the CowboyCafe.Menu static class.
    /// </summary>
    public class MenuTests
    {
        /// <summary>
        /// Tests whether the static Entrees field has all of the different Cowboy Cafe entree types and
        /// nothing more.
        /// </summary>
        [Fact]
        public void EntreesPropertyShouldContainAllEntreesAndOnlyEntrees()
        {
            var entrees = new List<IOrderItem>(Menu.Entrees);
            entrees = SortMenuItemsAlphabetically(entrees);

            Assert.Collection(entrees,
                (angryChicken) => { Assert.IsType<AngryChicken>(angryChicken); },
                (cowpokeChili) => { Assert.IsType<CowpokeChili>(cowpokeChili); },
                (dakotaDoubleBurger) => { Assert.IsType<DakotaDoubleBurger>(dakotaDoubleBurger); },
                (pecosPulledPork) => { Assert.IsType<PecosPulledPork>(pecosPulledPork); },
                (rustlersRibs) => { Assert.IsType<RustlersRibs>(rustlersRibs); },
                (texasTripleBurger) => { Assert.IsType<TexasTripleBurger>(texasTripleBurger); },
                (trailBurger) => { Assert.IsType<TrailBurger>(trailBurger); }
                );
        }

        /// <summary>
        /// Tests whether the static Sides field has all of the different Cowboy Cafe side types and
        /// nothing more.
        /// </summary>
        [Fact]
        public void SidesPropertyShouldContainAllSidesAndOnlySides()
        {
            var sides = new List<IOrderItem>(Menu.Sides);
            sides = SortMenuItemsAlphabetically(sides);

            Assert.Collection(sides,
                (bakedBeans) => { Assert.IsType<BakedBeans>(bakedBeans); },
                (chiliCheeseFries) => { Assert.IsType<ChiliCheeseFries>(chiliCheeseFries); },
                (cornDodgers) => { Assert.IsType<CornDodgers>(cornDodgers); },
                (panDeCampo) => { Assert.IsType<PanDeCampo>(panDeCampo); }
                );
        }

        

        /// <summary>
        /// Tests whether the static Drinks field has all of the different Cowboy Cafe drink types and
        /// nothing more.
        /// </summary>
        [Fact]
        public void DrinksPropertyShouldContainAllDrinksAndOnlyDrinks()
        {
            var drinks = new List<IOrderItem>(Menu.Drinks);
            drinks = SortMenuItemsAlphabetically(drinks);

            Assert.Collection(drinks,
                (cowboyCoffee) => { Assert.IsType<CowboyCoffee>(cowboyCoffee); },
                (jerkedSoda) => { Assert.IsType<JerkedSoda>(jerkedSoda); },
                (texasTea) => { Assert.IsType<TexasTea>(texasTea); },
                (water) => { Assert.IsType<Water>(water); }
                );
        }

        /// <summary>
        /// Tests whether the static All field has all of the different Cowboy Cafe IOrderItem types and
        /// only one of each type.
        /// </summary>
        [Fact]
        public void AllPropertyShouldContainAllIOrderItemsAndOnlyOneOfEachIOrderItems()
        {
            var menuItems = new List<IOrderItem>(Menu.All);
            menuItems = SortMenuItemsAlphabetically(menuItems);

            Assert.Collection(menuItems,
                (angryChicken) => { Assert.IsType<AngryChicken>(angryChicken); },
                (bakedBeans) => { Assert.IsType<BakedBeans>(bakedBeans); },
                (chiliCheeseFries) => { Assert.IsType<ChiliCheeseFries>(chiliCheeseFries); },
                (cornDodgers) => { Assert.IsType<CornDodgers>(cornDodgers); },
                (cowboyCoffee) => { Assert.IsType<CowboyCoffee>(cowboyCoffee); },
                (cowpokeChili) => { Assert.IsType<CowpokeChili>(cowpokeChili); },
                (dakotaDoubleBurger) => { Assert.IsType<DakotaDoubleBurger>(dakotaDoubleBurger); },
                (jerkedSoda) => { Assert.IsType<JerkedSoda>(jerkedSoda); },
                (panDeCampo) => { Assert.IsType<PanDeCampo>(panDeCampo); },
                (pecosPulledPork) => { Assert.IsType<PecosPulledPork>(pecosPulledPork); },
                (rustlersRibs) => { Assert.IsType<RustlersRibs>(rustlersRibs); },
                (texasTea) => { Assert.IsType<TexasTea>(texasTea); },
                (texasTripleBurger) => { Assert.IsType<TexasTripleBurger>(texasTripleBurger); },
                (trailBurger) => { Assert.IsType<TrailBurger>(trailBurger); },
                (water) => { Assert.IsType<Water>(water); }
                );
        }

        [Theory]
        [InlineData("Angry Chicken")]
        [InlineData("Angry")]
        [InlineData("Chi")]
        [InlineData("Co")]
        [InlineData("Hello")]
        [InlineData("Double")]
        [InlineData("Tea")]
        [InlineData("a")]
        [InlineData("r")]
        [InlineData("de")]
        [InlineData("CornDodgers")]
        [InlineData("ChiliCheese Fries")]
        [InlineData("Soda")]
        [InlineData("Angry Chicken Appended")]
        [InlineData("Prepended Angry Chicken")]
        public void FilterMenuItemsByKeywordsShouldRemoveOnlyAllItemsWithSubstringMatchingKeywords(
            string keywords)
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByKeywords(Menu.All, keywords);
            List<IOrderItem> resultList = new List<IOrderItem>();
            
            // Copy values in result of resultList.
            foreach(IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Loop through every element in list and see if it is in resultList.
            foreach(IOrderItem item in Menu.All)
            {
                // Create a variable to store the name of the current item.
                string itemName;

                // Determine the name of the current item as it would be displayed on 
                // a webpage on the Cowboy Cafe website. (See CowboyCafe.Website.Index.cshtml)
                if (item is BakedBeans) itemName = "Baked Beans";
                else if (item is ChiliCheeseFries) itemName = "Chili Cheese Fries";
                else if (item is CornDodgers) itemName = "Corn Dodgers";
                else if (item is PanDeCampo) itemName = "Pan de Campo";
                else if (item is CowboyCoffee) itemName = "Cowboy Coffee";
                else if (item is JerkedSoda) itemName = "Jerked Soda";
                else if (item is TexasTea) itemName = "Texas Tea";
                else if (item is Water) itemName = "Water";
                else itemName = item.ToString();

                // If the current list element is in resultList make sure that the 
                // passed keywords are not a substring of the current list element.
                if (resultList.Contains(item))
                {
                    // Check whether the passed keywords are a substring of the current element's
                    // name.
                    Assert.True(itemName.Contains(keywords, StringComparison.InvariantCultureIgnoreCase));
                }
                // Otherwise make sure that the passed keywords are a substring of the
                // current list element.
                else
                {
                    // Check whether the passed keywords are NOT a substring of the current element's
                    // name.
                    Assert.True(!(itemName.Contains(keywords, StringComparison.InvariantCultureIgnoreCase)));
                }
            }
        }

        /// <summary>
        /// Tests whether the FilterMenuItemsByKeywords function returns all passed items
        /// when the passed keyword is null.
        /// </summary>
        [Fact]
        public void FilterMenuItemsByKeywordsShouldReturnAllPassedItemsIfPassedKeywordsIsNull()
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByKeywords(Menu.All, null);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach(IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Create a list of all menu items.
            List<IOrderItem> menuList = new List<IOrderItem>();

            foreach(IOrderItem item in Menu.All)
            {
                menuList.Add(item);
            }

            // Verify that all the IOrderItems in menuList are also in resultList.
            for(int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(menuList[index]));
            }
        }

        /// <summary>
        /// Tests whether the FilterMenuItemsByKeywords function returns all passed items
        /// when the passed items IEnumerable is null.
        /// </summary>
        [Fact]
        public void FilterMenuItemsByKeywordsShouldReturnAnEmpytIEnumerableIfPassedIEnumerableIsNull()
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByKeywords(null, "AngryChicken");

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            Assert.True(resultList.Count == 0);
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByCategory() function removes all the menu items
        /// of a prohibited category for the passed IEnumerable.
        /// </summary>
        /// <param name="removeEntrees">True if all entrees should be removed.</param>
        /// <param name="removeSides">True if all sides should be removed.</param>
        /// <param name="removeDrinks">True if all drinks should be removed.</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, true, true)]
        [InlineData(true, false, true)]
        [InlineData(true, true, false)]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        [InlineData(false, false, false)]
        public void SortMenuItemsByCategoryShouldRemoveAllItemsInWrongCategories(bool removeEntrees,
            bool removeSides, bool removeDrinks)
        {
            // Construct a list of the prohibited types.
            List<string> categoriesToRemove = new List<string>();

            if (removeEntrees) categoriesToRemove.Add("Entree");
            if (removeSides) categoriesToRemove.Add("Side");
            if (removeDrinks) categoriesToRemove.Add("Drink");

            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByCategory(Menu.All, categoriesToRemove);

            // Make sure there are no prohibited types in the result IEnumerable.
            foreach(IOrderItem item in result)
            {
                if (removeEntrees) Assert.True(!(item is Entree));
                if (removeSides) Assert.True(!(item is Side));
                if (removeDrinks) Assert.True(!(item is Drink));
            }
        }

        /// <summary>
        /// Tests whether the FilterMenuItemsByCategory function returns all passed items
        /// when the passed category IEnumerable is null.
        /// </summary>
        [Fact]
        public void FilterMenuItemsByCategoryShouldReturnAllPassedItemsIfPassedCategoryIEnumerableIsNull()
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByCategory(Menu.All, null);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Create a list of all menu items.
            List<IOrderItem> menuList = new List<IOrderItem>();

            foreach (IOrderItem item in Menu.All)
            {
                menuList.Add(item);
            }

            // Verify that all the IOrderItems in menuList are also in resultList.
            for (int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(menuList[index]));
            }
        }

        /// <summary>
        /// Tests whether the FilterMenuItemsByCategory function returns all passed items
        /// when the passed items IEnumerable is null.
        /// </summary>
        [Fact]
        public void FilterMenuItemsByCategoryShouldReturnAnEmpytIEnumerableIfPassedIEnumerableIsNull()
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByCategory(null, new List<string>());

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            Assert.True(resultList.Count == 0);
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByCalories function removes only all items from the 
        /// passed list who's calorie count is above the passed min and max.
        /// </summary>
        /// <param name="min">The minimum calorie requirement.</param>
        /// <param name="max">The maximum calorie requirement.</param>
        [Theory]
        [InlineData(1, 500)]
        [InlineData(400, 401)]
        [InlineData(23, 1000)]
        [InlineData(0, 0)]
        [InlineData(76, 340)]
        [InlineData(200, 201)]
        [InlineData(111, 222)]
        [InlineData(100, 0)]
        public void SortMenuItemsByCaloriesShouldRemoveAllItemsWithCalorieCountOutOfRange(uint min,
            uint max)
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByCalories(Menu.All, min, max);
            
            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach(IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Stores the items that should be in the result.
            List<IOrderItem> correctItems = new List<IOrderItem>();

            // Loop through all the Menu.All items and make sure that every item who's
            // calorie count is <= to the max is present in the resultList.
            foreach (IOrderItem item in Menu.All)
            {
                if (item is Entree entree)
                {
                    if (entree.Calories <= max && entree.Calories >= min) correctItems.Add(item);
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Calories >= min && side.Calories <= max)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        side.Size = Size.Medium;
                        if (side.Calories >= min && side.Calories <= max)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            side.Size = Size.Large;
                            if (side.Calories >= min && side.Calories <= max)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Calories >= min && drink.Calories <= max)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        drink.Size = Size.Medium;
                        if (drink.Calories >= min && drink.Calories <= max)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            drink.Size = Size.Large;
                            if (drink.Calories >= min && drink.Calories <= max)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else throw new NotImplementedException("The current IOrderItem is of no known type.");

                
            }

            // Make sure that both lists are arranged alphabetically.
            SortMenuItemsAlphabetically(resultList);
            SortMenuItemsAlphabetically(correctItems);;

            // Verify that both lists have the same count.
            Assert.Equal(resultList.Count, correctItems.Count);

            // Verify that the resultList has all the correct items.
            for(int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(correctItems[index]));
            }
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByCalorieCount function returns only all items
        /// who's calorie count is below or equal to the passed max if passed min is null.
        /// </summary>
        /// <param name="max"></param>
        [Theory]
        [InlineData(500)]
        [InlineData(600)]
        [InlineData(0)]
        [InlineData(1234)]
        [InlineData(23)]
        public void SortMenuItemsByCaloriesShouldRemoveAllItemsWithCalorieCountBelowOrEqualToMaxIfMinIsNull(uint max) 
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByCalories(Menu.All, null, max);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Stores the items that should be in the result.
            List<IOrderItem> correctItems = new List<IOrderItem>();

            // Loop through all the Menu.All items and make sure that every item who's
            // calorie count is <= to the max is present in the resultList.
            foreach (IOrderItem item in Menu.All)
            {
                if (item is Entree entree)
                {
                    if (entree.Calories <= max) correctItems.Add(item);
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Calories <= max)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        side.Size = Size.Medium;
                        if (side.Calories <= max)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            side.Size = Size.Large;
                            if (side.Calories <= max)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Calories <= max)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        drink.Size = Size.Medium;
                        if (drink.Calories <= max)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            drink.Size = Size.Large;
                            if (drink.Calories <= max)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else throw new NotImplementedException("The current IOrderItem is of no known type.");
            }

            // Make sure that both lists are arranged alphabetically.
            SortMenuItemsAlphabetically(resultList);
            SortMenuItemsAlphabetically(correctItems); ;

            // Verify that both lists have the same count.
            Assert.Equal(resultList.Count, correctItems.Count);

            // Verify that the resultList has all the correct items.
            for (int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(correctItems[index]));
            }
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByCalorieCount function returns only all items
        /// who's calorie count is above or equal to the passed min if passed max is null.
        /// </summary>
        /// <param name="max"></param>
        [Theory]
        [InlineData(500)]
        [InlineData(230)]
        [InlineData(0)]
        [InlineData(56)]
        [InlineData(23)]
        [InlineData(6000)]
        public void SortMenuItemsByCaloriesShouldRemoveAllItemsWithCalorieCountAboveOrEqualToMinIfMaxIsNull(uint min) 
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByCalories(Menu.All, min, null);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Stores the items that should be in the result.
            List<IOrderItem> correctItems = new List<IOrderItem>();

            // Loop through all the Menu.All items and make sure that every item who's
            // calorie count is <= to the max is present in the resultList.
            foreach (IOrderItem item in Menu.All)
            {
                if (item is Entree entree)
                {
                    if (entree.Calories >= min) correctItems.Add(item);
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Calories >= min)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        side.Size = Size.Medium;
                        if (side.Calories >= min)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            side.Size = Size.Large;
                            if (side.Calories >= min)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Calories >= min)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        drink.Size = Size.Medium;
                        if (drink.Calories >= min)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            drink.Size = Size.Large;
                            if (drink.Calories >= min)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else throw new NotImplementedException("The current IOrderItem is of no known type.");
            }

            // Make sure that both lists are arranged alphabetically.
            SortMenuItemsAlphabetically(resultList);
            SortMenuItemsAlphabetically(correctItems); ;

            // Verify that both lists have the same count.
            Assert.Equal(resultList.Count, correctItems.Count);

            // Verify that the resultList has all the correct items.
            for (int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(correctItems[index]));
            }
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByCalories function returns all the items it
        /// was passed if both the min and max are null.
        /// </summary>
        [Fact]
        public void SortMenuItemsByCaloriesShouldReturnAllPassedItemsIfMinAndMaxAreNull()
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByCalories(Menu.All, null, null);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Create a list of all menu items.
            List<IOrderItem> menuList = new List<IOrderItem>();

            foreach (IOrderItem item in Menu.All)
            {
                menuList.Add(item);
            }

            // Verify that all the IOrderItems in menuList are also in resultList.
            for (int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(menuList[index]));
            }
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByCalories function returns an empty list
        /// whenever the passed IEnumerable of items is null or empty.
        /// </summary>
        [Fact]
        public void SortMenuItemsByCaloriesShouldReturnAnEmptyIEnumerableIfPassedIEnumerableIsNullOrEmpty()
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByCalories(null, 0, 1000);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Verify that an empyt list was returned.
            Assert.True(resultList.Count == 0);

            // Clear resultList.
            resultList = new List<IOrderItem>();

            result = Menu.FilterMenuItemsByCalories(new List<IOrderItem>(), 0, 1000);

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Verify that an empyt list was returned.
            Assert.True(resultList.Count == 0);
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByCalories function removes only all items from the 
        /// passed list who's price is above the passed min and max.
        /// </summary>
        /// <param name="min">The minimum price requirement.</param>
        /// <param name="max">The maximum calorie requirement.</param>
        [Theory]
        [InlineData(0.00, 0.00)]
        [InlineData(1.00, 10.00)]
        [InlineData(100.00, 1000.00)]
        [InlineData(2.32, 4.57)]
        [InlineData(7.89, 7.90)]
        [InlineData(0.123456, 3.214576)]
        [InlineData(double.NaN, 10.00)]
        [InlineData(1.00, double.NaN)]
        [InlineData(double.NaN, double.NaN)]
        [InlineData(-1.23, -0.23)]
        [InlineData(5.00, 1.00)]
        public void SortMenuItemsByPriceShouldRemoveAllItemsWithPriceOutOfRange(double min,
            double max)
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByPrice(Menu.All, min, max);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Stores the items that should be in the result.
            List<IOrderItem> correctItems = new List<IOrderItem>();

            // Loop through all the Menu.All items and make sure that every item who's
            // calorie count is <= to the max is present in the resultList.
            foreach (IOrderItem item in Menu.All)
            {
                if (item is Entree entree)
                {
                    if (entree.Price <= max && entree.Price >= min) correctItems.Add(item);
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Price >= min && side.Price <= max)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        side.Size = Size.Medium;
                        if (side.Price >= min && side.Price <= max)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            side.Size = Size.Large;
                            if (side.Price >= min && side.Price <= max)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Price >= min && drink.Price <= max)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        drink.Size = Size.Medium;
                        if (drink.Price >= min && drink.Price <= max)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            drink.Size = Size.Large;
                            if (drink.Price >= min && drink.Price <= max)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else throw new NotImplementedException("The current IOrderItem is of no known type.");
            }

            // Make sure that both lists are arranged alphabetically.
            SortMenuItemsAlphabetically(resultList);
            SortMenuItemsAlphabetically(correctItems); ;

            // Verify that both lists have the same count.
            Assert.Equal(resultList.Count, correctItems.Count);

            // Verify that the resultList has all the correct items.
            for (int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(correctItems[index]));
            }
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByPrice function returns only all items
        /// who's price is below or equal to the passed max if passed min is null.
        /// </summary>
        /// <param name="max"></param>
        [Theory]
        [InlineData(500.00)]
        [InlineData(0.12)]
        [InlineData(7.89)]
        [InlineData(6.50)]
        [InlineData(3.23)]
        [InlineData(double.NaN)]
        [InlineData(0.00)]
        [InlineData(-1.23)]
        public void SortMenuItemsByPriceShouldRemoveAllItemsWithPriceBelowOrEqualToMaxIfMinIsNull(double max)
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByPrice(Menu.All, null, max);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Stores the items that should be in the result.
            List<IOrderItem> correctItems = new List<IOrderItem>();

            // Loop through all the Menu.All items and make sure that every item who's
            // price is <= to the max is present in the resultList.
            foreach (IOrderItem item in Menu.All)
            {
                if (item is Entree entree)
                {
                    if (entree.Price <= max) correctItems.Add(item);
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Price <= max)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        side.Size = Size.Medium;
                        if (side.Price <= max)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            side.Size = Size.Large;
                            if (side.Price <= max)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Price <= max)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        drink.Size = Size.Medium;
                        if (drink.Price <= max)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            drink.Size = Size.Large;
                            if (drink.Price <= max)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else throw new NotImplementedException("The current IOrderItem is of no known type.");
            }

            // Make sure that both lists are arranged alphabetically.
            SortMenuItemsAlphabetically(resultList);
            SortMenuItemsAlphabetically(correctItems); ;

            // Verify that both lists have the same count.
            Assert.Equal(resultList.Count, correctItems.Count);

            // Verify that the resultList has all the correct items.
            for (int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(correctItems[index]));
            }
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByPrice function returns only all items
        /// who's price is above or equal to the passed min if passed max is null.
        /// </summary>
        /// <param name="max"></param>
        [Theory]
        [InlineData(500.00)]
        [InlineData(0.12)]
        [InlineData(7.89)]
        [InlineData(6.50)]
        [InlineData(3.23)]
        [InlineData(double.NaN)]
        [InlineData(0.00)]
        [InlineData(-1.23)]
        public void SortMenuItemsByPriceShouldRemoveAllItemsWithPriceAboveOrEqualToMinIfMaxIsNull(double min)
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByPrice(Menu.All, min, null);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Stores the items that should be in the result.
            List<IOrderItem> correctItems = new List<IOrderItem>();

            // Loop through all the Menu.All items and make sure that every item who's
            // price is <= to the max is present in the resultList.
            foreach (IOrderItem item in Menu.All)
            {
                if (item is Entree entree)
                {
                    if (entree.Price >= min) correctItems.Add(item);
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Price >= min)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        side.Size = Size.Medium;
                        if (side.Price >= min)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            side.Size = Size.Large;
                            if (side.Price >= min)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Price >= min)
                    {
                        correctItems.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        drink.Size = Size.Medium;
                        if (drink.Price >= min)
                        {
                            correctItems.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            drink.Size = Size.Large;
                            if (drink.Price >= min)
                            {
                                correctItems.Add(item);
                            }
                        }
                    }
                }
                else throw new NotImplementedException("The current IOrderItem is of no known type.");
            }

            // Make sure that both lists are arranged alphabetically.
            SortMenuItemsAlphabetically(resultList);
            SortMenuItemsAlphabetically(correctItems); ;
            //throw new Exception("ResultList = " + resultList.Count + " // CorrectItems = " + correctItems.Count);
            // Verify that both lists have the same count.
            Assert.Equal(resultList.Count, correctItems.Count);

            // Verify that the resultList has all the correct items.
            for (int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(correctItems[index]));
            }
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByPrice function returns all the items it
        /// was passed if both the min and max are null.
        /// </summary>
        [Fact]
        public void SortMenuItemsByPriceShouldReturnAllPassedItemsIfMinAndMaxAreNull()
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByPrice(Menu.All, null, null);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Create a list of all menu items.
            List<IOrderItem> menuList = new List<IOrderItem>();

            foreach (IOrderItem item in Menu.All)
            {
                menuList.Add(item);
            }

            // Verify that all the IOrderItems in menuList are also in resultList.
            for (int index = 0; index < resultList.Count; ++index)
            {
                Assert.True(resultList[index].Equals(menuList[index]));
            }
        }

        /// <summary>
        /// Test whether the FilterMenuItemsByPrice function returns an empty list
        /// whenever the passed IEnumerable of items is null or empty.
        /// </summary>
        [Fact]
        public void SortMenuItemsByPriceShouldReturnAnEmptyIEnumerableIfPassedIEnumerableIsNullOrEmpty()
        {
            IEnumerable<IOrderItem> result = Menu.FilterMenuItemsByPrice(null, 0, 1000);

            // Create a list of the result items.
            List<IOrderItem> resultList = new List<IOrderItem>();

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Verify that an empyt list was returned.
            Assert.True(resultList.Count == 0);

            // Clear resultList.
            resultList = new List<IOrderItem>();

            result = Menu.FilterMenuItemsByPrice(new List<IOrderItem>(), 0, 1000);

            foreach (IOrderItem item in result)
            {
                resultList.Add(item);
            }

            // Verify that an empyt list was returned.
            Assert.True(resultList.Count == 0);
        }

        /// <summary>
        /// A helper method that sorts the IOrderItems in a list alphabetically by the spelling 
        /// of their class names (with whitespaces inbetween the individual words).
        /// </summary>
        /// <param name="list">The list of IOrderItems to sort.</param>
        /// <returns>A alphabetically sorted list by class name.</returns>
        public List<IOrderItem> SortMenuItemsAlphabetically(List<IOrderItem> list)
        {
            // Loop through all the elements once, finding the next chronologically first
            // element out of the remaining unsorted elements.
            for (int index = 0; index < list.Count; ++index)
            {
                string name;

                // Determine the proper name of the current element.
                if (list[index] is AngryChicken) name = "Angry Chicken";
                else if (list[index] is BakedBeans) name = "Baked Beans";
                else if (list[index] is ChiliCheeseFries) name = "Chili Cheese Fries";
                else if (list[index] is CornDodgers) name = "Corn Dodgers";
                else if (list[index] is CowboyCoffee) name = "Cowboy Coffee";
                else if (list[index] is CowpokeChili) name = "Cowpoke Chili";
                else if (list[index] is DakotaDoubleBurger) name = "Dakota Double Burger";
                else if (list[index] is JerkedSoda) name = "Jerked Soda";
                else if (list[index] is PanDeCampo) name = "Pan de Campo";
                else if (list[index] is PecosPulledPork) name = "Pecos Pulled Pork";
                else if (list[index] is RustlersRibs) name = "Rustlers Ribs";
                else if (list[index] is TexasTea) name = "Texas Tea";
                else if (list[index] is TexasTripleBurger) name = "Texas Triple Burger";
                else if (list[index] is TrailBurger) name = "Trail Burger";
                else name = "Water";

                int chronologicallyFirst = index;
                string chronologicallyFirstName = name;

                // Search for the chronologically first element out of the remaining elements.
                for (int index2 = index; index2 < list.Count; ++index2)
                {
                    string name2;

                    // Determine the proper name of the second element.
                    if (list[index2] is AngryChicken) name2 = "Angry Chicken";
                    else if (list[index2] is BakedBeans) name2 = "Baked Beans";
                    else if (list[index2] is ChiliCheeseFries) name2 = "Chili Cheese Fries";
                    else if (list[index2] is CornDodgers) name2 = "Corn Dodgers";
                    else if (list[index2] is CowboyCoffee) name2 = "Cowboy Coffee";
                    else if (list[index2] is CowpokeChili) name2 = "Cowpoke Chili";
                    else if (list[index2] is DakotaDoubleBurger) name2 = "Dakota Double Burger";
                    else if (list[index2] is JerkedSoda) name2 = "Jerked Soda";
                    else if (list[index2] is PanDeCampo) name2 = "Pan de Campo";
                    else if (list[index2] is PecosPulledPork) name2 = "Pecos Pulled Pork";
                    else if (list[index2] is RustlersRibs) name2 = "Rustlers Ribs";
                    else if (list[index2] is TexasTea) name2 = "Texas Tea";
                    else if (list[index2] is TexasTripleBurger) name2 = "Texas Triple Burger";
                    else if (list[index2] is TrailBurger) name2 = "Trail Burger";
                    else name2 = "Water";
    
                    if (name2.CompareTo(chronologicallyFirstName) < 0)
                    {
                        chronologicallyFirst = index2;

                        // Determine the proper name of the new chronologically first element.
                        if (list[chronologicallyFirst] is AngryChicken) chronologicallyFirstName = "Angry Chicken";
                        else if (list[chronologicallyFirst] is BakedBeans) chronologicallyFirstName = "Baked Beans";
                        else if (list[chronologicallyFirst] is ChiliCheeseFries) chronologicallyFirstName = "Chili Cheese Fries";
                        else if (list[chronologicallyFirst] is CornDodgers) chronologicallyFirstName = "Corn Dodgers";
                        else if (list[chronologicallyFirst] is CowboyCoffee) chronologicallyFirstName = "Cowboy Coffee";
                        else if (list[chronologicallyFirst] is CowpokeChili) chronologicallyFirstName = "Cowpoke Chili";
                        else if (list[chronologicallyFirst] is DakotaDoubleBurger) chronologicallyFirstName = "Dakota Double Burger";
                        else if (list[chronologicallyFirst] is JerkedSoda) chronologicallyFirstName = "Jerked Soda";
                        else if (list[chronologicallyFirst] is PanDeCampo) chronologicallyFirstName = "Pan de Campo";
                        else if (list[chronologicallyFirst] is PecosPulledPork) chronologicallyFirstName = "Pecos Pulled Pork";
                        else if (list[chronologicallyFirst] is RustlersRibs) chronologicallyFirstName = "Rustlers Ribs";
                        else if (list[chronologicallyFirst] is TexasTea) chronologicallyFirstName = "Texas Tea";
                        else if (list[chronologicallyFirst] is TexasTripleBurger) chronologicallyFirstName = "Texas Triple Burger";
                        else if (list[chronologicallyFirst] is TrailBurger) chronologicallyFirstName = "Trail Burger";
                        else chronologicallyFirstName = "Water";
                    }
                }

                // Swap the variables.
                IOrderItem temp = list[index];
                list[index] = list[chronologicallyFirst];
                list[chronologicallyFirst] = temp;
            }

            return list;
        } 
    }
}

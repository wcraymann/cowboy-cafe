/*
 * Author: William Raymann and K-State CIS400 Spring 2020 Faculty.
 * Class: Menu.
 * Purpose: To proved functionality and data for aquiring the items that go on a Cowboy Cafe
 *          menu.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A static class contianing functionality for aquiring items (as lists of objects) for a Cowboy Cafe menu.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Stores an IEnumeration of the IOrderItems that belong to the Entree class of menu items in
        /// the Cowboy Cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees = new List<IOrderItem>()
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };

        /// <summary>
        /// Stores an IEnumeration of the IOrderItems that belong to the Side class of menu items in
        /// the Cowboy Cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides = new List<IOrderItem>()
            {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()
            };

        /// <summary>
        /// Stores an IEnumeration of the IOrderItems that belong to the Entree class of menu items in
        /// the Cowboy Cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks = new List<IOrderItem>()
            {
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water(),
            };

        /// <summary>
        /// Returns an IEnumeration of the IOrderItems that include every item in the Cowboy Cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> All = new List<IOrderItem>()
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger(),
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo(),
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };

        /// <summary>
        /// Returns a list of items who's names contain the passed keywords as a substring of their name.
        /// </summary>
        /// <param name="items">The current items that are going to be displayed on the CowboyCafe Website.</param>
        /// <param name="keywords">The keywords an item must have as a substring to be included in the return list</param>
        /// <returns>A list of items who have the passed keywords as a substring in thier names.</returns>
        public static IEnumerable<IOrderItem> FilterMenuItemsByKeywords(IEnumerable<IOrderItem> items, string keywords)
        {
            // Return a empty List<IOrderItem if items is null.
            if (items == null) return new List<IOrderItem>();

            // Return the passed IEnumerable<IOrderItem> if keywords is null.
            if (keywords == null) return items;

            // Create a list that will store the items that should be displayed on the Index.cshtml
            // file in the CowboyCafe.Website namespace.
            List<IOrderItem> filteredItems = new List<IOrderItem>();

            // Loop through all the passed items and remove any items that do not share a substring
            // with the passed keywords string.
            foreach(IOrderItem item in items)
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

                // If the passed keywords are a part of the current item's name add the
                // current item to the filteredItems list.
                if (itemName.Contains(keywords, StringComparison.InvariantCultureIgnoreCase)) filteredItems.Add(item);
            }

            return filteredItems;
        }

        /// <summary>
        /// Returns a list of items from the passed list of items that are not of any of the categories represented
        /// by a string in the passed list of strings. The three categories of IOrderItems are Entrees, Sides, and
        /// Drinks.
        /// </summary>
        /// <param name="items">The items we are filtering.</param>
        /// <param name="categoriesToRemove">A list of strings representing the categories of IOrderItems
        ///                                  that should not appear in the returned list of items.</param>
        /// <returns>A list of items form the passed list of items that are not of any categories prohibited by 
        ///          the passed list of strings representing IOrderItem categories.</returns>
        public static IEnumerable<IOrderItem> FilterMenuItemsByCategory(IEnumerable<IOrderItem> items, 
            IEnumerable<string> categoriesToRemove)
        {
            // Return a empty List<IOrderItem if items is null.
            if (items == null) return new List<IOrderItem>();

            // Return the current list of IOrderItems if the passed categoriesToRemove is null.
            if (categoriesToRemove == null) return items;

            // Create a List<IOrderItem> to store the IOrderItems in items.
            List<IOrderItem> itemsToFilter = new List<IOrderItem>();

            foreach(IOrderItem item in items)
            {
                itemsToFilter.Add(item);
            }

            // Return the current list of IOrderItems if the passed categoriesToRemove is empty.
            if (itemsToFilter.Count == 0) return items;

            // Loop through each string in categoriesToRemove and add every IOrderItem in items
            // that is of the type represented by the string.
            foreach (string category in categoriesToRemove)
            {
                // Determine the IOrderItem category represented by the current string and
                // loop through all the passed items removing all IOrderItems that are in 
                // the category represented by the current string.
                switch(category)
                {
                    case "Entree":
                        for (int index = 0; index < itemsToFilter.Count; ++index)
                        {
                            if (itemsToFilter[index] is Entree)
                            {
                                itemsToFilter.Remove(itemsToFilter[index]);
                                --index;
                            }
                        }
                        break;
                    case "Side":
                        for(int index = 0; index < itemsToFilter.Count; ++index)
                        {
                            if (itemsToFilter[index] is Side)
                            {
                                itemsToFilter.Remove(itemsToFilter[index]);
                                --index;
                            }
                        }
                        break;
                    case "Drink":
                        for (int index = 0; index < itemsToFilter.Count; ++index)
                        {
                            if (itemsToFilter[index] is Drink)
                            {
                                itemsToFilter.Remove(itemsToFilter[index]);
                                --index;
                            }
                        }
                        break;
                    default:
                        throw new ArgumentException("String representing non-existent category of IOrderItem.");
                }
            }

            return itemsToFilter;
        }

        /// <summary>
        /// Returns a list of items from the passed list of IOrderItems who's calorie count is equal to one of the two
        /// passed calorie limits or is somewhere inbetween the two limits.
        /// </summary>
        /// <param name="items">The orginal list of items.</param>
        /// <param name="minimumCalories">The minimum calorie requirement.</param>
        /// <param name="maximumCalories">The maximum calorie requirement.</param>
        /// <returns>A list of items within the specified calorie range.</returns>
        public static IEnumerable<IOrderItem> FilterMenuItemsByCalories(IEnumerable<IOrderItem> items, uint? minimumCalories,
                                                                        uint? maximumCalories)
        {
            // Return a empty List<IOrderItem if items is null.
            if (items == null) return new List<IOrderItem>();

            // Return the passed list of IOrderItems if the passed limites are both null.
            if (minimumCalories == null && maximumCalories == null) return items;

            // Create a List<IOrderItem> to store the IOrderItems in items.
            List<IOrderItem> itemsToFilter = new List<IOrderItem>();

            foreach(IOrderItem item in items)
            {
                itemsToFilter.Add(item);
            }

            // Remove all IOrderItems in items who's calorie count is below the passed minimum calorie
            // requirement if the passed maximum calorie requirement is null.
            if (maximumCalories == null)
            {
                for (int index = 0; index < itemsToFilter.Count; ++index)
                {
                    if (itemsToFilter[index] is Entree entree)
                    {
                        if (entree.Calories < minimumCalories)
                        {
                            itemsToFilter.Remove(entree);
                            --index;
                        }
                    }
                    else if (itemsToFilter[index] is Side side)
                    {
                        side.Size = Size.Small;
                        if (side.Calories < minimumCalories)
                        {
                            // Check the Medium Size.
                            side.Size = Size.Medium;
                            if (side.Calories < minimumCalories)
                            {
                                // Check the Large Size.
                                side.Size = Size.Large;
                                if (side.Calories < minimumCalories)
                                {
                                    itemsToFilter.Remove(side);
                                    --index;
                                }
                            }  // End checking Medium Size.    
                        }
                    }
                    else if (itemsToFilter[index] is Drink drink)
                    {
                        drink.Size = Size.Small;
                        if (drink.Calories < minimumCalories)
                        {
                            // Check the Medium Size.
                            drink.Size = Size.Medium;
                            if (drink.Calories < minimumCalories)
                            {
                                // Check the Large Size.
                                drink.Size = Size.Large;
                                if (drink.Calories < minimumCalories)
                                {
                                    itemsToFilter.Remove(drink);
                                    --index;
                                }
                            }  // End checking Medium Size.
                        }
                    }
                }
                return itemsToFilter;
            }
            // Remove all IOrderItems in itemsToFilter who's calorie count is above the passed maximum calorie
            // requirement if the passed minimum calorie requirement is null.
            else if (minimumCalories == null)
            {
                for (int index = 0; index < itemsToFilter.Count; ++index)
                {
                    if (itemsToFilter[index] is Entree entree)
                    {
                        if (entree.Calories > maximumCalories)
                        {
                            itemsToFilter.Remove(entree);
                            --index;
                        }
                    }
                    else if (itemsToFilter[index] is Side side)
                    {
                        side.Size = Size.Small;
                        if (side.Calories > maximumCalories)
                        {
                            // Check the Medium Size.
                            side.Size = Size.Medium;
                            if (side.Calories > maximumCalories)
                            {
                                // Check the Large Size.
                                side.Size = Size.Large;
                                if (side.Calories > maximumCalories)
                                {
                                    itemsToFilter.Remove(side);
                                    --index;
                                }
                            }  // End checking Medium Size.
                        }
                    }
                    else if (itemsToFilter[index] is Drink drink)
                    {
                        drink.Size = Size.Small;
                        if (drink.Calories > maximumCalories)
                        {
                            // Check the Medium Size.
                            drink.Size = Size.Medium;
                            if (drink.Calories > maximumCalories)
                            {
                                // Check the Large Size.
                                drink.Size = Size.Large;
                                if (drink.Calories > maximumCalories)
                                {
                                    itemsToFilter.Remove(drink);
                                    --index;
                                }
                            }  // End checking Medium Size.
                        }
                    }
                }
                return itemsToFilter;
            }

            // Otherwise remove all IOrderItems in items who's calorie count is above the passed maximum limit
            // or below the passed minimum limit.
            for(int index = 0; index < itemsToFilter.Count; ++index)
            {
                if (itemsToFilter[index] is Entree entree)
                {
                    if (entree.Calories < minimumCalories || entree.Calories > maximumCalories)
                    {
                        itemsToFilter.Remove(entree);
                        --index;
                    }
                }
                else if (itemsToFilter[index] is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Calories < minimumCalories || side.Calories > maximumCalories)
                    {
                        // Check the Medium Size.
                        side.Size = Size.Medium;
                        if (side.Calories < minimumCalories || side.Calories > maximumCalories)
                        {
                            // Check the Large Size.
                            side.Size = Size.Large;
                            if (side.Calories < minimumCalories || side.Calories > maximumCalories)
                            {
                                itemsToFilter.Remove(side);
                                --index;
                            }
                        }  // End checking Medium Size.
                    }
                }
                else if (itemsToFilter[index] is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Calories < minimumCalories || drink.Calories > maximumCalories)
                    {
                        // Check the Medium Size.
                        drink.Size = Size.Medium;
                        if (drink.Calories < minimumCalories || drink.Calories > maximumCalories)
                        {
                            // Check the Large Size.
                            drink.Size = Size.Large;
                            if (drink.Calories < minimumCalories || drink.Calories > maximumCalories)
                            {
                                itemsToFilter.Remove(drink);
                                --index;
                            }
                        }  // End checking Medium Size.
                    }
                }
            }

            return itemsToFilter;
        }

        /// <summary>
        /// Returns a list of items from the passed list of IOrderItems who's price is equal to one of the two
        /// passed price limits or is somewhere inbetween the two limits.
        /// </summary>
        /// <param name="items">The orginal list of items.</param>
        /// <param name="minimumCalories">The minimum price requirement.</param>
        /// <param name="maximumCalories">The maximum price requirement.</param>
        /// <returns>A list of items within the specified price range.</returns>
        public static IEnumerable<IOrderItem> FilterMenuItemsByPrice(IEnumerable<IOrderItem> items, double? minimumPrice,
                                                                        double? maximumPrice)
        {
            // Return a empty List<IOrderItem if items is null.
            if (items == null) return new List<IOrderItem>();

            // Return the passed list of IOrderItems if the passed limits are both null.
            if (minimumPrice == null && maximumPrice == null) return items;

            // Create a List<IOrderItem> to store the IOrderItems in items.
            List<IOrderItem> itemsToFilter = new List<IOrderItem>();

            // Remove all IOrderItems in items who's price is below the passed minimum price
            // requirement if the passed maximum price requirement is null.
            if (maximumPrice == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item is Entree entree)
                    {
                        if (entree.Price >= minimumPrice)
                        {
                            itemsToFilter.Add(item);
                        }
                    }
                    else if (item is Side side)
                    {
                        side.Size = Size.Small;
                        if (side.Price >= minimumPrice)
                        {
                            itemsToFilter.Add(item);
                        }
                        else
                        {
                            // Check Medium Size.
                            side.Size = Size.Medium;
                            if (side.Price >= minimumPrice)
                            {
                                itemsToFilter.Add(item);
                            }
                            else
                            {
                                // Check Large Size.
                                side.Size = Size.Large;
                                if (side.Price >= minimumPrice)
                                {
                                    itemsToFilter.Add(item);
                                }
                            }
                        }
                    }
                    else if (item is Drink drink)
                    {
                        drink.Size = Size.Small;
                        if (drink.Price >= minimumPrice)
                        {
                            itemsToFilter.Add(item);
                        }
                        else
                        {
                            // Check Medium Size.
                            drink.Size = Size.Medium;
                            if (drink.Price >= minimumPrice)
                            {
                                itemsToFilter.Add(item);
                            }
                            else
                            {
                                // Check Large Size.
                                drink.Size = Size.Large;
                                if (drink.Price >= minimumPrice)
                                {
                                    itemsToFilter.Add(item);
                                }
                            }
                        }
                    }
                }

                return itemsToFilter;
            }
            // Remove all IOrderItems in itemsToFilter who's calorie count is above the passed maximum calorie
            // requirement if the passed minimum calorie requirement is null.
            else if (minimumPrice == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item is Entree entree)
                    {
                        if (entree.Price <= maximumPrice)
                        {
                            itemsToFilter.Add(item);
                        }
                    }
                    else if (item is Side side)
                    {
                        side.Size = Size.Small;
                        if (side.Price <= maximumPrice)
                        {
                            itemsToFilter.Add(item);
                        }
                        else
                        {
                            // Check Medium Size.
                            side.Size = Size.Medium;
                            if (side.Price <= maximumPrice)
                            {
                                itemsToFilter.Add(item);
                            }
                            else
                            {
                                // Check Large Size.
                                side.Size = Size.Large;
                                if (side.Price <= maximumPrice)
                                {
                                    itemsToFilter.Add(item);
                                }
                            }
                        }
                    }
                    else if (item is Drink drink)
                    {
                        drink.Size = Size.Small;
                        if (drink.Price <= maximumPrice)
                        {
                            itemsToFilter.Add(item);
                        }
                        else
                        {
                            // Check Medium Size.
                            drink.Size = Size.Medium;
                            if (drink.Price <= maximumPrice)
                            {
                                itemsToFilter.Add(item);
                            }
                            else
                            {
                                // Check Large Size.
                                drink.Size = Size.Large;
                                if (drink.Price <= maximumPrice)
                                {
                                    itemsToFilter.Add(item);
                                }
                            }
                        }
                    }
                }

                return itemsToFilter;
            }

            // Otherwise remove all IOrderItems in items who's calorie count is above the passed maximum limit
            // or below the passed minimum limit.
            foreach (IOrderItem item in items)
            {
                if (item is Entree entree)
                {
                    if (entree.Price >= minimumPrice && entree.Price <= maximumPrice)
                    {
                        itemsToFilter.Add(item);
                    }
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Price >= minimumPrice && side.Price <= maximumPrice)
                    {
                        itemsToFilter.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        side.Size = Size.Medium;
                        if (side.Price >= minimumPrice && side.Price <= maximumPrice)
                        {
                            itemsToFilter.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            side.Size = Size.Large;
                            if (side.Price >= minimumPrice && side.Price <= maximumPrice)
                            {
                                itemsToFilter.Add(item);
                            }
                        }
                    }
                }
                else if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Price >= minimumPrice && drink.Price <= maximumPrice)
                    {
                        itemsToFilter.Add(item);
                    }
                    else
                    {
                        // Check Medium Size.
                        drink.Size = Size.Medium;
                        if (drink.Price >= minimumPrice && drink.Price <= maximumPrice)
                        {
                            itemsToFilter.Add(item);
                        }
                        else
                        {
                            // Check Large Size.
                            drink.Size = Size.Large;
                            if (drink.Price >= minimumPrice && drink.Price <= maximumPrice)
                            {
                                itemsToFilter.Add(item);
                            }
                        }
                    }
                }
            }

            return itemsToFilter;
        }
    }
}

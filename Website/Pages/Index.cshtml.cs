/*
 * Author: William Raymann.
 * Class: Index.
 * Purpose: To display the CowboyCafe menu and manage data going to and from the user.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using System.ComponentModel;

namespace Website.Pages
{
    /// <summary>
    /// Logic and data for the Index.cshtml page in the Cowboy Cafe Website.
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The logger for the Index.cshtml page in the Cowboy Cafe Website.
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Stores the flavors for the Jerked Soda in the Cowboy Cafe.
        /// </summary>
        public SodaFlavor[] SodaFlavors { get; } = { SodaFlavor.BirchBeer, SodaFlavor.CreamSoda, SodaFlavor.OrangeSoda,
                                                     SodaFlavor.RootBeer, SodaFlavor.Sarsaparilla};

        /// <summary>
        /// Stores the menu items that should be displayed on the page.
        /// </summary>
        public IEnumerable<IOrderItem> MenuItemsToDisplay { get; protected set; }
        
        /// <summary>
        /// Stores the text that items must contain at least a part of to be 
        /// displayed on the page.
        /// </summary>
        public string Keywords { get; protected set; }

        /// <summary>
        /// Stores the different categories of Cowboy Cafe menu items.
        /// </summary>
        public string[] Categories = new string[] { "Entree", "Side", "Drink"};

        /// <summary>
        /// Stores the categories we are searching for.
        /// </summary>
        public List<string> SearchCategories { get; protected set; } = new List<string>() { "Entree", "Side", "Drink" };
        
        /// <summary>
        /// Stores the minimum calories an item must have to be displayed on the page.
        /// </summary>
        public uint? MinimumCalories { get; protected set; }
        
        /// <summary>
        /// Stores the maximum calories an item must have to be displayed on the page.
        /// </summary>
        public uint? MaximumCalories { get; protected set; }
        
        /// <summary>
        /// Stores the minimum price an item must have to be displayed on the page.
        /// </summary>
        public double? MinimumPrice { get; protected set; }
        
        /// <summary>
        /// Stores the maximum price an item must have to be displayed on the page.
        /// </summary>
        public double? MaximumPrice { get; protected set; }

        /// <summary>
        /// The constructor for the Index.cshtml page in the Cowboy Cafe Website.
        /// </summary>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            MenuItemsToDisplay = Menu.All;
        }

        /// <summary>
        /// Decides which menu items should be displayed given the passed search parameters.
        /// </summary>
        public void OnGet(string Keywords, List<string> SearchCategories,
                          uint? MinimumCalories, uint? MaximumCalories, double? MinimumPrice, double? MaximumPrice)
        {
            // Use the value of each passed parameter to update their corresponding properties in this class.
            this.Keywords = Keywords;
            this.SearchCategories = SearchCategories;
            this.MinimumCalories = MinimumCalories;
            this.MaximumCalories = MaximumCalories;
            this.MinimumPrice = MinimumPrice;
            this.MaximumPrice = MaximumPrice;
            
            // Filter Cowboy Cafe Menu with LINQ.

            // Filter by Keywords.
            if (Keywords != null)
            {
                MenuItemsToDisplay = from item in MenuItemsToDisplay
                                     where item.ToString().Contains(Keywords,
                                     StringComparison.InvariantCultureIgnoreCase)
                                     select item;
            }

            // Filter by SearchCategories.
            if (SearchCategories != null && SearchCategories.Count != 0)
            {
                MenuItemsToDisplay = from item in MenuItemsToDisplay
                                     where (((item is Entree) && (SearchCategories.Contains("Entree"))) ||
                                     ((item is Side) && (SearchCategories.Contains("Side"))) ||
                                     ((item is Drink) && (SearchCategories.Contains("Drink"))))
                                     select item;
            }

            // Filter by MaximumCalories.
            if (MaximumCalories != null)
            {
                MenuItemsToDisplay = from item in MenuItemsToDisplay
                                     where ((item is Entree) && ((item as Entree).Calories <= MaximumCalories)) ||
                                     ((item is Side) && ((item as Side).Calories <= MaximumCalories)) ||
                                     ((item is Drink) && ((item as Drink).Calories <= MaximumCalories))
                                     select item;
            }

            // I want to be able to include a Side or Drink item is any of its sizes are within the
            // calorie and price ranges. So, I need to get a list of all the items in MenuItemsToDisplay
            // that also has instances of every Side or Drink item in MenuItemsToDisplay to represent
            // the three different possible sizes. The function call below accomplishes this.

            MenuItemsToDisplay = AddInstancesForMissingSideAndDrinkSizes(MenuItemsToDisplay);
            

            // Filter by MinimumCalories.
            if (MinimumCalories != null)
            {
                MenuItemsToDisplay = from item in MenuItemsToDisplay
                                     where ((item is Entree) && ((item as Entree).Calories >= MinimumCalories)) ||
                                     ((item is Side) && ((item as Side).Calories >= MinimumCalories)) ||
                                     ((item is Drink) && ((item as Drink).Calories >= MinimumCalories))
                                     select item;
            }

            // Filter by MaximumPrice.
            if (MaximumPrice != null)
            {
                MenuItemsToDisplay = from item in MenuItemsToDisplay
                                     where ((item is Entree) && ((item as Entree).Price <= MaximumPrice)) ||
                                     ((item is Side) && ((item as Side).Price <= MaximumPrice)) ||
                                     ((item is Drink) && ((item as Drink).Price <= MaximumPrice))
                                     select item;
            }

            // Filter by MinimumPrice.
            if (MinimumPrice != null)
            {
                MenuItemsToDisplay = from item in MenuItemsToDisplay
                                     where ((item is Entree) && ((item as Entree).Price >= MinimumPrice)) ||
                                     ((item is Side) && ((item as Side).Price >= MinimumPrice)) ||
                                     ((item is Drink) && ((item as Drink).Price >= MinimumPrice))
                                     select item;
            }

            // Remove any duplicate items in MenuItemsToDisplay.
            MenuItemsToDisplay = RemoveDuplicates(MenuItemsToDisplay);


            /* Filter Cowboy Cafe Menu with static Menu class functions.
            // Call the static Menu class function that will remove all items that do not containe
            // at least a part of Keywords from MenuItemsToDisplay.
            MenuItemsToDisplay = Menu.FilterMenuItemsByKeywords(MenuItemsToDisplay, Keywords);

            // Generate a list of menu item categories that should not appear on the search display.
            List<string> removeCategories = new List<string>() { "Entree", "Side", "Drink" };

            if (SearchCategories.Count == 0) removeCategories = new List<string>();
            else
            {
                if (SearchCategories.Contains("Entree")) removeCategories.Remove("Entree");
                if (SearchCategories.Contains("Side")) removeCategories.Remove("Side");
                if (SearchCategories.Contains("Drink")) removeCategories.Remove("Drink");
            }
            
            // Call the static Menu class function that will remove all items in SearchCategories from
            // MenuItemsToDisplay.
            MenuItemsToDisplay = Menu.FilterMenuItemsByCategory(MenuItemsToDisplay, removeCategories);
            
            // Call the static Menu class function that will remove all items from MenuItemsToDisplay that
            // have a calorie count outside of the min and max calorie range.
            MenuItemsToDisplay = Menu.FilterMenuItemsByCalories(MenuItemsToDisplay, MinimumCalories, MaximumCalories);
            
            // Call the static Menu class function that will remove all items from MenuItemsToDisplay that
            // have a price outside of the min and max price range.
            MenuItemsToDisplay = Menu.FilterMenuItemsByPrice(MenuItemsToDisplay, MinimumPrice, MaximumPrice);
            */
        }

        /// <summary>
        /// Returns a list of items that are identical to the passed list of items but also adds instances of Side and
        /// Drink items in the passed list to ensure that all the different sizes of Side and Drink items in the passed
        /// list are represented by an instance.
        /// </summary>
        /// <param name="menuItemsToDisplay">The original list of items.</param>
        /// <returns>A list of items identical to the original list of items but with added Side and Drink instances
        /// to ensure that all Side and Drink item sizes are represented in the list.</returns>
        public IEnumerable<IOrderItem> AddInstancesForMissingSideAndDrinkSizes(IEnumerable<IOrderItem> menuItemsToDisplay)
        {
            // Create a List<IOrderItem> of the items in MenuItemsToDisplay.
            List<IOrderItem> displayMenuItems = new List<IOrderItem>();

            foreach(IOrderItem item in menuItemsToDisplay)
            {
                displayMenuItems.Add(item);
            }

            // Make sure that type of Side and Drink item in displayMenuItems has an instance for each
            // possible size (large, medium, and small).
            for (int index = 0; index < displayMenuItems.Count; ++index)
            {
                // Create variables for storing whether a Side or Drink item from displayMenuItems has instances of
                // its type in displayMenuItems for each possible size.
                bool hasLargeSizeInstance = false;
                bool hasMediumSizeInstance = false;
                bool hasSmallSizeInstance = false;

                if (displayMenuItems[index] is Side side)
                {
                    // Find all the different sizes of the current type of side that are
                    // represented in the displayMenuItems.
                    Type sideType = side.GetType();

                    foreach(IOrderItem item in displayMenuItems)
                    {
                        if (item.GetType() == sideType)
                        {
                            switch((item as Side).Size)
                            {
                                case Size.Large:
                                    hasLargeSizeInstance = true;
                                    break;
                                case Size.Medium:
                                    hasMediumSizeInstance = true;
                                    break;
                                case Size.Small:
                                    hasSmallSizeInstance = true;
                                    break;
                                default:
                                    throw new NotImplementedException("Unidenified type of CowboyCafe.Data.Size.");
                            }
                        }
                    }

                    // Now add instances of the type of the current side for any unrepresented sizes.
                    // Add a instance of the same type as the current side but with a large size if there is
                    // no instance of the same type as the current side with a large size.
                    if (!hasLargeSizeInstance)
                    {
                        if (side is BakedBeans)
                        {
                            var beans = new BakedBeans();
                            beans.Size = Size.Large;
                            displayMenuItems.Add(beans);
                        }
                        if (side is ChiliCheeseFries)
                        {
                            var fries = new ChiliCheeseFries();
                            fries.Size = Size.Large;
                            displayMenuItems.Add(fries);
                        }
                        if (side is CornDodgers)
                        {
                            var dodgers = new CornDodgers();
                            dodgers.Size = Size.Large;
                            displayMenuItems.Add(dodgers);
                        }
                        if (side is PanDeCampo)
                        {
                            var campo = new PanDeCampo();
                            campo.Size = Size.Large;
                            displayMenuItems.Add(campo);
                        }
                    }

                    // Add a instance of the same type as the current side but with a medium size if there is
                    // no instance of the same type as the current side with a medium size.
                    if (!hasMediumSizeInstance)
                    {
                        if (side is BakedBeans)
                        {
                            var beans = new BakedBeans();
                            beans.Size = Size.Medium;
                            displayMenuItems.Add(beans);
                        }
                        if (side is ChiliCheeseFries)
                        {
                            var fries = new ChiliCheeseFries();
                            fries.Size = Size.Medium;
                            displayMenuItems.Add(fries);
                        }
                        if (side is CornDodgers)
                        {
                            var dodgers = new CornDodgers();
                            dodgers.Size = Size.Medium;
                            displayMenuItems.Add(dodgers);
                        }
                        if (side is PanDeCampo)
                        {
                            var campo = new PanDeCampo();
                            campo.Size = Size.Medium;
                            displayMenuItems.Add(campo);
                        }
                    }

                    // Add a instance of the same type as the current side but with a small size if there is
                    // no instance of the same type as the current side with a small size.
                    if (!hasSmallSizeInstance)
                    {
                        if (side is BakedBeans)
                        {
                            var beans = new BakedBeans();
                            beans.Size = Size.Small;
                            displayMenuItems.Add(beans);
                        }
                        if (side is ChiliCheeseFries)
                        {
                            var fries = new ChiliCheeseFries();
                            fries.Size = Size.Small;
                            displayMenuItems.Add(fries);
                        }
                        if (side is CornDodgers)
                        {
                            var dodgers = new CornDodgers();
                            dodgers.Size = Size.Small;
                            displayMenuItems.Add(dodgers);
                        }
                        if (side is PanDeCampo)
                        {
                            var campo = new PanDeCampo();
                            campo.Size = Size.Small;
                            displayMenuItems.Add(campo);
                        }
                    }
                }  // End of handling menu item as a drink.
                else if (displayMenuItems[index] is Drink drink)
                {
                    // Find all the different sizes of the current type of drink that are
                    // represented in the displayMenuItems.
                    Type sideType = drink.GetType();

                    foreach (IOrderItem item in displayMenuItems)
                    {
                        if (item.GetType() == sideType)
                        {
                            switch ((item as Drink).Size)
                            {
                                case Size.Large:
                                    hasLargeSizeInstance = true;
                                    break;
                                case Size.Medium:
                                    hasMediumSizeInstance = true;
                                    break;
                                case Size.Small:
                                    hasSmallSizeInstance = true;
                                    break;
                                default:
                                    throw new NotImplementedException("Unidenified type of CowboyCafe.Data.Size.");
                            }
                        }
                    }

                    // Now add instances of the type of the current drink for any unrepresented sizes.
                    // Add a instance of the same type as the current drink but with a large size if there is
                    // no instance of the same type as the current drink with a large size.
                    if (!hasLargeSizeInstance)
                    {
                        if (drink is CowboyCoffee)
                        {
                            var coffee = new CowboyCoffee();
                            coffee.Size = Size.Large;
                            displayMenuItems.Add(coffee);
                        }
                        if (drink is JerkedSoda)
                        {
                            var soda = new JerkedSoda();
                            soda.Size = Size.Large;
                            displayMenuItems.Add(soda);
                        }
                        if (drink is TexasTea)
                        {
                            var tea = new TexasTea();
                            tea.Size = Size.Large;
                            displayMenuItems.Add(tea);
                        }
                        if (drink is Water)
                        {
                            var water = new Water();
                            water.Size = Size.Large;
                            displayMenuItems.Add(water);
                        }
                    }

                    // Add a instance of the same type as the current drink but with a medium size if there is
                    // no instance of the same type as the current drink with a medium size.
                    if (!hasMediumSizeInstance)
                    {
                        if (drink is CowboyCoffee)
                        {
                            var coffee = new CowboyCoffee();
                            coffee.Size = Size.Medium;
                            displayMenuItems.Add(coffee);
                        }
                        if (drink is JerkedSoda)
                        {
                            var soda = new JerkedSoda();
                            soda.Size = Size.Medium;
                            displayMenuItems.Add(soda);
                        }
                        if (drink is TexasTea)
                        {
                            var tea = new TexasTea();
                            tea.Size = Size.Medium;
                            displayMenuItems.Add(tea);
                        }
                        if (drink is Water)
                        {
                            var water = new Water();
                            water.Size = Size.Medium;
                            displayMenuItems.Add(water);
                        }
                    }

                    // Add a instance of the same type as the current drink but with a small size if there is
                    // no instance of the same type as the current drink with a small size.
                    if (!hasSmallSizeInstance)
                    {
                        if (drink is CowboyCoffee)
                        {
                            var coffee = new CowboyCoffee();
                            coffee.Size = Size.Small;
                            displayMenuItems.Add(coffee);
                        }
                        if (drink is JerkedSoda)
                        {
                            var soda = new JerkedSoda();
                            soda.Size = Size.Small;
                            displayMenuItems.Add(soda);
                        }
                        if (drink is TexasTea)
                        {
                            var tea = new TexasTea();
                            tea.Size = Size.Small;
                            displayMenuItems.Add(tea);
                        }
                        if (drink is Water)
                        {
                            var water = new Water();
                            water.Size = Size.Small;
                            displayMenuItems.Add(water);
                        }
                    }
                }  // End of handling menu item as a drink.
            }  // End looping through all the items in displayMenuItems

            return displayMenuItems;
        }

        /// <summary>
        /// Removes any duplicate items in the passed list of items.
        /// </summary>
        /// <param name="menuItemsToDisplay">The original list of items.</param>
        /// <returns>The original list of items but without any duplicates.</returns>
        public IEnumerable<IOrderItem> RemoveDuplicates(IEnumerable<IOrderItem> menuItemsToDisplay)
        {
            // Create a List<IOrderItem> of the items in MenuItemsToDisplay.
            List<IOrderItem> displayMenuItems = new List<IOrderItem>();

            foreach (IOrderItem item in menuItemsToDisplay)
            {
                displayMenuItems.Add(item);
            }

            // Loop through each item in the list and remove any duplicates that
            // come after the current item.
            for(int index = 0; index < displayMenuItems.Count; ++index)
            {
                Type itemType = displayMenuItems[index].GetType();

                //throw new Exception("Type Detected = " + displayMenuItems.GetType());

                // Remove any items that come after the current item and are of the same type.
                for(int index2 = index + 1; index2 < displayMenuItems.Count; ++index2)
                {
                    if (displayMenuItems[index2].GetType() == itemType)
                    {
                        displayMenuItems.Remove(displayMenuItems[index2]);
                        --index2;
                    }
                }
            }

            return displayMenuItems;
        }
    }
}

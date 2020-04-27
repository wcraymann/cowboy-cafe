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
            
        }
    }
}

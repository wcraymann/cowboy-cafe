/*
 * Author: William Raymann.
 * Class: Menu.
 * Purpose: To proved functionality for aquiring the items that go on a Cowboy Cafe menu.
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
        /// Returns an IEnumeration of the IOrderItems that belong to the Entree class of menu items in
        /// the Cowboy Cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            var list = new List<IOrderItem>()
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };

            return list as IEnumerable<IOrderItem>;
        }

        /// <summary>
        /// Returns an IEnumeration of the IOrderItems that belong to the Side class of menu items in
        /// the Cowboy Cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            var list = new List<IOrderItem>()
            {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()
            };

            return list as IEnumerable<IOrderItem>;
        }

        /// <summary>
        /// Returns an IEnumeration of the IOrderItems that belong to the Entree class of menu items in
        /// the Cowboy Cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var list = new List<IOrderItem>()
            {
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };

            return list as IEnumerable<IOrderItem>;
        }

        /// <summary>
        /// Returns an IEnumeration of the IOrderItems that include every item in the Cowboy Cafe.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            var list = new List<IOrderItem>()
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

            return list as IEnumerable<IOrderItem>;
        }
    }
}

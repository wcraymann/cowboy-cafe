/*
 * Author: William Raymann.
 * Class: MenuItemSelectionControl.xaml.
 * Purpose: To display the order items with buttons, add them to 
 *          the current order when their corresponding buttons are 
 *          clicked, and to make the OrderControl display the customization
 *          screen for the selected order item..
 */          
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds the selected item to the current order and 
        /// swaps the screen to the customization screen for
        /// the order item just added.
        /// </summary>
        /// <param name="sender">The clicked button.</param>
        /// <param name="args"></param>
        void OnAddOrderItemButtonClicked(object sender, RoutedEventArgs args)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var newChili = new CowpokeChili();
                            var chiliScreen = new CowpokeChiliCustomization();
                            chiliScreen.DataContext = newChili;
                            order.Add(newChili);
                            orderControl?.SwapScreen(chiliScreen);
                            break;
                        case "AngryChicken":
                            var newChicken = new AngryChicken();
                            var chickenScreen = new AngryChickenCustomization();
                            chickenScreen.DataContext = newChicken;
                            order.Add(newChicken);
                            orderControl?.SwapScreen(chickenScreen);
                            break;
                        case "RustlersRibs":
                            var newRibs = new RustlersRibs();
                            var ribsScreen = new RustlersRibsCustomization();
                           ribsScreen.DataContext = newRibs;
                            order.Add(newRibs);
                            orderControl?.SwapScreen(ribsScreen);
                            break;
                        case "PecosPulledPork":
                            var newPork = new PecosPulledPork();
                            var porkScreen = new PecosPulledPorkCustomization();
                            porkScreen.DataContext = newPork;
                            order.Add(newPork);
                            orderControl?.SwapScreen(porkScreen);
                            break;
                        case "TrailBurger":
                            var newTrail = new TrailBurger();
                            var trailScreen = new TrailBurgerCustomization();
                            trailScreen.DataContext = newTrail;
                            order.Add(newTrail);
                            orderControl?.SwapScreen(trailScreen);
                            break;
                        case "DakotaDoubleBurger":
                            var newDakota = new DakotaDoubleBurger();
                            var dakotaScreen = new DakotaDoubleBurgerCustomization();
                            dakotaScreen.DataContext = newDakota;
                            order.Add(newDakota);
                            orderControl?.SwapScreen(dakotaScreen);
                            break;
                        case "TexasTripleBurger":
                            var newTriple = new TexasTripleBurger();
                            var tripleScreen = new TexasTripleBurgerCustomization();
                            tripleScreen.DataContext = newTriple;
                            order.Add(newTriple);
                            orderControl?.SwapScreen(tripleScreen);
                            break;
                        case "ChiliCheeseFries":
                            var newFries = new ChiliCheeseFries();
                            var friesScreen = new ChiliCheeseFriesCustomization();
                            friesScreen.DataContext = newFries;

                            // Check the appropriate size radio button on the friesScreen.
                            switch (newFries.Size)
                            {
                                case CowboyCafe.Data.Size.Large:
                                    friesScreen.SizeLarge.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Medium:
                                    friesScreen.SizeMedium.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Small:
                                    friesScreen.SizeSmall.IsChecked = true;
                                    break;
                            }

                            order.Add(newFries);
                            orderControl?.SwapScreen(friesScreen);
                            break;
                        case "CornDodgers":
                            var newDodgers = new CornDodgers();
                            var dodgersScreen = new CornDodgersCustomization();
                            dodgersScreen.DataContext = newDodgers;

                            // Check the appropriate size radio button on the dodgersScreen.
                            switch (newDodgers.Size)
                            {
                                case CowboyCafe.Data.Size.Large:
                                    dodgersScreen.SizeLarge.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Medium:
                                    dodgersScreen.SizeMedium.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Small:
                                    dodgersScreen.SizeSmall.IsChecked = true;
                                    break;
                            }

                            order.Add(newDodgers);
                            orderControl?.SwapScreen(dodgersScreen);
                            break;
                        case "PanDeCampo":
                            var newCampo = new PanDeCampo();
                            var campoScreen = new PanDeCampoCustomization();
                            campoScreen.DataContext = newCampo;

                            // Check the appropriate size radio button on the camposScreen.
                            switch (newCampo.Size)
                            {
                                case CowboyCafe.Data.Size.Large:
                                    campoScreen.SizeLarge.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Medium:
                                    campoScreen.SizeMedium.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Small:
                                    campoScreen.SizeSmall.IsChecked = true;
                                    break;
                            }

                            order.Add(newCampo);
                            orderControl?.SwapScreen(campoScreen);
                            break;
                        case "BakedBeans":
                            var newBeans = new BakedBeans();
                            var beanScreen = new BakedBeansCustomization();
                            beanScreen.DataContext = newBeans;

                            // Check the appropriate size radio button on the bakedBeansScreen.
                            switch (newBeans.Size)
                            {
                                case CowboyCafe.Data.Size.Large:
                                    beanScreen.SizeLarge.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Medium:
                                    beanScreen.SizeMedium.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Small:
                                    beanScreen.SizeSmall.IsChecked = true;
                                    break;
                            }

                            order.Add(newBeans);
                            orderControl?.SwapScreen(beanScreen);
                            break;
                        case "JerkedSoda":
                            var newSoda = new JerkedSoda();
                            var sodaScreen = new JerkedSodaCustomization();
                            sodaScreen.DataContext = newSoda;

                            // Check the appropriate flavor radio button on the sodaScreen.
                            switch (newSoda.Flavor)
                            {
                                case CowboyCafe.Data.SodaFlavor.CreamSoda:
                                    sodaScreen.FlavorCreamSoda.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.SodaFlavor.OrangeSoda:
                                    sodaScreen.FlavorCreamSoda.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.SodaFlavor.Sarsaparilla:
                                    sodaScreen.FlavorSarsaparilla.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.SodaFlavor.BirchBeer:
                                    sodaScreen.FlavorBirchBeer.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.SodaFlavor.RootBeer:
                                    sodaScreen.FlavorRootBeer.IsChecked = true;
                                    break;
                                default:
                                    throw new NotImplementedException("Unknown Flavor");
                            }

                            // Check the appropriate size radio button on the sodaScreen.
                            switch (newSoda.Size)
                            {
                                case CowboyCafe.Data.Size.Large:
                                    sodaScreen.SizeLarge.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Medium:
                                    sodaScreen.SizeMedium.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Small:
                                    sodaScreen.SizeSmall.IsChecked = true;
                                    break;
                                default:
                                    throw new NotImplementedException("Unknown Size");
                            }

                            order.Add(newSoda);
                            orderControl?.SwapScreen(sodaScreen);
                            break;
                        case "TexasTea":
                            var newTea = new TexasTea();
                            var teaScreen = new TexasTeaCustomization();
                            teaScreen.DataContext = newTea;

                            // Check the appropriate size radio button on the texasTeaScreen.
                            switch (newTea.Size)
                            {
                                case CowboyCafe.Data.Size.Large:
                                    teaScreen.SizeLarge.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Medium:
                                    teaScreen.SizeMedium.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Small:
                                    teaScreen.SizeSmall.IsChecked = true;
                                    break;
                                default:
                                    throw new NotImplementedException("Unknown Size");
                            }

                            order.Add(newTea);
                            orderControl?.SwapScreen(teaScreen);
                            break;
                        case "CowboyCoffee":
                            var newCoffee = new CowboyCoffee();
                            var coffeeScreen = new CowboyCoffeeCustomization();
                            coffeeScreen.DataContext = newCoffee;

                            // Check the appropriate size radio button on the coffeeScreen.
                            switch (newCoffee.Size)
                            {
                                case CowboyCafe.Data.Size.Large:
                                    coffeeScreen.SizeLarge.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Medium:
                                    coffeeScreen.SizeMedium.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Small:
                                    coffeeScreen.SizeSmall.IsChecked = true;
                                    break;
                                default:
                                    throw new NotImplementedException("Unknown Size");
                            }

                            order.Add(newCoffee);
                            orderControl?.SwapScreen(coffeeScreen);
                            break;
                        case "Water":
                            var newWater = new Water();
                            var waterScreen = new WaterCustomization();
                            waterScreen.DataContext = newWater;

                            // Check the appropriate size radio button on the waterScreen.
                            switch (newWater.Size)
                            {
                                case CowboyCafe.Data.Size.Large:
                                    waterScreen.SizeLarge.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Medium:
                                    waterScreen.SizeMedium.IsChecked = true;
                                    break;
                                case CowboyCafe.Data.Size.Small:
                                    waterScreen.SizeSmall.IsChecked = true;
                                    break;
                                default:
                                    throw new NotImplementedException("Unknown Size");
                            }

                            order.Add(newWater);
                            orderControl?.SwapScreen(waterScreen);
                            break;
                    }
                }
            }
        }
    }
}

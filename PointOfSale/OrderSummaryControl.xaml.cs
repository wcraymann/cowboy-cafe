/*
 * Author: William Raymann.
 * Class: OrderSummary.xaml.
 * Purpose: To provide a summary of the current order on the display, to allow the 
 *          user to select an item to modify, and to allow the user to delete an item.
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
using System.Windows.Markup;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Replaces the MenuItemSelectionControl in the OrderControl parent
        /// with a customization screen of the selected ListBox's DataContext
        /// thus allowing the user to edit previously added order items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (sender as ListBox).SelectedItem;
            var orderControl = this.FindAncestor<OrderControl>();
            
            // Replace the MenuItemSelectionControl with a customization screen
            // that matches the object type of the DataContext of the selectedItem
            // and set the customization screen's DataContext to the DataContext
            // of the selectedItem.
            if (selectedItem is AngryChicken angryChickenItem)
            {
                var angryChickenScreen = new AngryChickenCustomization();
                angryChickenScreen.DataContext = angryChickenItem;
                orderControl?.SwapScreen(angryChickenScreen);
            }
            else if (selectedItem is BakedBeans bakedBeansItem)
            {
                var bakedBeansScreen = new BakedBeansCustomization();
                bakedBeansScreen.DataContext = bakedBeansItem;

                // Check the appropriate size radio button on the bakedBeansScreen.
                switch ((selectedItem as BakedBeans).Size)
                {
                    case CowboyCafe.Data.Size.Large:
                        bakedBeansScreen.SizeLarge.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        bakedBeansScreen.SizeMedium.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Small:
                        bakedBeansScreen.SizeSmall.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

                orderControl?.SwapScreen(bakedBeansScreen);
            }
            else if (selectedItem is ChiliCheeseFries chiliCheeseFriesItem)
            {
                var chiliCheeseFriesScreen = new ChiliCheeseFriesCustomization();
                chiliCheeseFriesScreen.DataContext = chiliCheeseFriesItem;


                // Check the appropriate size radio button on the chiliCheeseFriesScreen.
                switch ((selectedItem as ChiliCheeseFries).Size)
                {
                    case CowboyCafe.Data.Size.Large:
                        chiliCheeseFriesScreen.SizeLarge.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        chiliCheeseFriesScreen.SizeMedium.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Small:
                        chiliCheeseFriesScreen.SizeSmall.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

                orderControl?.SwapScreen(chiliCheeseFriesScreen);
            }
            else if (selectedItem is CornDodgers cornDodgersItem)
            {
                var cornDodgersScreen = new CornDodgersCustomization();
                cornDodgersScreen.DataContext = cornDodgersItem;

                // Check the appropriate size radio button on the cornDodgersScreen.
                switch ((selectedItem as CornDodgers).Size)
                {
                    case CowboyCafe.Data.Size.Large:
                        cornDodgersScreen.SizeLarge.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        cornDodgersScreen.SizeMedium.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Small:
                        cornDodgersScreen.SizeSmall.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

                orderControl?.SwapScreen(cornDodgersScreen);
            }
            else if (selectedItem is CowboyCoffee cowboyCoffeeItem)
            {
                var cowboyCoffeeScreen = new CowboyCoffeeCustomization();
                cowboyCoffeeScreen.DataContext = cowboyCoffeeItem;

                // Check the appropriate size radio button on the cowboyCoffeeScreen.
                switch ((selectedItem as CowboyCoffee).Size)
                {
                    case CowboyCafe.Data.Size.Large:
                        cowboyCoffeeScreen.SizeLarge.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        cowboyCoffeeScreen.SizeMedium.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Small:
                        cowboyCoffeeScreen.SizeSmall.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

                orderControl?.SwapScreen(cowboyCoffeeScreen);
            }
            else if (selectedItem is CowpokeChili cowpokeChiliItem)
            {
                var cowpokeChiliScreen = new CowpokeChiliCustomization();
                cowpokeChiliScreen.DataContext = cowpokeChiliItem;
                orderControl?.SwapScreen(cowpokeChiliScreen);
            }
            else if (selectedItem is DakotaDoubleBurger dakotaDoubleBurgerItem)
            {
                var dakotaDoubleBurgerScreen = new DakotaDoubleBurgerCustomization();
                dakotaDoubleBurgerScreen.DataContext = dakotaDoubleBurgerItem;
                orderControl?.SwapScreen(dakotaDoubleBurgerScreen);
            }
            else if (selectedItem is JerkedSoda jerkedSodaItem)
            {
                var jerkedSodaScreen = new JerkedSodaCustomization();
                jerkedSodaScreen.DataContext = jerkedSodaItem;

                // Check the appropriate flavor radio button on the jerkedSodaScreen.
                switch ((selectedItem as JerkedSoda).Flavor)
                {
                    case CowboyCafe.Data.SodaFlavor.CreamSoda:
                        jerkedSodaScreen.FlavorCreamSoda.IsChecked = true;
                        break;
                    case CowboyCafe.Data.SodaFlavor.OrangeSoda:
                        jerkedSodaScreen.FlavorCreamSoda.IsChecked = true;
                        break;
                    case CowboyCafe.Data.SodaFlavor.Sarsaparilla:
                        jerkedSodaScreen.FlavorSarsaparilla.IsChecked = true;
                        break;
                    case CowboyCafe.Data.SodaFlavor.BirchBeer:
                        jerkedSodaScreen.FlavorBirchBeer.IsChecked = true;
                        break;
                    case CowboyCafe.Data.SodaFlavor.RootBeer:
                        jerkedSodaScreen.FlavorRootBeer.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Flavor");
                }

                // Check the appropriate size radio button on the jerkedSodaScreen.
                switch ((selectedItem as JerkedSoda).Size)
                {
                    case CowboyCafe.Data.Size.Large:
                        jerkedSodaScreen.SizeLarge.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        jerkedSodaScreen.SizeMedium.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Small:
                        jerkedSodaScreen.SizeSmall.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

                orderControl?.SwapScreen(jerkedSodaScreen);
            }
            else if (selectedItem is PanDeCampo panDeCampoItem)
            {
                var panDeCampoScreen = new PanDeCampoCustomization();
                panDeCampoScreen.DataContext = panDeCampoItem;

                // Check the appropriate size radio button on the panDeCampoScreen.
                switch ((selectedItem as PanDeCampo).Size)
                {
                    case CowboyCafe.Data.Size.Large:
                        panDeCampoScreen.SizeLarge.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        panDeCampoScreen.SizeMedium.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Small:
                        panDeCampoScreen.SizeSmall.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

                orderControl?.SwapScreen(panDeCampoScreen);
            }
            else if (selectedItem is PecosPulledPork pecosPulledPorkItem)
            {
                var pecosPulledPorkScreen = new PecosPulledPorkCustomization();
                pecosPulledPorkScreen.DataContext = pecosPulledPorkItem;
                orderControl?.SwapScreen(pecosPulledPorkScreen);
            }
            else if (selectedItem is RustlersRibs rustlersRibsItem)
            {
                var rustlersRibsScreen = new RustlersRibsCustomization();
                rustlersRibsScreen.DataContext = rustlersRibsItem;
                orderControl?.SwapScreen(rustlersRibsScreen);
            }
            else if (selectedItem is TexasTea texasTeaItem)
            {
                var texasTeaScreen = new TexasTeaCustomization();
                texasTeaScreen.DataContext = texasTeaItem;

                // Check the appropriate size radio button on the texasTeaScreen.
                switch ((selectedItem as TexasTea).Size)
                {
                    case CowboyCafe.Data.Size.Large:
                        texasTeaScreen.SizeLarge.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        texasTeaScreen.SizeMedium.IsChecked = true;
                        break;
                    case CowboyCafe.Data.Size.Small:
                        texasTeaScreen.SizeSmall.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }

                orderControl?.SwapScreen(texasTeaScreen);
            }
            else if (selectedItem is TexasTripleBurger texasTripleBurgerItem)
            {
                var texasTripleBurgerScreen = new TexasTripleBurgerCustomization();
                texasTripleBurgerScreen.DataContext = texasTripleBurgerItem;
                orderControl?.SwapScreen(texasTripleBurgerScreen);
            }
            else if (selectedItem is TrailBurger trailBurgerItem)
            {
                var trailBurgerScreen = new TrailBurgerCustomization();
                trailBurgerScreen.DataContext = trailBurgerItem;
                orderControl?.SwapScreen(trailBurgerScreen);
            }
            else if (selectedItem is Water waterItem)
            {
                var waterScreen = new WaterCustomization();
                waterScreen.DataContext = waterItem;

                // Check the appropriate size radio button on the waterScreen.
                switch ((selectedItem as Water).Size)
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

                orderControl?.SwapScreen(waterScreen);
            }

        }

        /// <summary>
        /// Finds the parent OrderControl of the calling button and
        /// swaps its current MenuItemSelectionControl/Customization
        /// screen with a new MenuItemSelectionControl screen.
        /// Then it finds the parent ListBox for the calling Button
        /// and removes the DataContext of the calling Button
        /// (which is an IOrderItem) from the DataContext
        /// of the parent ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDeleteItem(object sender, RoutedEventArgs e)
        {
            // Find the parent OrderControl and swap its MenuItemSelectionControl/
            // Customization screen with a new MenuItemSelectionControl.
            var orderControlParent = (sender as Button).FindAncestor<OrderControl>();
            var newMenu = new MenuItemSelectionControl();

            orderControlParent.SwapScreen(newMenu);

            // Find the parent listBox and remove the calling Button's DataContext
            // from the parent listBox's DataContext.
            var listBoxParent = (sender as Button).FindAncestor<ListBox>();

            ((Order)listBoxParent.DataContext).Remove(((sender as Button).DataContext as IOrderItem));
        }
    }
}

/*
 * Author: William Raymann.
 * Class: JerkedSodaCustomization.xaml.
 * Purpose: To provide the controls to customize the current Jerked Soda
 *          item in the current order.
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

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the flavor of the current Jerked Soda item in the order to 
        /// the flavor selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JerkedSodaFlavorSelect(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Cream Soda":
                    ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
                    break;
                case "Orange Soda":
                    ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;
                    break;
                case "Sarsaparilla":
                    ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.Sarsaparilla;
                    break;
                case "Birch Beer":
                    ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;
                    break;
                case "Root Beer":
                    ((JerkedSoda)DataContext).Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;
                    break;
            }
        }

        /// <summary>
        /// Sets the size of the current Jerked Soda item in the order to 
        /// the size selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JerkedSodaSizeSelect(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Large":
                    ((JerkedSoda)DataContext).Size = CowboyCafe.Data.Size.Large;
                    break;
                case "Medium":
                    ((JerkedSoda)DataContext).Size = CowboyCafe.Data.Size.Medium;
                    break;
                case "Small":
                    ((JerkedSoda)DataContext).Size = CowboyCafe.Data.Size.Small;
                    break;
            }
        }
    }
}

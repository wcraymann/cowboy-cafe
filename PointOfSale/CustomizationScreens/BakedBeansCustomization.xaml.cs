/*
 * Author: William Raymann.
 * Class: BakedBeansCustomization.xaml.
 * Purpose: To provide the controls to customize the current Baked Beans 
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
    /// Interaction logic for BakedBeansCustomization.xaml
    /// </summary>
    public partial class BakedBeansCustomization : UserControl
    {
        public BakedBeansCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the size of the current Baked Beans item in the order to 
        /// the size selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BakedBeansSizeSelect(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Large":
                    ((BakedBeans)DataContext).Size = CowboyCafe.Data.Size.Large;
                    break;
                case "Medium":
                    ((BakedBeans)DataContext).Size = CowboyCafe.Data.Size.Medium;
                    break;
                case "Small":
                    ((BakedBeans)DataContext).Size = CowboyCafe.Data.Size.Small;
                    break;
            }
        }
    }
}

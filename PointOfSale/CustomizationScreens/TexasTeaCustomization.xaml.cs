/*
 * Author: William Raymann.
 * Class: TexasTeaCustomization.xaml.
 * Purpose: To provide the controls to customize the current Texas Tea
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
    /// Interaction logic for TexasTeaCustomization.xaml
    /// </summary>
    public partial class TexasTeaCustomization : UserControl
    {
        public TexasTeaCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the size of the current Texas Tea item in the order to 
        /// the size selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TexasTeaSizeSelect(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Large":
                    ((TexasTea)DataContext).Size = CowboyCafe.Data.Size.Large;
                    break;
                case "Medium":
                    ((TexasTea)DataContext).Size = CowboyCafe.Data.Size.Medium;
                    break;
                case "Small":
                    ((TexasTea)DataContext).Size = CowboyCafe.Data.Size.Small;
                    break;
            }
        }
    }
}

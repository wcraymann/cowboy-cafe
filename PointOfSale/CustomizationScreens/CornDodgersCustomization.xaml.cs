/*
 * Author: William Raymann.
 * Class: CornDodgersCustomization.xaml.
 * Purpose: To provide the controls to customize the current Corn Dodgers
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
    /// Interaction logic for CornDodgersCustomization.xaml
    /// </summary>
    public partial class CornDodgersCustomization : UserControl
    {
        public CornDodgersCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the size of the current Corn Dodgers item in the order to 
        /// the size selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CornDodgersSizeSelect(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Large":
                    ((CornDodgers)DataContext).Size = CowboyCafe.Data.Size.Large;
                    break;
                case "Medium":
                    ((CornDodgers)DataContext).Size = CowboyCafe.Data.Size.Medium;
                    break;
                case "Small":
                    ((CornDodgers)DataContext).Size = CowboyCafe.Data.Size.Small;
                    break;
            }
        }
    }
}

/*
 * Author: William Raymann.
 * Class: PanDeCampoCustomization.xaml.
 * Purpose: To provide the controls to customize the current Pan De Campo
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
    /// Interaction logic for PandDeCampoCustomization.xaml
    /// </summary>
    public partial class PanDeCampoCustomization : UserControl
    {
        public PanDeCampoCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the size of the current Pan De Campo item in the order to 
        /// the size selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanDeCampoSizeSelect(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Large":
                    ((PanDeCampo)DataContext).Size = CowboyCafe.Data.Size.Large;
                    break;
                case "Medium":
                    ((PanDeCampo)DataContext).Size = CowboyCafe.Data.Size.Medium;
                    break;
                case "Small":
                    ((PanDeCampo)DataContext).Size = CowboyCafe.Data.Size.Small;
                    break;
            }
        }
    }
}

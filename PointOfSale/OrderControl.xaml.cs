/*
 * Author: William Raymann.
 * Class: MenuItemSelectionControl.xaml.
 * Purpose: To display the order items with buttons, a summary of
 *          the order, and a customization screen when an order item
 *          is added to the order.
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Swaps the screen back to the MenuItemSelectionConrol from
        /// whichever order item customization control is currently
        /// being displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Cancels the current order, creates a new order, and swaps the 
        /// screen to the MenuItemSelectionControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Completes the current order, creates a new order, and
        /// swaps the screen to the MenuItemSelectionControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Swaps the main portion of the screen (the area occupied
        /// by either MenuItemSelectionControl or an order item
        /// customization control) to the passed FrameworkElement.
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}

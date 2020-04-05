/*
 * Author: William Raymann.
 * Class: GiveChangeToCustomerControl.
 * Prupose: To create a WPF control to allow the cashier to record the money the 
 *          customer pays as payment.
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CollectCashFromCustomerControl.xaml
    /// </summary>
    public partial class CollectCashFromCustomerControl : UserControl
    {
        /// <summary>
        /// Creates a WPF control for accepting cash payment from the customer.
        /// </summary>
        public CollectCashFromCustomerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swaps the screen to the GiveChangeToCustomerControl when the "Proceed"
        /// button is pressed if the Background of the button is LightGreen. Otherwise,
        /// the user is not allowed to swap the screen.
        /// </summary>
        /// <param name="sender">The "Proceed" button.</param>
        /// <param name="e">Information about pressing the "Next" button.</param>
        public void OnNextStep(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Background == Brushes.LightGreen)
            {
                var parent = this.FindAncestor<MainWindow>();

                parent.SwapCollectCashFromCustomerControlAndGiveChangeToCustomerControl();
            }
            
        }

        /// <summary>
        /// Swaps the screen to the OrderTransactionControl when the "Back" 
        /// button is pressed.
        /// </summary>
        /// <param name="sender">The "Back" button.</param>
        /// <param name="e">Information about pressing the "Back" button.</param>
        public void OnBackStep(object sender, RoutedEventArgs e)
        {
            var parent = this.FindAncestor<MainWindow>();

            parent.SwapTransactionControlAndCollectCashFromCustomerControl();
        }
    }
}

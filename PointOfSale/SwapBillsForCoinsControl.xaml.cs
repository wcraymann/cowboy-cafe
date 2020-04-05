/*
 * Author: William Raymann.
 * Class: SwapBillsForCoinsControl.
 * Purpose: To allow the cashier to swap bills for coins in the register drawer.
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
    /// Interaction logic for SwapBillsForCoinsControl.xaml
    /// </summary>
    public partial class SwapBillsForCoinsControl : UserControl
    {
        /// <summary>
        /// Creates a WPF control to allow the cashier to swap bills for coins in the register drawer.
        /// </summary>
        public SwapBillsForCoinsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swaps the screen back to the GiveChangeToCustomerControl.
        /// </summary>
        /// <param name="sender">The "Done" button.</param>
        /// <param name="e">Information about pressing the "Done" button.</param>
        public void OnDoneSwapping(object sender, RoutedEventArgs e)
        {
            var parent = this.FindAncestor<MainWindow>();

            parent.SwapGiveChangeToCustomerControlAndBillToCoinSwapControl();
        }
    }
}

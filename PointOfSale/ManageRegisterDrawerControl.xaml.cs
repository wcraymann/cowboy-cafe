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
    /// Interaction logic for ManageRegisterDrawerControl.xaml
    /// </summary>
    public partial class ManageRegisterDrawerControl : UserControl
    {
        /// <summary>
        /// Creates a WPF control to allow the cashier to record the money the 
        /// customer pays as payment.
        /// </summary>
        public ManageRegisterDrawerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swaps the screen back to the GiveChangeToCustomerControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDoneManaging(object sender, RoutedEventArgs e)
        {
            var parent = this.FindAncestor<MainWindow>();

            parent.SwapGiveChangeToCustomerAndManageRegisterDrawerControl();
        }
    }
}

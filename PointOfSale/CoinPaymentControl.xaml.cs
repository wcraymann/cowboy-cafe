/*
 * Author: William Raymann.
 * Class: CoinPaymentControl.
 * Purpose: To allow the user to add and remove a type of coin from either the 
 *           the Cash Register or from the record of the customers payment.
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinPaymentControl.xaml
    /// </summary>
    public partial class CoinPaymentControl : UserControl
    {
        /// <summary>
        /// Backing variable that stores the type of coin the current control is
        /// managing.
        /// </summary>
        public static readonly DependencyProperty CoinTypeProperty =
            DependencyProperty.Register(
                "CoinType",
                typeof(Coins),
                typeof(CoinPaymentControl),
                new PropertyMetadata(Coins.Penny)
                );

        /// <summary>
        /// Property for getting and setting the CoinTypeProperty.
        /// </summary>
        public Coins CoinType
        {
            get { return (Coins)GetValue(CoinTypeProperty); }
            set { SetValue(CoinTypeProperty, value); }
        }

        /// <summary>
        /// Backing variable that the number of coins the user is paying.
        /// </summary>
        public static readonly DependencyProperty CoinCountProperty =
            DependencyProperty.Register(
                "CoinCount",
                typeof(int),
                typeof(CoinPaymentControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /// <summary>
        /// Property for getting and setting the CoinCountProperty.
        /// </summary>
        public int CoinCount
        {
            get { return (int)GetValue(CoinCountProperty); }
            set { SetValue(CoinCountProperty, value); }
        }

        /// <summary>
        /// Creates a control for any one type of coin in the cash register for the
        /// CowboyCafe project.
        /// </summary>
        public CoinPaymentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increments the coin count when the "+" button is pressed.
        /// </summary>
        /// <param name="sender">The "+" button.</param>
        /// <param name="e">Information about pressing the "+" button.</param>
        public void OnAddCoinToPayment(object sender, RoutedEventArgs e)
        {
            ++CoinCount;
        }

        /// <summary>
        /// Decrements the coin count when the "-" buttton is pressed.
        /// </summary>
        /// <param name="sender">The "-" button.</param>
        /// <param name="e">Information about pressing the "-" button.</param>
        public void OnRemoveCoinToPayment(object sender, RoutedEventArgs e)
        {
            --CoinCount;
        }
    }
}

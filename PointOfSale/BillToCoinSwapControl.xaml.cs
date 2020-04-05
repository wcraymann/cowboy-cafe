/*
 * Author: William Raymann.
 * Class: BillToCoinSwapControl.
 * Purpose: To allow the cashier to swap a type of bill in the register for its equiliant
 *          of a type of coin in the register.
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
    /// Interaction logic for CoinSwapControl.xaml
    /// </summary>
    public partial class BillToCoinSwapControl : UserControl
    {
        /// <summary>
        /// Backing variable to store the type of bill to be swapped for coins.
        /// </summary>
        public static readonly DependencyProperty BillTypeProperty =
            DependencyProperty.Register(
                "BillType",
                typeof(Bills),
                typeof(BillToCoinSwapControl),
                new PropertyMetadata(Bills.One)
                );

        /// <summary>
        /// Property for getting and setting the BillTypeProperty.
        /// </summary>
        public Bills BillType
        {
            get { return  (Bills)GetValue(BillTypeProperty); }
            set { SetValue(BillTypeProperty, value); }
        }

        /// <summary>
        /// Backing variable to store the type of coin to be increased by swapping bills.
        /// </summary>
        public static readonly DependencyProperty CoinTypeProperty =
            DependencyProperty.Register(
                "CoinType",
                typeof(Coins),
                typeof(BillToCoinSwapControl),
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
        /// Backing variable bound to the number of the type of bill to be swapped.
        /// </summary>
        public static readonly DependencyProperty NumOfBillProperty =
            DependencyProperty.Register(
                "NumOfBill",
                typeof(int),
                typeof(BillToCoinSwapControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );

        /// <summary>
        /// Property for getting and setting the NumOfBillProperty.
        /// </summary>
        public int NumOfBill
        {
            get { return (int)GetValue(NumOfBillProperty); }
            set { SetValue(NumOfBillProperty, value); }
        }

        /// <summary>
        /// Backing variable bound to the number of the type of coin that bills
        /// are being swapped for.
        /// </summary>
        public static readonly DependencyProperty NumOfCoinProperty =
            DependencyProperty.Register(
                "NumOfCoin",
                typeof(int),
                typeof(BillToCoinSwapControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );

        /// <summary>
        /// Property for getting and setting the NumOfCoinProperty.
        /// </summary>
        public int NumOfCoin
        {
            get { return (int)GetValue(NumOfCoinProperty); }
            set { SetValue(NumOfCoinProperty, value); }
        }

        /// <summary>
        /// Creates a WPF that allows the user to swap bills for coins.
        /// </summary>
        public BillToCoinSwapControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swaps one of the BillType for its equivalent of CoinType when the 
        /// "Swap" button is pressed.
        /// </summary>
        /// <param name="sender">The "Swap" button.</param>
        /// <param name="e">Information about pressing the "Swap" button.</param>
        public void OnSwapBillForCoins(object sender, RoutedEventArgs e)
        {
            // Create a variable to store how many of CoinType should be added 
            // to the drawer for each dollar.
            int numOfCoinPerDollar;

            // Create a variable to store how may dollars each BillType is worth.
            int numOfDollarsPerBill;

            // Find out how many of CoinType should be added to the drawer for each dollar.
            switch (CoinName.Text)
            {
                case "Penny":
                    numOfCoinPerDollar = 100;
                    break;
                case "Nickel":
                    numOfCoinPerDollar = 20;
                    break;
                case "Dime":
                    numOfCoinPerDollar = 10;
                    break;
                case "Quarter":
                    numOfCoinPerDollar = 4;
                    break;
                case "HalfDollar":
                    numOfCoinPerDollar = 2;
                    break;
                default:
                    throw new FormatException("Misformatted coin name");
            }

            // Find out how many dollars BillType is worth.
            switch (BillName.Text)
            {
                case "Ten":
                    numOfDollarsPerBill = 10;
                    break;
                case "Five":
                    numOfDollarsPerBill = 5;
                    break;
                case "Two":
                    numOfDollarsPerBill = 10;
                    break;
                case "One":
                    numOfDollarsPerBill = 1;
                    break;
                default:
                    throw new FormatException("Misformatted bill name");
            }

            // Update bills and coins.
            if (NumOfBill != 0)
            {
                --NumOfBill;
                NumOfCoin += numOfDollarsPerBill * numOfCoinPerDollar;
            }
            
        }
    }
}

/*
 *Author: William Raymann.
 * Class: BillPaymentControl.
 * Purpose: To allow the user to add and remove a type of bill from either the 
 *          the Cash Register or from the record of the customers payment.
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
    /// Interaction logic for BillPaymentControl.xaml
    /// </summary>
    public partial class BillPaymentControl : UserControl
    {
        /// <summary>
        /// Backing variable that stores the type of bill the current control is
        /// managing.
        /// </summary>
        public static readonly DependencyProperty BillTypeProperty =
            DependencyProperty.Register(
                "BillType",
                typeof(Bills),
                typeof(BillPaymentControl),
                new PropertyMetadata(Bills.One)
                );

        /// <summary>
        /// Property for getting and setting the BillTypeProperty.
        /// </summary>
        public Bills BillType
        {
            get { return (Bills)GetValue(BillTypeProperty); }
            set { SetValue(BillTypeProperty, value); }
        }

        /// <summary>
        /// Backing variable that the number of bills the user is paying.
        /// </summary>
        public static readonly DependencyProperty BillCountProperty =
            DependencyProperty.Register(
                "BillCount",
                typeof(int),
                typeof(BillPaymentControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /// <summary>
        /// Property for getting and setting the BillCountProperty.
        /// </summary>
        public int BillCount
        {
            get { return (int)GetValue(BillCountProperty); }
            set { SetValue(BillCountProperty, value); }
        }

        /// <summary>
        /// Creates a control for any one type of bill in the cash register for the
        /// CowboyCafe project.
        /// </summary>
        public BillPaymentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increments the bill count when the "+" button is pressed.
        /// </summary>
        /// <param name="sender">The "+" button.</param>
        /// <param name="e">Information about pressing the "+" button.</param>
        public void OnAddBillToPayment(object sender, RoutedEventArgs e)
        {
            ++BillCount;
        }

        /// <summary>
        /// Decrements the bill count when the "-" button is pressed.
        /// </summary>
        /// <param name="sender">The "-" button.</param>
        /// <param name="e">Informtion about pressing the "-" button.</param>
        public void OnRemoveBillToPayment(object sender, RoutedEventArgs e)
        {
            --BillCount;
        }
    }
}

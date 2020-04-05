/*
 * Author: William Raymann.
 * Class: OrderTransactionControl.
 * Purpose: A WPF control to control how orders are processed in the Cowboy Cafe.
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderTransactionControl.xaml
    /// </summary>
    public partial class OrderTransactionControl : UserControl
    {
        /// <summary>
        /// Creates a WPF control to control how orders are processed in the Cowboy Cafe.
        /// </summary>
        public OrderTransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Processes the current transaction by using an instance of the
        /// CashRegister.CardTerminal class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnPaymentByCredit(object sender, RoutedEventArgs e)
        { 
            var cardTerminal = new CardTerminal();

            ResultCode result = cardTerminal.ProcessTransaction((DataContext as Order).Subtotal * 1.16);

            // Print receipt and return to OrderControl with new order if
            // the transaction was successful.
            if (result == ResultCode.Success)
            {
                
                // Create the receit as a string.
                string asciiArt = "              /\\    /\\ \n" +
                               "             /  \\  /  \\ \n" +
                               "            /    \\/    \\ \n" +
                               "           /            \\  \n" +
                               "          /              \\ \n" +
                               "-------------------------------------\n" +
                               "          |   (o)   (o)    |\n" +
                               "          |      /\\        |\n" +
                               "          |     /  \\       |\n" +
                               "          \\                /\n" +
                               "           \\  |      |    /\n" +
                               "            \\ \\______/   /\n" +
                               "             \\          /\n" +
                               "              ----------\n" +
                               "    _            |                        \n" +
                               "   /   _         |__                      \n" +
                               "  |   / \\ \\    / |  | \\    /  \\  /    \n" +
                               "  \\_  \\_/  \\/\\/  |__|  \\/\\/    \\/  \n" +
                               "                     _         /          \n" +
                               "          _         / \\                  \n" +
                               "         /    _   _|_    _                \n" +
                               "        |    /_\\   |    /_\\             \n" +
                               "         \\_ /   \\  |    \\_             \n" +
                               "---------------------------------------   \n";

                // Create a string of all the items and special instructions in the order.
                string orderList = "List of Order Items:\n";

                IEnumerator<IOrderItem> orderItems = (DataContext as Order).Items.GetEnumerator();

                if (orderItems.MoveNext())
                {
                    do
                    {
                        orderList += orderItems.Current.Price.ToString("C") + " " + orderItems.Current.ToString() + "\n";

                        // Check to see if there are any special instruction to add.
                        if (orderItems.Current.SpecialInstructions.Count != 0)
                        {
                            // Add the special instructions under the item.
                            foreach (string instruction in orderItems.Current.SpecialInstructions)
                            {
                                orderList += "    >> " + instruction + "\n";
                            }
                        }
                    } while (orderItems.MoveNext());
                }

                string numberDateSubtotalAndTotal = 
                                       $"Order Number: {(DataContext as Order).OrderNumber}\n" +
                                       $"Transaction Date: {DateTime.Now}\n\n" +
                                       $"Subtotal: {(DataContext as Order).Subtotal.ToString("C")}\n" +
                                       $"Total: {(Math.Round((DataContext as Order).Subtotal * 1.16, 2, MidpointRounding.ToZero)).ToString("C")}\n\n";

                // Specify that credit was used in transaction.
                string creditCardUsed = "**-- Order was payed for with credit. --**\n\n";


                // Print a reciet of the transaction.
                ReceiptPrinter rprinter = new ReceiptPrinter();
                rprinter.Print(asciiArt + orderList + numberDateSubtotalAndTotal + creditCardUsed);

                // Prepare the MainWindow for the next order.
                var parent = this.FindAncestor<MainWindow>();

                parent.DataContext = new Order();
                parent.SwapOrderControlAndOrderTransactionControl();

                // Reset the current OrderTransactionControl for the next transaction.
                TransactionCondition.Text = "Transaction Pending";
                TransactionCondition.Foreground = Brushes.LightGreen;
                TransactionConditionBorder.BorderBrush = Brushes.LightGreen;
            }
            // Tell the user what went wrong if the transaction was not successful.
            else
            {
                // Display the error for the user on the current OrderTansactionControl.
                switch(result)
                {
                    case ResultCode.UnknownErrror:
                        TransactionCondition.Text = "Card Terminal Error: Unkown Error";
                        break;
                    case ResultCode.ReadError:
                        TransactionCondition.Text = "Card Terminal Error: Read Error";
                        break;
                    case ResultCode.InsufficentFunds:
                        TransactionCondition.Text = "Card Terminal Error: Insufficent Funds";
                        break;
                    case ResultCode.CancelledCard:
                        TransactionCondition.Text = "Card Terminal Error: Cancelled Card";
                        break;
                    default:
                        throw new NotImplementedException("Unkown CashRegister.ResultCode.");
                }

                TransactionCondition.Foreground = Brushes.Red;
                TransactionConditionBorder.BorderBrush = Brushes.Red;
            }
        }

        /// <summary>
        /// Swaps the screen to CollectCashFromCustomerControl.
        /// </summary>
        /// <param name="sender">The "Payment By Cash" button.</param>
        /// <param name="e">Information about presssing the "Payment By Cash" button.</param>
        public void OnPaymentByCash(object sender, RoutedEventArgs e)
        {
            var parent = this.FindAncestor<MainWindow>();

            parent.SwapTransactionControlAndCollectCashFromCustomerControl();
        }

        /// <summary>
        /// Return to OrderControl with a new order.
        /// </summary>
        /// <param name="sender">The "Cancel Transaction" button.</param>
        /// <param name="e">Infromation about clicking the "Cancel Transaction" button.</param>
        public void OnCancelTransaction(object sender, RoutedEventArgs e)
        {
            // Prepare the MainWindow for the next order.
            var parent = this.FindAncestor<MainWindow>();

            parent.DataContext = new Order();
            parent.SwapOrderControlAndOrderTransactionControl();

            // Reset the current OrderTransactionControl for the next transaction.
            TransactionCondition.Text = "Transaction Pending";
            TransactionCondition.Foreground = Brushes.LightGreen;
            TransactionConditionBorder.BorderBrush = Brushes.LightGreen;
        }
    }
}

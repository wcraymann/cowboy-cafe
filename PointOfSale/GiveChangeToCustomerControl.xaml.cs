/*
 * Author: William Raymann.
 * Class: GiveChangeToCustomerControl.
 * Prupose: To create a WPF control to tell the cashier what change to give
 *          the customer and allows access to controls for managing the contents
 *          of the cash register drawer.
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
using System.Collections.ObjectModel;
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for GiveChangeToCustomerControl.xaml
    /// </summary>
    public partial class GiveChangeToCustomerControl : UserControl
    {
        /// <summary>
        /// Creates a WPF control to tell the cashier what money to give the customer as
        /// change and allows the cashier access to controls to manage the contents of the
        /// cash register drawer.
        /// </summary>
        public GiveChangeToCustomerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swaps the screen back to the OrderTransaction control when the
        /// "Back" button is pressed.
        /// </summary>
        /// <param name="sender">The "Back" button.</param>
        /// <param name="e">Information about pressing the "Back" button.</param>
        public void OnBackAStep(object sender, RoutedEventArgs e)
        {
            var parent = this.FindAncestor<MainWindow>();

            parent.SwapCollectCashFromCustomerControlAndGiveChangeToCustomerControl();
        }

        /// <summary>
        /// Removes the bills and coins required for making change for the customer from
        /// the cash drawer, prints a reciept, and swaps the screen back to the OrderControl for the next
        /// order.
        /// </summary>
        /// <param name="sender">The "Complete Transaction" button.</param>
        /// <param name="e">Information about pressing the "CompleteTransaction" button.</param>
        public void OnCompleteTransaction(object sender, RoutedEventArgs e)
        {
            // Do not proceed if there are not sufficient funds to make change.
            if ((sender as Button).Background == Brushes.Orange) return;

            // Get the MainWindow parent so we can access its DataContext (the current
            // Order) later.
            var parent = this.FindAncestor<MainWindow>();

            // Remove the coins and bills for the customers change from the drawer.
            ObservableCollection<string> changeList = (this.DataContext as ModelViewCashRegister).AppropriateChange;

            if (changeList != null) 
            {
                // Remove the amount of the appropriate bill for each entree in changeList.\
                foreach (string money in changeList)
                {
                    string[] moneyInfo = money.Split(' ');

                    switch (moneyInfo[1])
                    {
                        case "Hundred":
                            (DataContext as ModelViewCashRegister).RemoveBill(Bills.Hundred, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Fifty":
                            (DataContext as ModelViewCashRegister).RemoveBill(Bills.Fifty, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Twenty":
                            (DataContext as ModelViewCashRegister).RemoveBill(Bills.Twenty, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Ten":
                            (DataContext as ModelViewCashRegister).RemoveBill(Bills.Ten, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Five":
                            (DataContext as ModelViewCashRegister).RemoveBill(Bills.Five, Int32.Parse(moneyInfo[0]));
                            break;
                        case "One":
                            (DataContext as ModelViewCashRegister).RemoveBill(Bills.One, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Half":
                            (DataContext as ModelViewCashRegister).RemoveCoin(Coins.HalfDollar, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Quarters":
                            (DataContext as ModelViewCashRegister).RemoveCoin(Coins.Quarter, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Dimes":
                            (DataContext as ModelViewCashRegister).RemoveCoin(Coins.Dime, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Nickels":
                            (DataContext as ModelViewCashRegister).RemoveCoin(Coins.Nickel, Int32.Parse(moneyInfo[0]));
                            break;
                        case "Pennies":
                            (DataContext as ModelViewCashRegister).RemoveCoin(Coins.Penny, Int32.Parse(moneyInfo[0]));
                            break;
                        default:
                            throw new FormatException("Type of money denomination not recognized.");
                    }
                }

                /***--- Print the Reciept ---***/


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

                IEnumerator<IOrderItem> orderItems = (parent.DataContext as Order).Items.GetEnumerator();

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

                // Calculate the total change.
                double totalChange = (DataContext as ModelViewCashRegister).OrderPayment - (DataContext as ModelViewCashRegister).OrderCharge;

                // Make sure that total change is never less than 0.0.
                if (totalChange < 0) totalChange = 0.0;

                string numberDateSubtotalAndTotal =
                                        $"Order Number: {(parent.DataContext as Order).OrderNumber}\n" +
                                        $"Transaction Date: {DateTime.Now}\n\n" +
                                        $"Subtotal: {(parent.DataContext as Order).Subtotal.ToString("C")}\n" +
                                        $"Total: {((parent.DataContext as Order).Subtotal * 1.16).ToString("C")}\n\n" +
                                        $"Change: {totalChange.ToString("C")}\n\n";

                // Print a reciet of the transaction.
                ReceiptPrinter rprinter = new ReceiptPrinter();
                rprinter.Print(asciiArt + orderList + numberDateSubtotalAndTotal);

                // Swap the screen from the current GiveChangeToCustomerControl to the
                // OrderControl screen.
                parent.SwapGiveChangeToCustomerControlForOrderControl();

                // Reset ModelViewCashRegister values for next transaction.
                (DataContext as ModelViewCashRegister).UserPennies = 0;
                (DataContext as ModelViewCashRegister).UserNickels = 0;
                (DataContext as ModelViewCashRegister).UserDimes = 0;
                (DataContext as ModelViewCashRegister).UserQuarters = 0;
                (DataContext as ModelViewCashRegister).UserHalfDollars = 0;
                (DataContext as ModelViewCashRegister).UserDollars = 0;
                (DataContext as ModelViewCashRegister).UserOnes = 0;
                (DataContext as ModelViewCashRegister).UserTwos = 0;
                (DataContext as ModelViewCashRegister).UserFives = 0;
                (DataContext as ModelViewCashRegister).UserTens = 0;
                (DataContext as ModelViewCashRegister).UserTwenties = 0;
                (DataContext as ModelViewCashRegister).UserFifties = 0;
                (DataContext as ModelViewCashRegister).UserHundreds = 0;
            }
        }

        /// <summary>
        /// Swaps the screen to the ManageRegisterDrawerControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnManageMoneyInDrawer(object sender, RoutedEventArgs e)
        {
            var parent = this.FindAncestor<MainWindow>();

            parent.SwapGiveChangeToCustomerAndManageRegisterDrawerControl();
        }

        /// <summary>
        /// Swaps the current GiveChangeToCustomerControl for the BillToCoinSwapControl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSwapBillsAndCoins(object sender, RoutedEventArgs e)
        {
            var parent = this.FindAncestor<MainWindow>();

            parent.SwapGiveChangeToCustomerControlAndBillToCoinSwapControl();
        }
    }
}

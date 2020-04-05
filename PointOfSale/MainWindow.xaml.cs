/*
 * Author: William Raymann.
 * Class: MainWindow.xaml.
 * Purpose: Creates the window that OrderControl is displayed
 *          in for the user and manages which control is displayed
 *          for the user.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using System.Collections;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The Order Control for creating orders.
        /// </summary>
        public OrderControl MainOrderControl;

        /// <summary>
        /// The Transaction Control for controlling how orders are processed.
        /// </summary>
        public OrderTransactionControl MainOrderTransactionControl;

        /// <summary>
        /// The Collect Cash From Customer Control that allows the cashier to record
        /// cash accepted as payment from customer.
        /// </summary>
        public CollectCashFromCustomerControl MainCollectCashFromCustomerControl;

        /// <summary>
        /// The Model View Cash Register Control which acts as an interface between
        /// the CashRegister class and the various controls for finalizing orders.
        /// </summary>
        public ModelViewCashRegister MainModelViewCashRegister;

        /// <summary>
        /// The Give Change To Customer Control that tells the user what change to give
        /// and allows the user to access controls for managing the money currently in the
        /// cash drawer.
        /// </summary>
        public GiveChangeToCustomerControl MainGiveChangeToCustomerControl;

        /// <summary>
        /// The Swap Bills For Coins Control that allows the user to substitute bills for
        /// coins in the register drawer.
        /// </summary>
        public SwapBillsForCoinsControl MainSwapBillsForCoinsControl;

        /// <summary>
        /// The Manage Register Drawer Control that allows the user to record the adding
        /// or removing of money from the register drawer for non-commercial purposes.
        /// </summary>
        public ManageRegisterDrawerControl MainManageRegisterDrawerControl;

        /// <summary>
        /// Constructor for MainWindow.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Create the first order and set the DataContext to that order.
            var data = new Order();

            this.DataContext = data;

            // Initialize MainOrderControl, MainOrderTransactionControl, MainCollectCashFromCustomerControl,
            // MainModelViewCashRegister, MainGiveChangeToCustomerControl, MainSwapBillsForCoinsControl,
            // and MainManageRegisterDrawerControl.
            MainOrderControl = new OrderControl();
            MainOrderTransactionControl = new OrderTransactionControl();
            MainCollectCashFromCustomerControl = new CollectCashFromCustomerControl();
            MainModelViewCashRegister = new ModelViewCashRegister(new CashDrawer());
            MainGiveChangeToCustomerControl = new GiveChangeToCustomerControl();
            MainSwapBillsForCoinsControl = new SwapBillsForCoinsControl();
            MainManageRegisterDrawerControl = new ManageRegisterDrawerControl();

            // Set the DataContext of MainCollectCashFromCustomerControl,
            // MainGiveChangeToCustomerControl,ManageRegisterDrawerControl, 
            // and MainBillToCoinSwapControl to the MainModelViewCashRegister.
            MainCollectCashFromCustomerControl.DataContext = MainModelViewCashRegister;
            MainGiveChangeToCustomerControl.DataContext = MainModelViewCashRegister;
            MainSwapBillsForCoinsControl.DataContext = MainModelViewCashRegister;
            MainManageRegisterDrawerControl.DataContext = MainModelViewCashRegister;


            // Add the orderControl as the child of this window.
            this.Content = MainOrderControl;
        }

        /// <summary>
        /// Swaps the screen between the MainOrderControl and the 
        /// MainOrderTransactionControl.
        /// </summary>
        public void SwapOrderControlAndOrderTransactionControl()
        {
            if (this.Content == MainOrderControl)
            {
                this.Content = MainOrderTransactionControl;
                MainOrderTransactionControl.OrderHeader.Text = $"Order Number {(DataContext as Order).OrderNumber}:";
                MainOrderTransactionControl.OrderSubtotal.Text = $"Order Price = {(DataContext as Order).Subtotal.ToString("C")}";
                MainOrderTransactionControl.OrderTax.Text = $"Order Tax = {((DataContext as Order).Subtotal * 0.16).ToString("C")}";
                MainOrderTransactionControl.OrderTotal.Text = $"Order Total = {((DataContext as Order).Subtotal * 1.16).ToString("C")}";
            }
            else
            {
                this.Content = MainOrderControl;
            }   
        }

        /// <summary>
        /// Swaps the screen between the MainOrderTransactionControl and the 
        /// MainCollectCashFromCustomerControl.
        /// </summary>
        public void SwapTransactionControlAndCollectCashFromCustomerControl()
        {
            if (this.Content == MainOrderTransactionControl)
            {
                MainModelViewCashRegister.OrderCharge = (DataContext as Order).Subtotal * 1.16;
                this.Content = MainCollectCashFromCustomerControl;
            }
            else
            {
                this.Content = MainOrderTransactionControl;
            }
        }

        /// <summary>
        /// Swaps teh screen between the MainCollectCashFromCustomerControl and the
        /// GiveChangeToCustomerControl.
        /// </summary>
        public void SwapCollectCashFromCustomerControlAndGiveChangeToCustomerControl()
        {
            if (this.Content == MainCollectCashFromCustomerControl)
            {
                this.Content = MainGiveChangeToCustomerControl;
            }
            else
            {
                this.Content = MainCollectCashFromCustomerControl;
            }
        }

        /// <summary>
        /// Swaps the current GiveChangeToCustomerControl for the 
        /// MainOrderControl.
        /// </summary>
        public void SwapGiveChangeToCustomerControlForOrderControl()
        {
            this.Content = MainOrderControl;
            this.DataContext = new Order();
        }

        /// <summary>
        /// Swaps the current GiveChangeToCustomerControl and MainBillToCoinSwapControl.
        /// </summary>
        public void SwapGiveChangeToCustomerControlAndBillToCoinSwapControl()
        {
            if (this.Content == MainGiveChangeToCustomerControl)
            {
                this.Content = MainSwapBillsForCoinsControl;
            }
            else
            {
                this.Content = MainGiveChangeToCustomerControl;
            }
        }

        /// <summary>
        /// Swap the current GiveChangeCustomerControl and MainBillToCoinSwapControl.
        /// </summary>
        public void SwapGiveChangeToCustomerAndManageRegisterDrawerControl()
        {
            if (this.Content == MainGiveChangeToCustomerControl)
            {
                this.Content = MainManageRegisterDrawerControl;
            }
            else
            {
                this.Content = MainGiveChangeToCustomerControl;
            }
        }
    }
}

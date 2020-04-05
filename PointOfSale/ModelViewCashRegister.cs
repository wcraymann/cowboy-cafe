/*
 * Author: William Raymann.
 * Class: ModelViewCashRegister.
 * Purpose: To provide an ViewModel for the CashRegister class and Model for the money the
 *          customer pays and other monterary details about the order.
 */
using System;
using System.Collections.Generic;
using System.Text;
using CashRegister;
using System.ComponentModel;
using System.Windows.Media;
using System.Collections.ObjectModel;

namespace PointOfSale
{
    /// <summary>
    /// A class that supports intractions between the user interface and the
    /// cash register of the CowboyCafe project.
    /// </summary>
    public class ModelViewCashRegister : INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in properties in the current class.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores the cash drawer for the Cowboy Cafe project.
        /// </summary>
        public CashDrawer CashDrawer;


        /***--- The following properties track the number of each type of coin in the register ---***/

        /// <summary>
        /// Property for getting and setting the number of Dollars in the register drawer.
        /// </summary>
        public int RegisterDollars
        {
            get { return CashDrawer.Dollars; }
            set
            {
                if (value == CashDrawer.Dollars || value < 0) return;
                int difference = value - CashDrawer.Dollars;
                if (difference > 0) CashDrawer.AddCoin(Coins.Dollar, difference);
                else CashDrawer.RemoveCoin(Coins.Dollar, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Half Dollars in the register drawer.
        /// </summary>
        public int RegisterHalfDollars
        {
            get { return CashDrawer.HalfDollars; }
            set
            {
                if (value == CashDrawer.HalfDollars || value < 0) return;
                int difference = value - CashDrawer.HalfDollars;
                if (difference > 0) CashDrawer.AddCoin(Coins.HalfDollar, difference);
                else CashDrawer.RemoveCoin(Coins.HalfDollar, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Quarters in the register drawer.
        /// </summary>
        public int RegisterQuarters
        {
            get { return CashDrawer.Quarters; }
            set
            {
                if (value == CashDrawer.Quarters || value < 0) return;
                int difference = value - CashDrawer.Quarters;
                if (difference > 0) CashDrawer.AddCoin(Coins.Quarter, difference);
                else CashDrawer.RemoveCoin(Coins.Quarter, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Dimes in the register drawer.
        /// </summary>
        public int RegisterDimes
        {
            get { return CashDrawer.Dimes; }
            set
            {
                if (value == CashDrawer.Dimes || value < 0) return;
                int difference = value - CashDrawer.Dimes;
                if (difference > 0) CashDrawer.AddCoin(Coins.Dime, difference);
                else CashDrawer.RemoveCoin(Coins.Dime, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Nickels in the register drawer.
        /// </summary>
        public int RegisterNickels
        {
            get { return CashDrawer.Nickels; }
            set
            {
                if (value == CashDrawer.Nickels || value < 0) return;
                int difference = value - CashDrawer.Nickels;
                if (difference > 0) CashDrawer.AddCoin(Coins.Nickel, difference);
                else CashDrawer.RemoveCoin(Coins.Nickel, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Pennies in the register drawer.
        /// </summary>
        public int RegisterPennies
        {
            get { return CashDrawer.Pennies; }
            set
            {
                if (value == CashDrawer.Pennies || value < 0) return;
                int difference = value - CashDrawer.Pennies;
                if (difference > 0) CashDrawer.AddCoin(Coins.Penny, difference);
                else CashDrawer.RemoveCoin(Coins.Penny, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /***--- The following properties track the number of each type of bill in the register ---***/

        /// <summary>
        /// Property for getting and setting the number of Ones in the register drawer.
        /// </summary>
        public int RegisterOnes
        {
            get { return CashDrawer.Ones; }
            set
            {
                if (value == CashDrawer.Ones || value < 0) return;
                int difference = value - CashDrawer.Ones;
                if (difference > 0) CashDrawer.AddBill(Bills.One, difference);
                else CashDrawer.RemoveBill(Bills.One, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Twos in the register drawer.
        /// </summary>
        public int RegisterTwos
        {
            get { return CashDrawer.Twos; }
            set
            {
                if (value == CashDrawer.Twos || value < 0) return;
                int difference = value - CashDrawer.Twos;
                if (difference > 0) CashDrawer.AddBill(Bills.Two, difference);
                else CashDrawer.RemoveBill(Bills.Two, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Fives in the register drawer.
        /// </summary>
        public int RegisterFives
        {
            get { return CashDrawer.Fives; }
            set
            {
                if (value == CashDrawer.Fives || value < 0) return;
                int difference = value - CashDrawer.Fives;
                if (difference > 0) CashDrawer.AddBill(Bills.Five, difference);
                else CashDrawer.RemoveBill(Bills.Five, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Tens in the register drawer.
        /// </summary>
        public int RegisterTens
        {
            get { return CashDrawer.Tens; }
            set
            {
                if (value == CashDrawer.Tens || value < 0) return;
                int difference = value - CashDrawer.Tens;
                if (difference > 0) CashDrawer.AddBill(Bills.Ten, difference);
                else CashDrawer.RemoveBill(Bills.Ten, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Twenties in the register drawer.
        /// </summary>
        public int RegisterTwenties
        {
            get { return CashDrawer.Twenties; }
            set
            {
                if (value == CashDrawer.Twenties || value < 0) return;
                int difference = value - CashDrawer.Twenties;
                if (difference > 0) CashDrawer.AddBill(Bills.Twenty, difference);
                else CashDrawer.RemoveBill(Bills.Twenty, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Fifties in the register drawer.
        /// </summary>
        public int RegisterFifties
        {
            get { return CashDrawer.Fifties; }
            set
            {
                if (value == CashDrawer.Fifties || value < 0) return;
                int difference = value - CashDrawer.Fifties;
                if (difference > 0) CashDrawer.AddBill(Bills.Fifty, difference);
                else CashDrawer.RemoveBill(Bills.Fifty, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Property for getting and setting the number of Hundreds in the register drawer.
        /// </summary>
        public int RegisterHundreds
        {
            get { return CashDrawer.Hundreds; }
            set
            {
                if (value == CashDrawer.Hundreds || value < 0) return;
                int difference = value - CashDrawer.Hundreds;
                if (difference > 0) CashDrawer.AddBill(Bills.Hundred, difference);
                else CashDrawer.RemoveBill(Bills.Hundred, -difference);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /***--- The following properties track the number of each type of coin the customer pays ---***/


        private int userPennies = 0;
        /// <summary>
        /// Stores the number of pennies the customer pays.
        /// </summary>
        public int UserPennies
        {
            get { return userPennies; }
            set
            {
                if (value == userPennies || value < 0) return;
                else if (value > userPennies)
                {
                    double appendValue = Math.Round((value - userPennies) * 0.01, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userPennies = value;
                }
                else
                {
                    double removeValue = Math.Round((userPennies - value) * 0.01, 2, MidpointRounding.ToEven);

                    // Updata OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userPennies = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userNickels = 0;
        /// <summary>
        /// Stores the number of nickels the customer pays.
        /// </summary>
        public int UserNickels
        {
            get { return userNickels; }
            set
            {
                if (value == userNickels || value < 0) return;
                else if (value > userNickels)
                {
                    double appendValue = Math.Round((value - userNickels) * 0.05, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userNickels = value;
                }
                else
                {
                    double removeValue = Math.Round((userNickels - value) * 0.05, 2, MidpointRounding.ToEven);

                    // Updata OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userNickels = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userDimes = 0;
        /// <summary>
        /// Stores the number of dimes the customer pays.
        /// </summary>
        public int UserDimes
        {
            get { return userDimes; }
            set
            {
                if (value == userDimes || value < 0) return;
                else if (value > userDimes)
                {
                    double appendValue = Math.Round((value - userDimes) * 0.1, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userDimes = value;
                }
                else
                {
                    double removeValue = Math.Round((userDimes - value) * 0.1, 2, MidpointRounding.ToEven);

                    // Updata OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);


                    userDimes = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userQuarters = 0;
        /// <summary>
        /// Stores the number of quarters the customer pays.
        /// </summary>
        public int UserQuarters
        {
            get { return userQuarters; }
            set
            {
                if (value == userQuarters || value < 0) return;
                else if (value > userQuarters)
                {
                    double appendValue = Math.Round((value - userQuarters) * 0.25, 2, MidpointRounding.AwayFromZero);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.AwayFromZero);

                    userQuarters = value;
                }
                else
                {
                    double removeValue = Math.Round((userQuarters - value) * 0.25, 2, MidpointRounding.ToEven);

                    // Updata OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userQuarters = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userHalfDollars = 0;
        /// <summary>
        /// Stores the number of half dollars the customer pays.
        /// </summary>
        public int UserHalfDollars
        {
            get { return userHalfDollars; }
            set
            {
                if (value == userHalfDollars || value < 0) return;
                else if (value > userHalfDollars)
                {
                    double appendValue = Math.Round((value - userHalfDollars) * 0.5, 2, MidpointRounding.AwayFromZero);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.AwayFromZero);

                    userHalfDollars = value;
                }
                else
                {
                    double removeValue = Math.Round((userHalfDollars - value) * 0.5, 2, MidpointRounding.ToEven);

                    // Updata OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userHalfDollars = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userDollars = 0;
        /// <summary>
        /// Stores the number of dollars the customer pays.
        /// </summary>
        public int UserDollars
        {
            get { return userDollars; }
            set
            {
                if (value == userDollars || value < 0) return;
                else if (value > userDollars)
                {
                    double appendValue = Math.Round((value - userDollars) * 1.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userDollars = value;
                }
                else
                {
                    double removeValue = Math.Round((userDollars - value) * 1.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userDollars = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }


        /***--- The following properties track the number of each type of bill the customer pays ---***/

        private int userOnes = 0;
        /// <summary>
        /// Stores the number of ones the customer pays.
        /// </summary>
        public int UserOnes
        {
            get { return userOnes; }
            set
            {
                if (value == userOnes || value < 0) return;
                else if (value > userOnes)
                {
                    double appendValue = Math.Round((value - userOnes) * 1.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userOnes = value;
                }
                else
                {
                    double removeValue = Math.Round((userOnes - value) * 1.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userOnes = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userTwos = 0;
        /// <summary>
        /// Stores the number of twos the customer pays.
        /// </summary>
        public int UserTwos
        {
            get { return userTwos; }
            set
            {
                if (value == userTwos || value < 0) return;
                else if (value > userTwos)
                {
                    double appendValue = Math.Round((value - userTwos) * 2.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userTwos = value;
                }
                else
                {
                    double removeValue = Math.Round((userTwos - value) * 2.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userTwos = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userFives = 0;
        /// <summary>
        /// Stores the number of fives the customer pays.
        /// </summary>
        public int UserFives
        {
            get { return userFives; }
            set
            {
                if (value == userFives || value < 0) return;
                else if (value > userFives)
                {
                    double appendValue = Math.Round((value - userFives) * 5.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userFives = value;
                }
                else
                {
                    double removeValue = Math.Round((userFives - value) * 5.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userFives = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userTens = 0;
        /// <summary>
        /// Stores the number of Tens the customer pays.
        /// </summary>
        public int UserTens
        {
            get { return userTens; }
            set
            {
                if (value == userTens || value < 0) return;
                else if (value > userTens)
                {
                    double appendValue = Math.Round((value - userTens) * 10.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userTens = value;
                }
                else
                {
                    double removeValue = Math.Round((userTens - value) * 10.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userTens = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userTwenties = 0;
        /// <summary>
        /// Stores the number of twenties the customer pays.
        /// </summary>
        public int UserTwenties
        {
            get { return userTwenties; }
            set
            {
                if (value == userTwenties || value < 0) return;
                else if (value > userTwenties)
                {
                    double appendValue = Math.Round((value - userTwenties) * 20.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userTwenties = value;
                }
                else
                {
                    double removeValue = Math.Round((userTwenties - value) * 20.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userTwenties = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userFifties = 0;
        /// <summary>
        /// Stores the number of fifties the customer pays.
        /// </summary>
        public int UserFifties
        {
            get { return userFifties; }
            set
            {
                if (value == userFifties || value < 0) return;
                else if (value > userFifties)
                {
                    double appendValue = Math.Round((value - userFifties) * 50.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userFifties = value;
                }
                else
                {
                    double removeValue = Math.Round((userFifties - value) * 50.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userFifties = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private int userHundreds = 0;
        /// <summary>
        /// Stores the number of hundreds the customer pays.
        /// </summary>
        public int UserHundreds
        {
            get { return userHundreds; }
            set
            {
                if (value == userHundreds || value < 0) return;
                else if (value > userHundreds)
                {
                    double appendValue = Math.Round((value - userHundreds) *100.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(appendValue + OrderPayment, 2, MidpointRounding.ToEven);

                    userHundreds = value;
                }
                else
                {
                    double removeValue = Math.Round((userHundreds - value) * 100.0, 2, MidpointRounding.ToEven);

                    // Update OrderPayment.
                    OrderPayment = Math.Round(OrderPayment - removeValue, 2, MidpointRounding.ToEven);

                    userHundreds = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
            }
        }

        private double orderCharge = 0.0;
        /// <summary>
        /// Stores the total order change.
        /// </summary>
        public double OrderCharge 
        { 
            get { return orderCharge; }
            set
            {
                if (orderCharge != value)
                {
                    orderCharge = value;
                    if (orderCharge < 0) orderCharge = 0.0;

                    // Update SufficientFundsIndicator and SufficientFundsColor.
                    if ((Math.Abs(OrderPayment - OrderCharge) < 0.001) || (OrderPayment > OrderCharge))
                    {
                        SufficientFundsIndicator = "    Sufficient Funds\nClick Here To Proceed";
                        SufficientFundsColor = Brushes.LightGreen;
                    }
                    else
                    {
                        SufficientFundsIndicator = "Insufficient Funds\n Cannot Proceed";
                        SufficientFundsColor = Brushes.Orange;
                    }

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderCharge"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                }
            }
        }

        private double orderPayment = 0.0;
        /// <summary>
        /// Stores the current payment on the order.
        /// </summary>
        public double OrderPayment 
        { 
            get { return orderPayment; }
            private set
            {
                if (orderPayment != value)
                {
                    orderPayment = value;
                    if (orderPayment < 0) orderPayment = 0.0;

                    // Update SufficientFundsIndicator and SufficientFundsColor.
                    if ((Math.Abs(OrderPayment - OrderCharge) < 0.001) || (OrderPayment > OrderCharge))
                    {
                        SufficientFundsIndicator = "    Sufficient Funds\nClick Here To Proceed";
                        SufficientFundsColor = Brushes.LightGreen;
                    }
                    else
                    {
                        SufficientFundsIndicator = "Insufficient Funds\n Cannot Proceed";
                        SufficientFundsColor = Brushes.Orange;
                    } 

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderPayment"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                }
            }
        }

        private string sufficientFundsIndicator = "    Sufficient Funds\nClick Here To Proceed";
        /// <summary>
        /// Stores a message for the "Proceed" button indicating whether the customer has
        /// payed enough money.
        /// </summary>
        public string SufficientFundsIndicator
        {
            get { return sufficientFundsIndicator; }
            private set
            {
                if (sufficientFundsIndicator == value) return;
                sufficientFundsIndicator = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientFundsIndicator"));
            }
        }

        private SolidColorBrush sufficientFundsColor = Brushes.LightGreen;
        /// <summary>
        /// Stores a color for the "Proceed" button representing whether the customer has
        /// payed enough money.
        /// </summary>
        public SolidColorBrush SufficientFundsColor
        {
            get { return sufficientFundsColor; }
            set
            {
                if (sufficientFundsColor == value) return;
                sufficientFundsColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientFundsColor"));
            }
        }

        private string sufficientChangeIndicator = "Funds Sufficient\nComplete Transaction";
        /// <summary>
        /// Stores a message for the "Complete Transaction" button indicating whether the
        /// drawer has enough money to make change.
        /// </summary>
        public string SufficientChangeIndicator
        {
            get { return sufficientChangeIndicator; }
            private set
            {
                if (sufficientChangeIndicator == value) return;
                sufficientChangeIndicator = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
            }
        }

        private SolidColorBrush sufficientChangeColor = Brushes.LightGreen;
        /// <summary>
        /// Stores a color for the "Complete Transaction" button representing whether the drawer
        /// has enough money to make change.
        /// </summary>
        public SolidColorBrush SufficientChangeColor
        {
            get { return sufficientChangeColor; }
            set
            {
                if (sufficientChangeColor == value) return;
                sufficientChangeColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
            }
        }

        /// <summary>
        /// Returns a list of string describing the number of each type of coin and bill
        /// that needs to be returned as change. It also checks to see if the appropriate
        /// number of bills and coins are available in the cash drawer. If not, it attempts
        /// to substitute the bill or coin type that is lacking with another type. If all
        /// fails, it simply retuns a single string saying that there are insufficient funds
        /// to return the appropriate change.
        /// </summary>
        public ObservableCollection<string> AppropriateChange
        {
            get
            {
                var changeList = new ObservableCollection<string>();

                // Return changeList now if sufficient payment has not been made.
                if (!(Math.Abs(OrderPayment - OrderCharge) < 0.01) && !(OrderPayment > OrderCharge)) return changeList;

                // Declare variable to store the number of each type of bill and coin
                // that will be needed to make change.
                int numOfHundreds = 0;
                int numOfFifties = 0;
                int numOfTwenties = 0;
                int numOfTens = 0;
                int numOfFives = 0;
                int numOfOnes = 0;
                int numOfHalfDollars = 0;
                int numOfQuarters = 0;
                int numOfDimes = 0;
                int numOfNickels = 0;
                int numOfPennies = 0;


                /***--- Determine how many of each type of bill needs to be given as change ---***/

                // Get the total bill portion of the change.
                int totalBillChange = (int)Math.Round((OrderPayment - OrderCharge), 2, MidpointRounding.ToEven);

                // Determine how may hundreds are needed for change if the remaining bill portion of
                // the change is greater than 100.
                if (totalBillChange >= 100)
                {
                    numOfHundreds = (int)((totalBillChange - (totalBillChange % 100)) / 100);

                    // Use the full number of bills if they are available in the drawer.
                    if (CashDrawer.Hundreds >= numOfHundreds)
                    {
                        string hundreds = $"{numOfHundreds} Hundred Dollar Bills";
                        changeList.Add(hundreds);

                        // Update the remaining total.
                        totalBillChange -= totalBillChange - (totalBillChange % 100);
                    }
                    // Otherwise, use as many bills as available.
                    else
                    {
                        string hundreds = $"{CashDrawer.Hundreds} Hundred Dollar Bills";
                        if (CashDrawer.Hundreds != 0) changeList.Add(hundreds);

                        // Update the remaining total.
                        totalBillChange -= CashDrawer.Hundreds * 100;
                    }
                }

                // Determine how may fifties are needed for change if the bill portion of
                // the change is greater than 50.
                if (totalBillChange >= 50)
                {
                    numOfFifties = (int)((totalBillChange - (totalBillChange % 50)) / 50);

                    // Use the full number of bills if they are available in the drawer.
                    if (CashDrawer.Fifties >= numOfFifties)
                    {
                        string fifties = $"{numOfFifties} Fifty Dollar Bills";
                        changeList.Add(fifties);

                        // Update the remaining total.
                        totalBillChange -= totalBillChange - (totalBillChange % 50);
                    }
                    // Otherwise, use as many bills as available.
                    else
                    {
                        string fifties = $"{CashDrawer.Fifties} Fifty Dollar Bills";
                        if (CashDrawer.Fifties != 0) changeList.Add(fifties);

                        // Update the remaining total.
                        totalBillChange -= CashDrawer.Fifties * 50;
                    }
                }

                // Determine how may twenties are needed for change if the remaingin bill portion of
                // the change is greater than 20.
                if (totalBillChange >= 20)
                {
                    numOfTwenties = (int)((totalBillChange - (totalBillChange % 20)) / 20);

                    // Use the full number of bills if they are available in the drawer.
                    if (CashDrawer.Twenties >= numOfTwenties)
                    {
                        string twenties = $"{numOfTwenties} Twenty Dollar Bills";
                        changeList.Add(twenties);

                        // Update the remaining total.
                        totalBillChange -= totalBillChange - (totalBillChange % 20);
                    }
                    // Otherwise, use as many bills as available.
                    else
                    {
                        string twenties = $"{CashDrawer.Twenties} Twenty Dollar Bills";
                        if (CashDrawer.Twenties != 0) changeList.Add(twenties);

                        // Update the remaining total.
                        totalBillChange -= CashDrawer.Twenties * 20;
                    }
                }

                // Determine how may tens are needed for change if the remaingin bill portion 
                // of the change is greater than 10.
                if (totalBillChange >= 10)
                {
                    numOfTens = (int)((totalBillChange - (totalBillChange % 10)) / 10);

                    // Use the full number of bills if they are available in the drawer.
                    if (CashDrawer.Tens >= numOfTens)
                    {
                        string tens = $"{numOfTens} Ten Dollar Bills";
                        changeList.Add(tens);

                        // Update the remaining total.
                        totalBillChange -= totalBillChange - (totalBillChange % 10);
                    }
                    // Otherwise, use as many bills as available.
                    else
                    {
                        string tens = $"{CashDrawer.Tens} Ten Dollar Bills";
                        if (CashDrawer.Tens != 0) changeList.Add(tens);

                        // Update the remaining total.
                        totalBillChange -= CashDrawer.Tens * 10;
                    }
                }

                // Determine how may fives are needed for change if the remaining bill portion of
                // the change is greater than 5.
                if (totalBillChange >= 5)
                {
                    numOfFives = (int)((totalBillChange - (totalBillChange % 5)) / 5);

                    // Use the full number of bills if they are available in the drawer.
                    if (CashDrawer.Fives >= numOfFives)
                    {
                        string fives = $"{numOfFives} Five Dollar Bills";
                        changeList.Add(fives);

                        // Update the remaining total.
                        totalBillChange -= totalBillChange - (totalBillChange % 5);
                    }
                    // Otherwise, use as many bills as available.
                    else
                    {
                        string fives = $"{CashDrawer.Fives} Five Dollar Bills";
                        if (CashDrawer.Fives != 0) changeList.Add(fives);

                        // Update the remaining total.
                        totalBillChange -= CashDrawer.Fives * 5;
                    }
                }

                // Determine how may ones are needed for change if the remaining bill portion of
                // the change is greater than 1.
                if (totalBillChange >= 1)
                {
                    numOfOnes = (int)((totalBillChange - (totalBillChange % 1)) / 1);

                    // Use the full number of bills if they are available in the drawer.
                    if (CashDrawer.Ones >= numOfOnes)
                    {
                        string ones = $"{numOfOnes} One Dollar Bills";
                        changeList.Add(ones);

                        // Update the remaining total.
                        totalBillChange -= totalBillChange - (totalBillChange % 1);
                    }
                    // Otherwise, use as many bills as available.
                    else
                    {
                        string ones = $"{CashDrawer.Ones} One Dollar Bills";
                        if (CashDrawer.Ones != 0) changeList.Add(ones);

                        // Update the remaining total.
                        totalBillChange -= CashDrawer.Ones * 1;
                    }
                }


                /***--- Determine how many of each type of coin are required as change ---***/

                // Get the total change.
                double totalChange = Math.Round(OrderPayment - OrderCharge, 2, MidpointRounding.ToEven);

                // Get the total change covered by bills.
                int totalBillPortion = (int)Math.Round((OrderPayment - OrderCharge), 2, MidpointRounding.ToEven) - totalBillChange;

                // Get the total coint portion of the change
                double totalCoinPortion = Math.Round((totalChange - totalBillPortion), 2, MidpointRounding.ToEven);

                // Convert the total coin portion of the change to an interger that is 100 times
                // the actual change portion.
                int totalCoinChange = (int)( Math.Round(totalCoinPortion * 100, 2, MidpointRounding.ToEven) );

                // Determine how may half dollars are needed for change if the remaining coin portion of
                // the change is greater than 50.
                if (totalCoinChange >= 50)
                {
                    numOfHalfDollars = (int)((totalCoinChange - (totalCoinChange % 50)) / 50);

                    // Use the full number of coins if they are available in the drawer.
                    if (CashDrawer.HalfDollars >= numOfHalfDollars)
                    {
                        string halfDollars = $"{numOfHalfDollars} Half Dollars";
                        changeList.Add(halfDollars);

                        // Update the remaining total.
                        totalCoinChange -= totalCoinChange - (totalCoinChange % 50);
                    }
                    // Otherwise, use as many coins as available.
                    else
                    {
                        string halfDollars = $"{CashDrawer.HalfDollars} Half Dollars";
                        if (CashDrawer.HalfDollars != 0) changeList.Add(halfDollars);

                        // Update the remaining total.
                        totalCoinChange -= CashDrawer.HalfDollars * 50;
                    }
                }

                // Determine how may quarters are needed for change if the remaining coin portion of
                // the change is greater than 25.
                if (totalCoinChange >= 25)
                {
                    numOfQuarters = (int)((totalCoinChange - (totalCoinChange % 25)) / 25);

                    // Use the full number of coins if they are available in the drawer.
                    if (CashDrawer.Quarters >= numOfQuarters)
                    {
                        string quarters = $"{numOfQuarters} Quarters";
                        changeList.Add(quarters);

                        // Update the remaining total.
                        totalCoinChange -= totalCoinChange - (totalCoinChange % 25);
                    }
                    // Otherwise, use as many coins as available.
                    else
                    {
                        string quarters = $"{CashDrawer.Quarters} Quarters";
                        if (CashDrawer.Quarters != 0) changeList.Add(quarters);

                        // Update the remaining total.
                        totalCoinChange -= CashDrawer.Quarters * 25;
                    }
                }

                // Determine how may dimes are needed for change if the remaining coin portion of
                // the change is greater than 10.
                if (totalCoinChange >= 10)
                {
                    numOfDimes = (int)((totalCoinChange - (totalCoinChange % 10)) / 10);

                    // Use the full number of coins if they are available in the drawer.
                    if (CashDrawer.Dimes >= numOfDimes)
                    {
                        string dimes = $"{numOfDimes} Dimes";
                        changeList.Add(dimes);

                        // Update the remaining total.
                        totalCoinChange -= totalCoinChange - (totalCoinChange % 10);
                    }
                    // Otherwise, use as many coins as available.
                    else
                    {
                        string dimes = $"{CashDrawer.Dimes} Dimes";
                        if (CashDrawer.Dimes != 0) changeList.Add(dimes);

                        // Update the remaining total.
                        totalCoinChange -= CashDrawer.Dimes * 10;
                    }
                }

                // Determine how may nickels are needed for change if the remaining coin portion of
                // the change is greater than 5.
                if (totalCoinChange >= 5)
                {
                    numOfNickels = (int)((totalCoinChange - (totalCoinChange % 5)) / 5);

                    // Use the full number of coins if they are available in the drawer.
                    if (CashDrawer.Nickels >= numOfNickels)
                    {
                        string nickels = $"{numOfNickels} Nickels";
                        changeList.Add(nickels);

                        // Update the remaining total.
                        totalCoinChange -= totalCoinChange - (totalCoinChange % 5);
                    }
                    // Otherwise, use as many coins as available.
                    else
                    {
                        string nickels = $"{CashDrawer.Nickels} Nickels";
                        if (CashDrawer.Nickels != 0) changeList.Add(nickels);

                        // Update the remaining total.
                        totalCoinChange -= CashDrawer.Nickels * 5;
                    }
                }

                // Determine how may pennies are needed for change if the remaining coin portion of
                // the change is greater than 1.
                if (totalCoinChange >= 1)
                {
                    numOfPennies = (int)((totalCoinChange - (totalCoinChange % 1)) / 1);

                    // Use the full number of coins if they are available in the drawer.
                    if (CashDrawer.Pennies >= numOfPennies)
                    {
                        string pennies = $"{numOfPennies} Pennies";
                        changeList.Add(pennies);

                        // Update the remaining total.
                        totalCoinChange -= totalCoinChange - (totalCoinChange % 1);
                    }
                    // Otherwise, erase all other entrees in the list and add a entree
                    // stating that there are not sufficient funds to make change.
                    else
                    {
                        // Remove all previous entrees in the change list.
                        for (int index = changeList.Count - 1; index >= 0; --index)
                        {
                            changeList.Remove(changeList[index]);
                        }

                        // Add an entree stating that there are not sufficient funds to make change.
                        changeList.Add("There are Not Sufficient Funds to\nMake Change.");

                        // Update SufficientFundsIndicator and SufficientFundsColor.
                        SufficientChangeIndicator = "Insufficient Funds\n Cannot Proceed";
                        SufficientChangeColor = Brushes.Orange;
                    }
                }

                // Update SufficientFundsIndicator and SufficientFundsColor if changeList
                // does not contain a string stating insufficient funds.
                if ((changeList.Count > 0) && (changeList[0] != "There are Not Sufficient Funds to\nMake Change."))
                {
                    SufficientChangeIndicator = "Funds Sufficient\nComplete Transaction";
                    SufficientChangeColor = Brushes.LightGreen;
                }
                        

                return changeList;
            }
        }

        /// <summary>
        /// Creates a ModelViewCashRegister for handling interactions between the 
        /// user interface and the cash drawer passed as a parameter.
        /// </summary>
        /// <param name="cashDrawer"></param>
        public ModelViewCashRegister(CashDrawer cashDrawer)
        {
            CashDrawer = cashDrawer;
        }

        /// <summary>
        /// Removes the amount of the specified coin from the cash drawer and invokes
        /// the PropertyChanged event handler for the affected properties.
        /// </summary>
        /// <param name="coinType">The type of coin to remove.</param>
        /// <param name="amount">The amount to remove from the coin property.</param>
        public void RemoveCoin(Coins coinType, int amount)
        {
            // Remove the amount of the coin from the cash drawer.
            CashDrawer.RemoveCoin(coinType, amount);

            // Invoke the PropertyChanged event handler for the appropriate type of coin.
            switch (coinType)
            {
                case Coins.Penny:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterPennies"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Coins.Nickel:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterNickels"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Coins.Dime:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterDimes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Coins.Quarter:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterQuarters"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Coins.HalfDollar:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterHalfDollars"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                default:
                    throw new NotImplementedException("Coin type not implemented");
            }
        }

        /// <summary>
        /// Removes the amount of the specified bill from the cash drawer and invokes
        /// the PropertyChanged event handler for the affected properties.
        /// </summary>
        /// <param name="billType">The type of bill to remove.</param>
        /// <param name="amount">The amount to remove from the bill property.</param>
        public void RemoveBill(Bills billType, int amount)
        {
            // Remove the amount of the bill from the cash drawer.
            CashDrawer.RemoveBill(billType, amount);

            // Invoke the PropertyChanged event handler for the appropriate type of bill.
            switch (billType)
            {
                case Bills.One:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterOnes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Bills.Two:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTwos"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Bills.Five:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterFives"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Bills.Ten:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTens"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Bills.Twenty:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTwenties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Bills.Fifty:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterFifties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                case Bills.Hundred:
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterHundreds"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppropriateChange"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeIndicator"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientChangeColor"));
                    break;
                default:
                    throw new NotImplementedException("Coin type not implemented");
            }
        }
    }
}

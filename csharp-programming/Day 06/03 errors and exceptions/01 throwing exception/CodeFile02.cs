using System;

namespace csharp_programming {
    class FundException : ArgumentException {
        public FundException(decimal balance)
            : base("Insufficient funds. Total funds are: " + balance) {
        }
    }

    class Account {
        decimal balance;

        public decimal Balance {
            get { return balance; }
        }

        public void Deposit(decimal amount) {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative");
            balance += amount;
        }

        public void Withdraw(decimal amount) {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative");
            if (amount > balance)
                throw new FundException(balance);
            balance -= amount;
        }
    }

    class Program {
        static Account account = null;

        static void Main() {
            try {
                string input;
                do {
                    Console.Clear();
                    if (account == null)
                        Console.WriteLine("Account: Not Opened.");
                    else {
                        Console.WriteLine("Account: Opened. Balance: {0}", account.Balance);
                    }
                    Console.WriteLine();
                    Console.WriteLine("1. Open New Account.");
                    Console.WriteLine("2. Deposit Money.");
                    Console.WriteLine("3. Withdraw Money.");
                    Console.WriteLine("4. Close Account.");
                    Console.WriteLine("5. Exit.");
                    Console.Write("Enter your choice: ");
                    input = Console.ReadLine();
                    switch (input) {
                        case "1":
                            OpenNewAccount();
                            break;
                        case "2":
                            Console.WriteLine();
                            try {
                                Console.Write("Enter Amount to Deposit: ");
                                input = Console.ReadLine();
                                account.Deposit(Convert.ToDecimal(input));
                            }
                            catch (ArgumentException e) {
                                Console.WriteLine(e.Message);
                            }
                            finally {
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            break;
                        case "3":
                            Console.WriteLine();
                            try {
                                Console.Write("Enter Amount to Withdraw: ");
                                input = Console.ReadLine();
                                account.Withdraw(Convert.ToDecimal(input));
                            }
                            catch (FundException e) {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArgumentException e) {
                                Console.WriteLine(e.Message);
                            }
                            finally {
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            break;
                        case "4":
                            CloseAccount();
                            break;
                        case "5":
                            break;
                        default:
                            Console.WriteLine("Invalid Operation. Press any key to continue...");
                            Console.ReadKey();
                            break;
                    }
                } while (input != "5");
            }
            finally {
                if (account != null)
                    Console.WriteLine("Final Balance: {0}", account.Balance);
                CloseAccount();
            }
        }

        public static void OpenNewAccount() {
            account = new Account();
        }

        public static void CloseAccount() {
            account = null;
        }
    }
}
using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class BankingSystem
    {
        public List<BankAccount> bankAccounts = new List<BankAccount>();

        public void LoginMenu()
        {
            Console.Clear();
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |              WELCOME TO SIMPLE BANKING SYSTEM             |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                      LOGIN TO START                       |");
            Console.WriteLine(" |                                                           |");
            Console.Write(" |   User Name: ");
            int UserNameCursorX = Console.CursorTop;
            int UserNameCursorY = Console.CursorLeft;
            Console.WriteLine("                                             |   ");
            Console.Write(" |   Password: ");
            int PasswordCursorX = Console.CursorTop;
            int PasswordeCursorY = Console.CursorLeft;
            Console.WriteLine("                                              |   ");
            Console.WriteLine(" |___________________________________________________________|");
            Console.SetCursorPosition(UserNameCursorY, UserNameCursorX);
            string username = "";
            username = Console.ReadLine();
            Console.SetCursorPosition(PasswordeCursorY, PasswordCursorX);
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
           
            try
            {
                string[] loginCredentials = File.ReadAllLines("login.txt");
                bool loginSuccessful = false;
                foreach (string loginCredential in loginCredentials)
                {
                    string[] separator = { "|", " " };
                    string[] login = loginCredential.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    if (username.CompareTo(login[0]) == 0 && password.CompareTo(login[1]) == 0)
                    {
                        loginSuccessful = true;
                        Console.WriteLine("\n");
                        Console.WriteLine("\n\n Valid credentials!... Please enter");
                        Console.ReadKey(true);
                        MainMenu();
                        break;
                    }
                    else
                    {
                        loginSuccessful = false;
                    }
                }
                if (!loginSuccessful)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\n\n Invalid credentials!... Please re-enter");
                    Console.ReadKey();
                    LoginMenu();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: login.txt is missing.\n");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
        private void MainMenu()
        {
            ConsoleKey key = 0;
            bool Input = false;
            while (key != ConsoleKey.D7)
            {
                Console.Clear();
                Console.WriteLine(" _____________________________________________________________");
                Console.WriteLine(" |                                                           |");
                Console.WriteLine(" |              WELCOME TO SIMPLE BANKING SYSTEM             |");
                Console.WriteLine(" |___________________________________________________________|");
                Console.WriteLine(" |                                                           |");
                Console.WriteLine(" |    1. Create a new account                                |");
                Console.WriteLine(" |    2. Search for an account                               |");
                Console.WriteLine(" |    3. Deposit                                             |");
                Console.WriteLine(" |    4. Withdraw                                            |");
                Console.WriteLine(" |    5. A/C statement                                       |");
                Console.WriteLine(" |    6. Delete account                                      |");
                Console.WriteLine(" |    7. Exit                                                |");
                Console.WriteLine(" |___________________________________________________________|");
                Console.WriteLine(" |                                                           |");
                Console.Write(" |    Enter your choice (1-7): ");
                int ChoiceCursorX = Console.CursorTop;
                int ChoiceCursorY = Console.CursorLeft;
                Console.WriteLine("                              | ");
                Console.WriteLine(" |___________________________________________________________|");
                Console.WriteLine();
                if (Input)
                {
                    Console.WriteLine("\nInvalid input. Please enter a number between 1 - 7");
                }
                Input = false;
                Console.SetCursorPosition(ChoiceCursorY, ChoiceCursorX);
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        CreateAccount();
                        break;

                    case ConsoleKey.D2:
                        SearchAccount();
                        break;

                    case ConsoleKey.D3:
                        Deposit();
                        break;

                    case ConsoleKey.D4:
                        Withdraw();
                        break;

                    case ConsoleKey.D5:
                        ViewStatement();
                        break;

                    case ConsoleKey.D6:
                        Delete();
                        break;

                    case ConsoleKey.D7:
                        LoginMenu();
                        break;

                    default:
                        Input = true;
                        break;
                }
            } 
        }
     
        private void CreateAccount()
        {
            Console.Clear();
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                   CREATE A NEW ACCOUNT                    |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                    ENTER THE DETAILS                      |");
            Console.WriteLine(" |                                                           |");
            Console.Write(" |    First Name: ");
            int FirstNameCursorX = Console.CursorTop;
            int FirstNameCursorY = Console.CursorLeft;
            Console.WriteLine("                                           | ");
            Console.Write(" |    Last Name: ");
            int LastNameCursorX = Console.CursorTop;
            int LastNameCursorY = Console.CursorLeft;
            Console.WriteLine("                                            | ");
            Console.Write(" |    Address: ");
            int AddressCursorX = Console.CursorTop;
            int AddressCursorY = Console.CursorLeft;
            Console.WriteLine("                                              | ");
            Console.Write(" |    Phone: ");
            int PhoneCursorX = Console.CursorTop;
            int PhoneCursorY = Console.CursorLeft;
            Console.WriteLine("                                                | ");
            Console.Write(" |    Email: ");
            int EmailCursorX = Console.CursorTop;
            int EmailCursorY = Console.CursorLeft;
            Console.WriteLine("                                                | ");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine();
            Console.SetCursorPosition(FirstNameCursorY, FirstNameCursorX);
            string firstName = Console.ReadLine();
            Console.SetCursorPosition(LastNameCursorY, LastNameCursorX);
            string lastName = Console.ReadLine();
            Console.SetCursorPosition(AddressCursorY, AddressCursorX);
            string address = Console.ReadLine();
            Console.SetCursorPosition(PhoneCursorY, PhoneCursorX);
            string phoneNumber = Console.ReadLine();
            Console.SetCursorPosition(EmailCursorY, EmailCursorX);
            string email = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Is the information correct (y/n)? ");
            int ConfirmationCursorX = Console.CursorTop;
            int ConfirmationCursorY = Console.CursorLeft;
            Console.SetCursorPosition(ConfirmationCursorY, ConfirmationCursorX);
            ConsoleKey choice;
            int accountNumber;
            int n;
            bool isNumeric = Int32.TryParse(phoneNumber, out n);
            do
            {
                choice = Console.ReadKey().Key;
                if (choice == ConsoleKey.Y)
                {
                    Console.WriteLine("\n");
                    if (phoneNumber.Length <= 10 && isNumeric)
                    {
                        do
                        {
                            accountNumber = new Random().Next(100000, 99999999);
                        } while (File.Exists($"{accountNumber}.txt"));
                        BankAccount newAccount = new BankAccount(accountNumber, 0, firstName, lastName, address, phoneNumber, email);
                        if (newAccount.IsValidEmail(email))
                        {
                            Console.WriteLine("Please wait while the email is being sent");
                            newAccount.SendEmail();
                            bankAccounts.Add(newAccount);
                            newAccount.UpdateFile(TransactionType.Deposit, 0, false);
                            Console.WriteLine("\n");
                            Console.WriteLine("Account Created! details will be provided via email.\n");
                            Console.WriteLine($"Account number is: {accountNumber}");
                            Console.WriteLine("Press any key to go back to the main menu");
                            Console.ReadKey();
                            MainMenu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid email address.");
                            Console.ReadKey();
                            CreateAccount();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid phone number.");
                        Console.ReadKey();
                        CreateAccount();
                    }
                }
                else
                {
                    CreateAccount();
                    break;
                }
            } while (choice != ConsoleKey.Y || choice != ConsoleKey.N);
            Console.ReadKey(true);
        }

        private void SearchAccount()
        {
            Console.Clear();
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     SEARCH AN ACCOUNT                     |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     ENTER THE DETAILS                     |");
            Console.WriteLine(" |                                                           |");
            Console.Write(" |    Account Number: ");
            int ACNumberCursorX = Console.CursorTop;
            int ACNumberCursorY = Console.CursorLeft;
            Console.WriteLine("                                       | ");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine("\n");
            Console.SetCursorPosition(ACNumberCursorY, ACNumberCursorX);
            string accountNumber = Console.ReadLine();
            if (accountNumber.Length <= 10 && File.Exists($"{accountNumber}.txt"))
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount found!");
                FindAccount(Convert.ToInt32(accountNumber)).AccountDetails();
                Console.Write("Check another account (y/n)? ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    SearchAccount();
                }
                else if (key == ConsoleKey.N)
                {
                    MainMenu();
                }
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount not found!");
                Console.Write("Check another account (y/n)? ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    SearchAccount();
                }
                else if (key == ConsoleKey.N)
                {
                    MainMenu();
                }

            }
        }

        private void Deposit()
        {
            Console.Clear();
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                          DEPOSIT                          |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     ENTER THE DETAILS                     |");
            Console.WriteLine(" |                                                           |");
            Console.Write(" |    Account Number: ");
            int ACNumberCursorX = Console.CursorTop;
            int ACNumberCursorY = Console.CursorLeft;
            Console.WriteLine("                                       | ");
            Console.Write(" |    Amount: $");
            int AmountCursorX = Console.CursorTop;
            int AmountCursorY = Console.CursorLeft;
            Console.WriteLine("                                              | ");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine("\n");
            Console.SetCursorPosition(ACNumberCursorY, ACNumberCursorX);
            string accountNumber = Console.ReadLine();
            
            if (accountNumber.Length <= 10 && File.Exists($"{accountNumber}.txt"))
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount found! Enter the amount...");
                Console.SetCursorPosition(AmountCursorY, AmountCursorX);
                int deposit = Convert.ToInt32(Console.ReadLine());
                FindAccount(Convert.ToInt32(accountNumber)).Deposit(deposit);
                Console.WriteLine("\n");
                Console.Write("\nDeposit successful! ");
                Console.WriteLine("\nPress any key to go back to the main menu");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount not found!");
                Console.Write("Retry (y/n)? ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    Deposit();
                }
                else if (key == ConsoleKey.N)
                {
                    MainMenu();
                }
            }
            Console.ReadKey();
        }

        private void Withdraw()
        {
            Console.Clear();
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                         WITHDRAW                          |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     ENTER THE DETAILS                     |");
            Console.WriteLine(" |                                                           |");
            Console.Write(" |    Account Number: ");
            int ACNumberCursorX = Console.CursorTop;
            int ACNumberCursorY = Console.CursorLeft;
            Console.WriteLine("                                       | ");
            Console.Write(" |    Amount: $");
            int AmountCursorX = Console.CursorTop;
            int AmountCursorY = Console.CursorLeft;
            Console.WriteLine("                                              | ");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine("\n");
            Console.SetCursorPosition(ACNumberCursorY, ACNumberCursorX);
            string accountNumber = Console.ReadLine();
            if (accountNumber.Length <= 10 && File.Exists($"{accountNumber}.txt"))
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount found! Enter the amount...");
                Console.SetCursorPosition(AmountCursorY, AmountCursorX);
                int withdraw = Convert.ToInt32(Console.ReadLine());
                bool flag = FindAccount(Convert.ToInt32(accountNumber)).Withdraw(withdraw);
                if (flag)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\nWithdraw successful! ");
                    Console.WriteLine("\nPress any key to go back to the main menu");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\nThe balance is not sufficient for withdrawal");
                    Console.Write("Retry (y/n)? ");
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.Y)
                    {
                        Withdraw();
                    }
                    else if (key == ConsoleKey.N)
                    {
                        MainMenu();
                    }
                }

            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount not found!");
                Console.Write("Retry (y/n)? ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    Withdraw();
                }
                else if (key == ConsoleKey.N)
                {
                    MainMenu();
                }
            }
            Console.ReadKey();
        }

        private void ViewStatement()
        {
            Console.Clear();
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                         STATEMENT                         |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     ENTER THE DETAILS                     |");
            Console.WriteLine(" |                                                           |");
            Console.Write(" |    Account Number: ");
            int ACNumberCursorX = Console.CursorTop;
            int ACNumberCursorY = Console.CursorLeft;
            Console.WriteLine("                                       | ");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine("\n");
            Console.SetCursorPosition(ACNumberCursorY, ACNumberCursorX);
            string accountNumber = Console.ReadLine();
            if (accountNumber.Length <= 10 && File.Exists($"{accountNumber}.txt"))
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount found! The statement is displayed below...");
                BankAccount account = FindAccount(Convert.ToInt32(accountNumber));
                Console.WriteLine("\n");
                account.displayStatement();
                Console.WriteLine("\n");
                Console.Write("Email statement (y/n)? ");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Y)
                {
                    Console.WriteLine("\nPlease wait while the email is being sent");
                    account.SendStatement();
                    Console.WriteLine("\n");
                    Console.WriteLine("Email sent successfully!...");
                    Console.WriteLine("\nPress any key to go back to the main menu");
                }
                else if (key == ConsoleKey.N)
                {
                    MainMenu();
                }
                
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount not found!");
                Console.Write("Retry (y/n)? ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    ViewStatement();
                }
                else if (key == ConsoleKey.N)
                {
                    MainMenu();
                }
            }
            Console.ReadKey();
        }

        private void Delete()
        {
            Console.Clear();
            Console.WriteLine(" _____________________________________________________________");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     DELETE AN ACCOUNT                     |");
            Console.WriteLine(" |___________________________________________________________|");
            Console.WriteLine(" |                                                           |");
            Console.WriteLine(" |                     ENTER THE DETAILS                     |");
            Console.WriteLine(" |                                                           |");
            Console.Write(" |    Account Number: ");
            int ACNumberCursorX = Console.CursorTop;
            int ACNumberCursorY = Console.CursorLeft;
            Console.WriteLine("                                       | ");
            Console.WriteLine(" |___________________________________________________________|");
            Console.SetCursorPosition(ACNumberCursorY, ACNumberCursorX);
            string accountNumber = Console.ReadLine();
            if (accountNumber.Length <= 10 && File.Exists($"{accountNumber}.txt"))
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount found! Details displayed below...");
                Console.WriteLine("\n");
                FindAccount(Convert.ToInt32(accountNumber)).AccountDetails();
                Console.WriteLine("\n");
                Console.Write("Delete(y/n)? ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    Console.WriteLine("\n");
                    bankAccounts.Remove(FindAccount(Convert.ToInt32(accountNumber)));
                    File.Delete($"{accountNumber}.txt");
                    Console.WriteLine("Account Deleted!...");
                    Console.WriteLine("\nPress any key to go back to the main menu");
                }
                else if (key == ConsoleKey.N)
                {
                    MainMenu();
                }
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nAccount not found!");
                Console.Write("Retry (y/n)? ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    Delete();
                }
                else if (key == ConsoleKey.N)
                {
                    MainMenu();
                }
            }
            Console.ReadKey();
        }

        private BankAccount FindAccount(int accountNumber)
        {
            foreach (BankAccount account in bankAccounts)
            {
                if (account.HasNumber(accountNumber))
                    return account;
            }
            return null;
        }
    }


}

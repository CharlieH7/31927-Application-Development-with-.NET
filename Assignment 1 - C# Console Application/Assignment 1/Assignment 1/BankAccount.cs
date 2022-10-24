using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Assignment1
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }
    public class BankAccount
    {
        private string firstName, lastName, phoneNumber, address, email;
        private int accountNumber;
        private double balance;
        public List<string> transactions = new List<String>();
        DateTime dateTime = DateTime.Today;

        public BankAccount(int accountNumber, double balance, string firstName, string lastName,
                           string address, string phoneNumber, string email)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            TransactionType type = TransactionType.Deposit;
            String transactionType = "";
            if (type == TransactionType.Deposit)
            {
                transactionType = "Deposit";
            }
            String t = dateTime.ToString("dd.MM.yyyy") + "|" + transactionType + "|" + amount.ToString() + "|" + balance.ToString() + "\n";
            transactions.Add(t);
            UpdateFile(type, amount, true);
          
        }

        public bool Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                TransactionType type = TransactionType.Withdrawal;
                String transactionType = "";
                if (type == TransactionType.Withdrawal)
                {
                    transactionType = "Withdraw";
                }
                String t = dateTime.ToString("dd.MM.yyyy") + "|" + transactionType + "|" + amount.ToString() + "|" + balance.ToString() + "\n";
                transactions.Add(t);
                UpdateFile(type, amount, true);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateFile(TransactionType type, double amount, bool status)
        {
            if (status)
            {
                DateTime dateTime = DateTime.Today;
                String transactions = "";
                foreach (String s in this.transactions)
                {
                    transactions += s;
                }
                File.WriteAllText(string.Format($"{accountNumber}.txt"),
                                  string.Format($"First Name|{firstName}\nLast Name|{lastName}\nAddress|{address}\nPhone|{phoneNumber}\n" +
                                                $"Email|{email}\nAccountNo|{accountNumber}\nBalance|{balance}\n{transactions}"));
            }
            else
            {
                File.WriteAllText(string.Format($"{accountNumber}.txt"),
                                  string.Format($"First Name|{firstName}\nLast Name|{lastName}\nAddress|{address}\nPhone|{phoneNumber}\n" +
                                                $"Email|{email}\nAccountNo|{accountNumber}\nBalance|{balance}\n"));
            }

        }

        // Check email format
        public bool IsValidEmail(string email)
        {
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        // Sends email
        public void SendEmail()
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("hope91824@gmail.com", "ovlyxzxibvjgpctt");
            smtpClient.EnableSsl = true;
            MailMessage message = new MailMessage(new MailAddress("hope91824@gmail.com", "Simple Banking System"), new MailAddress(email));
            message.IsBodyHtml = true;
            message.Subject = "Welcome to Simple Bank";
            message.Body = "Dear User,<br><br>"
                         + "Your account details are as follows:<br>"
                        + $"Account number: {accountNumber}<br>"
                        + $"First name: {firstName}<br>"
                        + $"Last name: {lastName}<br>"
                        + $"Address: {address}<br>"
                        + $"Phone number: {phoneNumber}<br>"
                        + $"Email: {email}<br><br>"
                        + "Kind regards,<br><br>"
                        + "Simple Banking System";
            smtpClient.Send(message);
        }

        public void SendStatement()
        {
            String transactions = "";
            foreach (String s in this.transactions)
            {
                transactions += s;
            }
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("hope91824@gmail.com", "ovlyxzxibvjgpctt");
            smtpClient.EnableSsl = true;
            MailMessage message = new MailMessage(new MailAddress("hope91824@gmail.com", "Simple Banking System"), new MailAddress(email));
            message.IsBodyHtml = true;
            message.Subject = "Welcome to Simple Bank";
            message.Body = "Dear User,<br><br>"
                         + "Your account details are as follows:<br>"
                        + $"Account number: {accountNumber}<br>"
                        + $"First name: {firstName}<br>"
                        + $"Last name: {lastName}<br>"
                        + $"Address: {address}<br>"
                        + $"Phone number: {phoneNumber}<br>"
                        + $"Email: {email}<br>"
                        + $"Balance: {balance}<br><br>"
                        + "Your account statement are displayed below<br><br>"
                        + transactions 
                        + "<br><br>"
                        + "Kind regards,<br><br>"
                        + "Simple Banking System";
            smtpClient.Send(message);
        }

        public bool HasNumber(int accountNumber)
        {
            return this.accountNumber == accountNumber;
        }

        public void AccountDetails()
        {
            Console.WriteLine(" ______________________________________________________________");
            Console.WriteLine(" |                                                            |");
            Console.WriteLine(" |                      ACCOUNT DETAILS                       |");
            Console.WriteLine(" |____________________________________________________________|");
            Console.WriteLine(" |                                                            |");
            Console.WriteLine(" |    Account Number: " + this.accountNumber.ToString().PadRight(40, ' ') + "|");
            Console.WriteLine(" |    Account Balance: $" + this.balance.ToString().PadRight(38, ' ') + "|");
            Console.WriteLine(" |    First Name: " + this.firstName.PadRight(44, ' ') + "|");
            Console.WriteLine(" |    Last Name: " + this.lastName.PadRight(45, ' ') + "|");
            Console.WriteLine(" |    Address: " + this.address.PadRight(47, ' ') + "|");
            Console.WriteLine(" |    Phone: " + this.phoneNumber.PadRight(49, ' ') + "|");
            Console.WriteLine(" |    Email: " + this.email.PadRight(49, ' ') + "|");
            Console.WriteLine(" |____________________________________________________________|");
            Console.WriteLine();
        }

        public void displayStatement()
        {
            Console.WriteLine(" ______________________________________________________________");
            Console.WriteLine(" |                                                            |");
            Console.WriteLine(" |                   SIMPLE BANKING SYSTEM                    |");
            Console.WriteLine(" |____________________________________________________________|");
            Console.WriteLine(" |    Account Statement                                       |");
            Console.WriteLine(" |                                                            |");
            Console.WriteLine(" |    Account Number: " + this.accountNumber.ToString().PadRight(40, ' ') + "|");
            Console.WriteLine(" |    Account Balance: $" + this.balance.ToString().PadRight(38, ' ') + "|");
            Console.WriteLine(" |    First Name: " + this.firstName.PadRight(44, ' ') + "|");
            Console.WriteLine(" |    Last Name: " + this.lastName.PadRight(45, ' ') + "|");
            Console.WriteLine(" |    Address: " + this.address.PadRight(47, ' ') + "|");
            Console.WriteLine(" |    Phone: " + this.phoneNumber.PadRight(49, ' ') + "|");
            Console.WriteLine(" |    Email: " + this.email.PadRight(49, ' ') + "|");
            Console.WriteLine(" |____________________________________________________________|");
            Console.WriteLine(" |                    RECENT TRANSACTIONS                     |");
            Console.WriteLine(" |                                                            |");
            foreach (String s in transactions)
            {
                Console.Write($" |          {s} ");
                Console.WriteLine("|                                                            |");
            }
            Console.WriteLine(" |____________________________________________________________|");
        }
    }
}

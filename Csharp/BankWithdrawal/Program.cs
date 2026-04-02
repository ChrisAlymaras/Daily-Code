using System.Transactions;
using static BankWithdrawal.Program;

namespace BankWithdrawal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 10000;
            Console.WriteLine("- Bank ATM - ");
            try
            {
                Console.WriteLine("Enter Amount to Withdraw");
                double amount = Convert.ToDouble(Console.ReadLine());
                CheckRange(amount);
                CheckNegative(amount);
                balance = Withdraw(amount, balance);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("String contains letters" + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Too big number given enter a smaller amount: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Enter a number greater than 0: " + ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("Withdrawal process terminated: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occured: " + ex.Message);
            }
        }
        public static void CheckRange(double amount)
        {
            if (amount > double.MaxValue)
                throw new ArgumentOutOfRangeException();
        }

        public static void CheckNegative(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Negative number given");

        }

        public static double Withdraw(double amount, double balance)
        {
            if (amount > balance)
                throw new InsufficientFundsException("Not enough funds for withdrawal");
            else
            {
                
                Console.WriteLine("Withdrawal successful. Remaining balance: " + balance);
                return balance -= amount;
            }
        }

        public class InsufficientFundsException : Exception
        {
            public InsufficientFundsException(string message) : base(message)
            {
            }
        }
    } 
}

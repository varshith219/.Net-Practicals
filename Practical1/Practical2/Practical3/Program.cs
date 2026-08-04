using System;
using System.Collections.Generic;

namespace Practical3
{
    class Expense
    {
        public int ExpenseID;
        public string Category;
        public double Amount;
        public string PaymentMode;
        public DateTime ExpenseDate;

        public void AddExpense()
        {
            Console.Write("Enter Expense ID: ");
            ExpenseID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Expense Category: ");
            Category = Console.ReadLine();

            Console.Write("Enter Expense Amount: ");
            Amount = Convert.ToDouble(Console.ReadLine());

            if (Amount <= 0)
            {
                throw new Exception("Amount should be above 0");
            }

            Console.Write("Enter Payment Mode (Cash/UPI/Card): ");
            PaymentMode = Console.ReadLine();

            ExpenseDate = DateTime.Now;
        }

        public void DisplayExpense()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Expense Details");
            Console.WriteLine("======================================");
            Console.WriteLine("Expense ID : " + ExpenseID);
            Console.WriteLine("Expense Category : " + Category);
            Console.WriteLine("Expense Amount : " + Amount);
            Console.WriteLine("Payment Mode : " + PaymentMode);
            Console.WriteLine("Expense Added Date : " + ExpenseDate);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Expense> expenses = new List<Expense>();
            int choice = 0;

            do
            {
                Console.WriteLine("\n1. Add Expense");
                Console.WriteLine("2. View All Expenses");
                Console.WriteLine("3. View Total Expense");
                Console.WriteLine("4. Exit");

                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Expense e = new Expense();
                            e.AddExpense();
                            expenses.Add(e);
                            Console.WriteLine("Expense added successfully.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case 2:
                        if (expenses.Count == 0)
                        {
                            Console.WriteLine("No expenses found.");
                        }
                        else
                        {
                            foreach (Expense e in expenses)
                            {
                                e.DisplayExpense();
                            }
                        }
                        break;

                    case 3:
                        double total = 0;

                        foreach (Expense e in expenses)
                        {
                            total += e.Amount;
                        }

                        Console.WriteLine("Total Amount Spent: " + total);
                        break;

                    case 4:
                        Console.WriteLine("Thank You for Using Expense Tracker.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            } while (choice != 4);
        }
    }
}

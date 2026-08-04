using System;

namespace Practical2
{
    class Employee
    {
        public int EmployeeID;
        public string EmployeeName;
        public double BasicSalary;

        public void AcceptDetails()
        {
            Console.Write("Enter Employee ID : ");
            EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            EmployeeName = Console.ReadLine();

            Console.Write("Enter Basic Salary : ");
            BasicSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("Employee Details");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Employee ID : " + EmployeeID);
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Employee Basic Salary : " + BasicSalary);
        }

        public virtual void CalculateSalary()
        {
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double HRA = BasicSalary * 0.20;
            double DA = BasicSalary * 0.10;
            double NetSalary = BasicSalary + HRA + DA;

            Console.WriteLine("Employee Type : Full Time Employee");
            Console.WriteLine("Employee Net Salary : " + NetSalary);
        }
    }

    class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double NetSalary = BasicSalary;

            Console.WriteLine("Employee Type : Part Time Employee");
            Console.WriteLine("Employee Net Salary : " + NetSalary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Enter your Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                FullTimeEmployee e = new FullTimeEmployee();
                e.AcceptDetails();
                e.DisplayDetails();
                e.CalculateSalary();
            }
            else if (choice == 2)
            {
                PartTimeEmployee e = new PartTimeEmployee();
                e.AcceptDetails();
                e.DisplayDetails();
                e.CalculateSalary();
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }

            Console.ReadKey();
        }
    }
}

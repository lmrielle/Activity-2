using System;

namespace EmployeeSalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("                       Employee Salary Calculator                          ");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.Write("\nEnter Employee Name: ");
            string name = Console.ReadLine().ToUpper();

            Console.Write("Enter Basic Salary: ");
            double basicSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter Overtime Hours: ");
            int overtimeHours = int.Parse(Console.ReadLine());

            double overtimePay = overtimeHours * 200.0;
            double grossSalary = basicSalary + overtimePay;

            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine("                         Employee Salary Summary                           ");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("\nEmployee Name: " + name);
            Console.WriteLine($"Basic Salary:  {basicSalary:N2}");
            Console.WriteLine($"Overtime Pay:  {overtimePay:N2}");
            Console.WriteLine($"Gross Salary:  {grossSalary:N2}");

            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine("          Thank you for using Employee Salary Calculator!");
            Console.WriteLine("---------------------------------------------------------------------------");
        }
    }
}

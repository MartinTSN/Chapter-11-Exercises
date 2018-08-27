using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        var date1 = new Date(1, 1, 1989);
        var birthday = new Date(2, 9, 1989);
        var salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111", 800.00m, birthday);
        var hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75m, 40.0m, birthday);
        var commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000.00m, .06m, birthday);
        var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000.00m, .04m, 300.00m, birthday);
        var pieceWorker2 = new PieceWorker("Brian", "Briansen", "555-55-5555", .40m, 1000, birthday);
        birthday = new Date(4, 9, 1989);
        var pieceWorker = new PieceWorker("Brian", "Briansen", "555-55-5555", .40m, 1000, birthday);

        Console.WriteLine("Employees processed individually:\n");

        Console.WriteLine($"{salariedEmployee}\nearned: " +
            $"{salariedEmployee.Earnings():C}\n");
        Console.WriteLine($"{hourlyEmployee}\nearned: " +
            $"{hourlyEmployee.Earnings():C}\n");
        Console.WriteLine($"{commissionEmployee}\nearned: " +
            $"{commissionEmployee.Earnings():C}\n");
        Console.WriteLine($"{basePlusCommissionEmployee}\nearned: " +
            $"{basePlusCommissionEmployee.Earnings():C}\n");
        Console.WriteLine($"{pieceWorker}\nearned: " +
            $"{pieceWorker.Earnings():C}");

        var employees = new List<Employee>() { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee, pieceWorker2, pieceWorker };

        Console.WriteLine("\nEmployees processed polymorphically: \n");
        for (int month = 1; month < 12; month++)
        {
            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    var employee = (BasePlusCommissionEmployee)currentEmployee;

                    employee.BaseSalary *= 1.10m;
                    Console.WriteLine("new base salary with 10% increase is: " +
                        $"{employee.BaseSalary:C}");
                }
                if (month == currentEmployee.Birthday.Month)
                {
                    Console.WriteLine("Birthday Bonus: 100.00");
                    Console.WriteLine($"earned {currentEmployee.Earnings() + 100:C}\n");
                }
                else
                {
                    Console.WriteLine($"earned {currentEmployee.Earnings():C}\n");
                }
            }
        }


        for (int j = 0; j < employees.Count; j++)
        {
            Console.WriteLine($"Employee {j} is a {employees[j].GetType()}");
        }

        Console.ReadLine();
    }
}
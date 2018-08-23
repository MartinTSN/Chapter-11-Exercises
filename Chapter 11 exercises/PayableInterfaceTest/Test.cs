﻿using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        var salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111", 800.00m);
        var hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75m, 40.0m);
        var commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000.00m, .06m);
        var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000.00m, .04m, 300.00m);
        var pieceWorker = new PieceWorker("Brian", "Briansen", "555-55-5555", .40m, 1000);

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

        var employees = new List<Employee>() { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee, pieceWorker };

        Console.WriteLine("Employees processed polymorphically: \n");

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
            Console.WriteLine($"earned {currentEmployee.Earnings():C}\n");
        }

        for (int j = 0; j < employees.Count; j++)
        {
            Console.WriteLine($"Employee {j} is a {employees[j].GetType()}");
        }

        Console.ReadLine();
    }
}
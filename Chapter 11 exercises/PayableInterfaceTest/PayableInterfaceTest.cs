﻿using System;
using System.Collections.Generic;

class PayableInterfaceTest
{
    static void Main()
    {
        var payableObjects = new List<IPayable>()
        {
            new Invoice("01234", "seat", 2, 375.00m),
            new Invoice("56789", "tire", 4, 79.95m),
            new SalariedEmployee("john", "Smith", "111-11-1111", 800.00m),
            new SalariedEmployee("Lisa", "Barnes", "888-88-8888", 1200.00m)};

        Console.WriteLine(
            "Invoices and Employees processed polymorphically:\n");
        foreach (var payable in payableObjects)
        {
            Console.WriteLine($"{payable}");
            Console.WriteLine(
                $"payment due: {payable.GetPaymentAmount():C}\n");
        }

        Console.ReadLine();
    }
}


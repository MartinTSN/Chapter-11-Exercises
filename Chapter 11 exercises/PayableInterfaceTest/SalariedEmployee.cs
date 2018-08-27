﻿using System;

public class SalariedEmployee : Employee
{
    private decimal weeklySalary;

    public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, decimal weeklySalary, Date birthday)
        : base(firstName, lastName, socialSecurityNumber, birthday)
    {
        WeeklySalary = weeklySalary;
    }

    public decimal WeeklySalary
    {
        get
        {
            return weeklySalary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(WeeklySalary)} must be >= 0");
            }
            weeklySalary = value;
        }
    }

    public override decimal Earnings() => WeeklySalary;

    public override string ToString() =>
        $"salaried employee: {base.ToString()}\n" +
        $"weekly salary: {WeeklySalary:C}";

}


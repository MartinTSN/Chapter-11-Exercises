﻿using System;
public class BasePlusCommissionEmployee : CommissionEmployee
{
    private decimal baseSalary;

    public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary,Date birthday)
        : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate,birthday)
    {
        BaseSalary = baseSalary;
    }

    public decimal BaseSalary
    {
        get
        {
            return baseSalary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(BaseSalary)} must be >= 0");
            }
            baseSalary = value;
        }
    }

    public override decimal Earnings() => BaseSalary + base.Earnings();

    public override string ToString() =>
        $"base-salaried {base.ToString()}\nbase salary: {BaseSalary:C}";

}


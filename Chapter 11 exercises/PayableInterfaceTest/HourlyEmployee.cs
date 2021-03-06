﻿using System;

public class HourlyEmployee : Employee
{
    private decimal wage;
    private decimal hours;

    public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, decimal hourlyWage, decimal hoursWorked,Date birthday)
        : base(firstName, lastName, socialSecurityNumber,birthday)
    {
        Wage = hourlyWage;
        Hours = hoursWorked;
    }

    public decimal Wage
    {
        get
        {
            return wage;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Wage)} must be >= 0");
            }
            wage = value;
        }
    }
    public decimal Hours
    {
        get
        {
            return hours;
        }
        set
        {
            if (value < 0 || value > 168)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Hours)} must be >= 0 and <= 168");
            }
            hours = value;
        }
    }
    public override decimal Earnings()
    {
        if (Hours <= 40)
        {
            return Wage * Hours;
        }
        else
        {
            return (40 * Wage) + ((Hours - 40) * Wage * 1.5m);
        }
    }

    public override string ToString() =>
        $"hourly employee: {base.ToString()}\n" +
        $"hourly wage: {Wage:C}\n" +
        $"hours worked: {Hours:F2}";

}


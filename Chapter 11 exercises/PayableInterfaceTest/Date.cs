using System;

public class Date
{
    private int month;
    private int day;
    public int year;

    public Date(int month, int day, int year)
    {
        Month = month;
        Year = year;
        Day = day;
        Console.WriteLine($"Date object constructor for date {this}");
    }
    public int Month
    {
        get
        {
            return month;
        }
        private set
        {
            if (value <= 0 || value > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Month)} must be 1-12");
            }
            month = value;
        }
    }

    public int Day
    {
        get
        {
            return day;
        }
        private set
        {
            int[] daysPerMonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (value <= 0 || value > daysPerMonth[Month])
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range for current month/year");
            }
            if (Month == 2 && value == 29 && !(Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range for current month/year");
            }
            day = value;
        }
    }

    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            if (value < 1918 || value > DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Year)} out of range for current year");
            }
            year = value;
        }
    }

    public override string ToString() => $"{Month}/{Day}/{Year}";

    public string NextDay()
    {
        int[] daysPerMonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int monthsPerYear = 12;


        if (day >= daysPerMonth[Month] || Month == 2 && day == 28)
        {

            if (Month != monthsPerYear)
            {
                Month += 1;
            }
            if (Month == monthsPerYear && Day == daysPerMonth[Month])
            {
                Year += 1;
                Month = 1;
            }
            Day = 1;
        }
        else
        {
            Day += 1;
        }

        return $"{Day},{Month},{Year}";
    }

}
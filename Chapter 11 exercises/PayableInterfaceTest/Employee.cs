public abstract class Employee : IPayable
{
    public string FirstName { get; }
    public string LastName { get; }
    public string SocialSecurityNumber { get; }
    private Date Birthday { get; }

    public Employee(string firstName, string lastName, string socialSecurityNumber,Date birthday)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNumber = socialSecurityNumber;
        Birthday = birthday;
    }

    public override string ToString() => $"{FirstName} {LastName}\n" +
        $"social security number: {SocialSecurityNumber}";

    public abstract decimal Earnings();

    public decimal GetPaymentAmount() => Earnings();
}


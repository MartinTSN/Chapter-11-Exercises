using System;

public class PieceWorker : Employee
{
    private decimal wage;
    private int pieces;

    public PieceWorker(string firstName, string lastName, string socialSecurityNumber, decimal wage, int pieces)
        : base(firstName, lastName, socialSecurityNumber)
    {
        Wage = wage;
        Pieces = pieces;
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

    public int Pieces
    {
        get
        {
            return pieces;
        }
        set
        {
            pieces = value;
        }
    }

    public override decimal Earnings() => Pieces * Wage;

    public override string ToString() =>
        $"Piece Worker: {base.ToString()}\n" +
        $"Wage: {Wage:C}\n" +
        $"Pieces: {Pieces}";

}


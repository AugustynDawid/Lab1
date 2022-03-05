using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Fraction : IEquatable<Fraction>, IComparable
{
	private int numerator;
	private int denominator;

	public Fraction()
	{
		this.numerator = 1;
		this.denominator = 1;
	}

	public Fraction(int numerator, int denominator)
	{
		this.numerator = numerator;
		this.denominator = denominator;
	}

	public Fraction(Fraction f)
	{
		this.numerator = f.numerator;
		this.denominator = f.denominator;
	}

	public override string ToString()
	{
		return $"{numerator}/{denominator}";
	}

    public int CompareTo(object obj)
    {
        throw new NotImplementedException();
    }

    public bool Equals(Fraction other)
    {
        throw new NotImplementedException();
    }


    public static Fraction operator +(Fraction a, Fraction b)
	{
		int x = a.numerator * b.denominator + b.numerator * a.denominator;
		int y = a.denominator * b.denominator;
		Fraction result = new Fraction(x, y);
		return result;
	}

	public static Fraction operator -(Fraction a, Fraction b)
	{
		int x = a.numerator * b.denominator - b.numerator * a.denominator;
		int y = a.denominator * b.denominator;
		Fraction result = new Fraction(x, y);
		return result;
	}

	public static Fraction operator *(Fraction a, Fraction b)
	{
		int x = a.numerator * b.numerator;
		int y = a.denominator * b.denominator;
		Fraction result = new Fraction(x, y);
		return result;
	}

	public static Fraction operator /(Fraction a, Fraction b)
	{
		int x = a.numerator * b.denominator;
		int y = a.denominator * b.numerator;
		Fraction result = new Fraction(x, y);
		return result;
	}
}

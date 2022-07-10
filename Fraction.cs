using System;

/// <summary>
/// Fraction class for CSharp Lab01
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

		if(this.denominator < 0)
        {
			this.numerator *= -1;
			this.denominator *= -1;
        }

		int g = Math.Abs(Gcd(this.numerator, this.denominator));
		this.numerator /= g;
		this.denominator /= g;
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
		Fraction other = obj as Fraction;

		int g = Gcd(denominator, other.denominator);

		int n1 = numerator * other.denominator / g;
		int n2 = denominator * other.denominator / g;

		return n1.CompareTo(n2);
    }

    public bool Equals(Fraction obj)
    {
		Fraction other = obj as Fraction;
		return (numerator == other.numerator && denominator == other.denominator);
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

	/// <summary>
	/// Greatest common divisor of two numbers
	/// Euclidean algorithm
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <returns></returns>
	private static int Gcd(int a, int b)
    {
		if (b == 0)
        {
			return a;
        }
		return Gcd(b, a % b);
    }

	/// <summary>
	/// Least common multiply
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <returns></returns>
	private static int Lcm(int a, int b)
    {
		return a * b / Gcd(a, b);
    }
}

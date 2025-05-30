using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.WriteLine();
        // Test with all three constructors
        Fraction f1 = new Fraction();              // 1/1
        Fraction f2 = new Fraction(5);             // 5/1
        Fraction f3 = new Fraction(3, 4);          // 3/4
        Fraction f4 = new Fraction(1, 3);          // 1/3

        // Display original values
        DisplayFraction(f1);
        DisplayFraction(f2);
        DisplayFraction(f3);
        DisplayFraction(f4);

        // Modify f1 using setters
        f1.SetNumerator(7);
        f1.SetDenominator(2);

        Console.WriteLine("\nAfter modifying f1:");
        DisplayFraction(f1);
    }

    static void DisplayFraction(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
} 
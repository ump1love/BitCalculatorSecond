using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first binary floating-point number:");
        string binaryStr1 = Console.ReadLine();

        Console.WriteLine("Enter the second binary floating-point number:");
        string binaryStr2 = Console.ReadLine();

        double num1 = BinaryToDecimal(binaryStr1);
        double num2 = BinaryToDecimal(binaryStr2);

        double sum = num1 + num2;
        Console.WriteLine($"Addition Result: {DecimalToBinary(sum)}");

        double difference = num1 - num2;
        Console.WriteLine($"Subtraction Result: {DecimalToBinary(difference)}");

        double product = num1 * num2;
        Console.WriteLine($"Multiplication Result: {DecimalToBinary(product)}");

        if (num2 != 0)
        {
            double quotient = num1 / num2;
            Console.WriteLine($"Division Result: {DecimalToBinary(quotient)}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    static double BinaryToDecimal(string binaryStr)
    {
        return Convert.ToInt32(binaryStr, 2);
    }

    static string DecimalToBinary(double decimalNum)
    {
        int integerPart = (int)decimalNum;
        double fractionalPart = decimalNum - integerPart;

        string binaryInteger = Convert.ToString(integerPart, 2);
        string binaryFractional = ConvertFractionalToBinary(fractionalPart);

        return $"{binaryInteger}.{binaryFractional}";
    }

    static string ConvertFractionalToBinary(double fractionalPart)
    {
        const int MaxFractionalBits = 10;
        string binaryFractional = "";

        while (fractionalPart > 0 && binaryFractional.Length < MaxFractionalBits)
        {
            fractionalPart *= 2;
            int bit = (int)fractionalPart;
            binaryFractional += bit;
            fractionalPart -= bit;
        }

        return binaryFractional;
    }
}
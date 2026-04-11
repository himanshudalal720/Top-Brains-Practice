using System;

public class MultiConvertSystem
{
    public double Convert(double value, string fromUnit, string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        if (fromUnit == "meters" && toUnit == "kilometers")
            return value * 0.001;
        if (fromUnit == "kilometers" && toUnit == "meters")
            return value * 1000;
        if (fromUnit == "miles" && toUnit == "feet")
            return value * 5280;
        if (fromUnit == "feet" && toUnit == "miles")
            return value / 5280;

        if (fromUnit == "grams" && toUnit == "kilograms")
            return value * 0.001;
        if (fromUnit == "kilograms" && toUnit == "grams")
            return value * 1000;
        if (fromUnit == "pounds" && toUnit == "ounces")
            return value * 16;
        if (fromUnit == "ounces" && toUnit == "pounds")
            return value / 16;

        if (fromUnit == "celsius" && toUnit == "fahrenheit")
            return (value * 9 / 5) + 32;
        if (fromUnit == "fahrenheit" && toUnit == "celsius")
            return (value - 32) * 5 / 9;
        if (fromUnit == "celsius" && toUnit == "kelvin")
            return value + 273.15;
        if (fromUnit == "kelvin" && toUnit == "celsius")
            return value - 273.15;

        return 0;
    }

    public double Convert(double value, string fromUnit)
    {
        string type = GetType(fromUnit);
        string defaultUnit = GetDefaultUnit(type);
        return Convert(value, fromUnit, defaultUnit);
    }

    private string GetType(string unit)
    {
        unit = unit.ToLower();

        if (unit == "meters" || unit == "kilometers" || unit == "miles" || unit == "feet")
            return "length";
        if (unit == "grams" || unit == "kilograms" || unit == "pounds" || unit == "ounces")
            return "weight";
        return "temperature";
    }

    private string GetDefaultUnit(string type)
    {
        if (type == "length")
            return "meters";
        if (type == "weight")
            return "kilograms";
        return "celsius";
    }
}

class Program
{
    static void Main(string[] args)
    {
        MultiConvertSystem converter = new MultiConvertSystem();

        Console.WriteLine("Enter conversion type (length / weight / temperature):");
        string type = Console.ReadLine();

        Console.WriteLine("Enter value:");
        double value = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter from unit:");
        string fromUnit = Console.ReadLine();

        Console.WriteLine("Enter to unit (press Enter to use default):");
        string toUnit = Console.ReadLine();

        double result;

        if (string.IsNullOrEmpty(toUnit))
        {
            result = converter.Convert(value, fromUnit);
            Console.WriteLine("Converted Value: " + result);
        }
        else
        {
            result = converter.Convert(value, fromUnit, toUnit);
            Console.WriteLine("Converted Value: " + result + " " + toUnit);
        }
    }
}

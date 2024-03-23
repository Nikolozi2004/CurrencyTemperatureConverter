namespace CurrencyTemperatureConverter;

internal class Converter
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Currency Converter");
            Console.WriteLine("2. Temperature Converter");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CurrencyConverter();
                    break;
                case 2:
                    TemperatureConverter();
                    break;
                case 3:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }
        }
    }

    static void CurrencyConverter()
    {
        Console.WriteLine("Currency Converter");
        Console.WriteLine("1. USD to EUR");
        Console.WriteLine("2. EUR to USD");
        Console.WriteLine("3. Exit");

        Console.Write("Enter your choice: ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid choice. Please enter a number.");
            return;
        }

        double rate;
        switch (choice)
        {
            case 1:
                rate = 0.84;
                break;
            case 2:
                rate = 1.19;
                break;
            case 3:
                Console.WriteLine("Exiting currency converter...");
                return;
            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                return;
        }

        Console.Write("Enter amount: ");
        if (!double.TryParse(Console.ReadLine(), out double amount))
        {
            Console.WriteLine("Invalid amount. Please enter a valid number.");
            return;
        }

        double convertedAmount = amount * rate;
        Console.WriteLine($"Converted amount: {convertedAmount:F2}");
    }

    static void TemperatureConverter()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.WriteLine("3. Celsius to Kelvin");
        Console.WriteLine("4. Kelvin to Celsius");
        Console.WriteLine("5. Fahrenheit to Kelvin");
        Console.WriteLine("6. Kelvin to Fahrenheit");
        Console.WriteLine("7. Exit");

        Console.Write("Enter your choice: ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid choice. Please enter a number.");
            return;
        }

        double result;
        switch (choice)
        {
            case 1:
                Console.Write("Enter temperature in Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                result = CelsiusToFahrenheit(celsius);
                Console.WriteLine($"Temperature in Fahrenheit: {result:F2}");
                break;
            case 2:
                Console.Write("Enter temperature in Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());
                result = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"Temperature in Celsius: {result:F2}");
                break;
            case 3:
                Console.Write("Enter temperature in Celsius: ");
                double celsiusToKelvin = double.Parse(Console.ReadLine());
                result = CelsiusToKelvin(celsiusToKelvin);
                Console.WriteLine($"Temperature in Kelvin: {result:F2}");
                break;
            case 4:
                Console.Write("Enter temperature in Kelvin: ");
                double kelvinToCelsius = double.Parse(Console.ReadLine());
                result = KelvinToCelsius(kelvinToCelsius);
                Console.WriteLine($"Temperature in Celsius: {result:F2}");
                break;
            case 5:
                Console.Write("Enter temperature in Fahrenheit: ");
                double fahrenheitToKelvin = double.Parse(Console.ReadLine());
                result = FahrenheitToKelvin(fahrenheitToKelvin);
                Console.WriteLine($"Temperature in Kelvin: {result:F2}");
                break;
            case 6:
                Console.Write("Enter temperature in Kelvin: ");
                double kelvinToFahrenheit = double.Parse(Console.ReadLine());
                result = KelvinToFahrenheit(kelvinToFahrenheit);
                Console.WriteLine($"Temperature in Fahrenheit: {result:F2}");
                break;
            case 7:
                Console.WriteLine("Exiting temperature converter...");
                return;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    static double FahrenheitToKelvin(double fahrenheit)
    {
        return (fahrenheit + 459.67) * 5 / 9;
    }

    static double KelvinToFahrenheit(double kelvin)
    {
        return kelvin * 9 / 5 - 459.67;
    }
}

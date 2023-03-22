Console.WriteLine("Homework 2: leap year");
Console.WriteLine("----------------------");
Console.Write("Please, give me a year to check if it is a leap year or not: ");

try
{
    string input = Console.ReadLine();

    if (int.TryParse(input, out int year))
    {
        Console.WriteLine("You have introduced the following year: " + year);
        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is leap year");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year");
        }
    }
    else
    {
        Console.WriteLine("You have introduced the following text: " + input);
        Console.WriteLine("The input could not be converted to a year.");
    }

}
catch (FormatException)
{
    Console.WriteLine("Invalid input format. Please enter a valid integer.");
}
catch (OverflowException)
{
    Console.WriteLine("The input number is too large or too small to be represented as an integer.");
}

static bool IsLeapYear(int year)
{
    return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
}


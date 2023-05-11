WriteLine("Homework 2: leap year");
WriteLine("Check whether a given year is leap year or not.");
WriteLine("----------------------");
Write("Please, give me a year to check if it is a leap year or not: ");

try
{
    string input = ReadLine();

    if (int.TryParse(input, out int year))
    {
        WriteLine("You have introduced the following year: " + year);
        if (IsLeapYear(year))
        {
            WriteLine(year + " is leap year");
        }
        else
        {
            WriteLine(year + " is not a leap year");
        }
    }
    else
    {
        WriteLine("You have introduced the following text: " + input);
        WriteLine("The input could not be converted to a year.");
    }

}
catch (FormatException)
{
    WriteLine("Invalid input format. Please enter a valid integer.");
}
catch (OverflowException)
{
    WriteLine("The input number is too large or too small to be represented as an integer.");
}

static bool IsLeapYear(int year)
{
    return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
}


WriteLine("Basic C# part 2 - Homework: Problem 1");
WriteLine("1. Write a program that reads a number from the keyboard." +
    " Check whether that number is divisible by 7 and 11 or not.");
Write("Please, introduce a number: ");

try
{
    string input = ReadLine();

    if (int.TryParse(input, out int number))
    {
        WriteLine("The input was successfully converted to an integer.");
        WriteLine("You have introduced the following number: " + number);

        if (number % 7 == 0 && number % 11 == 0)
        {
            WriteLine("Number is divisible by 7 and 11");
        }
        else
        {
            WriteLine("Number is not divisible by 7 and 11");
        }
    }
    else
    {
        WriteLine("You have introduced the following text: " + input);
        WriteLine("The input could not be converted to an integer.");
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

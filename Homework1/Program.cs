Console.WriteLine("Homework - Problem 1");
Console.Write("Please, introduce a number: ");

try
{
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        Console.WriteLine("The input was successfully converted to an integer.");
        Console.WriteLine("You have introduced the following number: " + number);

        if (number % 7 == 0 && number % 11 == 0)
        {
            Console.WriteLine("Number is divisible by 7 and 11");
        }
        else
        {
            Console.WriteLine("Number is not divisible by 7 and 11");
        }
    }
    else
    {
        Console.WriteLine("You have introduced the following text: " + input);
        Console.WriteLine("The input could not be converted to an integer.");
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

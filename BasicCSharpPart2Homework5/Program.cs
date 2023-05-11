WriteLine("Basic C# - part 2 - Homework 4");
WriteLine("Find the sum of digits of a number read from the keyboard");

Write("Enter a number: ");

string input = Console.ReadLine();
int sum = 0;

foreach (char digit in input)
{
    sum += int.Parse(digit.ToString());
}

WriteLine("The sum of digits is: " + sum);
WriteLine("Basic C# part 2 - Challenge 1:");
Write("1. Convert Binary 10011010 to Decimal number system: ");
WriteLine(DecimalToBinary("10011010"));
WriteLine("---------------------------------------");

Problem3(154);
WriteLine("---------------------------------------");

//Convert using build-in method
//string binaryNumber = "10011010";
//int decimalNumber = Convert.ToInt32(binaryNumber, 2);
//Console.WriteLine($"The binary number {binaryNumber} is equal to decimal number {decimalNumber}.");

//Convert using user-defined method
static int DecimalToBinary(string binary)
{
    //check if input is null or empty
    //throw exception if it is
    if (string.IsNullOrEmpty(binary))
    {
        throw new ArgumentException("The input binary string must not be null or empty.", nameof(binary));
    }

    int decimalNumber = 0;
    int bitPosition = 1;

    //looping through each character of the binary string in reverse order
    //starting from the last character
    for (int i = binary.Length - 1; i >= 0; i--)
    {
        //check if it is '1'
        if (binary[i] == '1')
        {
            //add the corresponding power of 2 to decimalNumber
            decimalNumber += bitPosition;
        }

        //double bitPosition to move to the next bit position
        bitPosition *= 2;
    }

    return decimalNumber;
}


//2.Find an optimal solution to the code that converts a decimal to binary.
//public static void Problem3(int number)
//{
//    if (number < 0)
//    {
//        Console.WriteLine("Please give a positive number.");
//        return;
//    }
//    int binary = 0;
//    int temp = 1;
//    while (number > 0)
//    {
//        int r = number % 2;
//        temp = temp * 10 + r;
//        number /= 2;
//    }
//    while (temp > 0)
//    {
//        binary = binary * 10 + temp % 10;
//        temp = temp / 10;
//    }
//    binary = binary / 10;
//    Console.WriteLine(binary);
//}


static void Problem3(int number)
{
    if (number < 0)
    {
        WriteLine("Please give a positive number.");
        return;
    }

    string binary = "";
    int originalNumber = number;

    while (number > 0)
    {
        int r = number % 2;
        binary = r + binary;
        number /= 2;
    }

    WriteLine($"Number {originalNumber} converted to binary is: {binary}");
}


int count = 0;
int num = 2;
int primeNumber = 0;

while (count < 47)
{
    bool isPrime = true;
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        primeNumber = num;
        count++;
    }
    num++;
}

Console.WriteLine(primeNumber);

for (int i = 1; i <= 255; i++)
{
    System.Console.WriteLine(i);
}

Random rand =  new Random();
int sum = 0;
for (int j = 0; j < 5; j++)
{
    //System.Console.WriteLine(rand.Next(10, 21));
    sum += rand.Next(10, 21);
}
System.Console.WriteLine(sum);

for (int k = 1; k <= 100; k++)
{
    if (k % 3 == 0 && k % 5 == 0)
    {
        System.Console.WriteLine("FizzBuzz");
    }
    else if (k % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else if (k % 5 ==0)
    {
        System.Console.WriteLine("Buzz");
    }
    else
    {
        System.Console.WriteLine(k);
    }
}
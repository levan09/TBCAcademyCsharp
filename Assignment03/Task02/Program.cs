long n = long.Parse(Console.ReadLine());
int c = 2;

for(int i = 2; i <= n/2; i++)
{
    if(n % i == 0)
    {
        c++;
    }
}

Console.WriteLine("The number of divisors is: " + c);
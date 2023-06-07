using System;

long n = long.Parse(Console.ReadLine());
int i = 2;


while (i * i < n && n%i != 0)
{
    i++;
}

if(n%i == 0 && i < n)
{
    Console.WriteLine("The number is not prime");
}
else
{
    Console.WriteLine("The number is prime");
}
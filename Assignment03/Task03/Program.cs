int n = int.Parse(Console.ReadLine());

long sum = 0;
int c;
int count = 0;


for(int i = 0; i < n; i++)
{
    c = int.Parse(Console.ReadLine());
    if(c > 0)
    {
        count++;
        sum += c;
    }
}

Console.WriteLine("Sum of positive numbers is: " + sum);
Console.WriteLine("Average is: " + (double)sum/(double)count);
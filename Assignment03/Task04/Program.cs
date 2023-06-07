int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for(int j = 1; j <= n*2-1; j++)
    {
        if(j >= (n-i) && j <= n + i)
        {
            Console.Write("*");
        }else { 
            Console.Write(" "); 
        }
        
    }
    Console.WriteLine();
}
Console.WriteLine("Enter size of array");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

Console.WriteLine("Enter elements of array");

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int SumOfDigits(int[] arr, int index)
{
    if (index >= arr.Length)
    {
        return -1;
    }
    int m = arr[index];
    if(m < 0) { m *= -1; }
    int sum = 0;
    while(m != 0)
    {
        sum += m%10;
        m /= 10;
    }
    return sum;
}

Console.WriteLine("Enter index of desired element");
int ind = int.Parse(Console.ReadLine());
int m = SumOfDigits(arr, ind);
if(m == -1)
{
    Console.WriteLine("Eror: Index out of bounds");
}
else
{
    Console.WriteLine("Sum of digits is: " + m);
}

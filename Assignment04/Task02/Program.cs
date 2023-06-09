Console.WriteLine("Enter length of first array");
int n = int.Parse(Console.ReadLine());

string[] arr = new string[n];
Console.WriteLine("Enter elements of first array");
for (int i = 0; i < n; i++)
{
    arr[i] = Console.ReadLine();
}

Console.WriteLine("Enter length of second array");
int m = int.Parse(Console.ReadLine());

int[] arr2 = new int[m];
Console.WriteLine("Enter elements of second array");
for (int i = 0; i < m; i++)
{
    arr2[i] = int.Parse(Console.ReadLine());
}

int sum = n + m;
string[] arr3 = new string[sum];
int count = 0;

for (int i = 0; i < sum; i++)
{
    if(count < n && count < m)
    {
        arr3[i] = arr[count];
        arr3[i + 1] = arr2[count].ToString();
        i++;
    }else if(count < n)
    {
        arr3[i] = arr[count];
    }
    else
    {
        arr3[i] = arr2[count].ToString();
    }
    
    count++;
}

for (int i = 0; i < sum; i++)
{
    Console.Write(arr3[i] + " ");
}
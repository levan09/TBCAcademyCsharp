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

string[] arr2 = new string[m];
Console.WriteLine("Enter elements of second array");
for (int i = 0; i < m; i++)
{
    arr[i] = Console.ReadLine();
}

int sum = n + m;
string[] arr3 = new string[sum];
int count = 0;

for (int i = 0; i < sum - 1; i += 2)
{
    arr3[i] = arr[count];
    arr3[i + 1] = arr2[count];
    count++;
}

for (int i = 0; i < sum; i++)
{
    Console.Write(arr[i] + " ");
}
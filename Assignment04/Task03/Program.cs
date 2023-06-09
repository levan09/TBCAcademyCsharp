Console.WriteLine("Enter size of first array");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Enter size of second array");
int m = int.Parse(Console.ReadLine());

int[] arr2 = new int[m];
for (int i = 0; i < m; i++)
{
    arr2[i] = int.Parse(Console.ReadLine());
}

int[] arr3 = arr.Concat(arr2).ToArray();
string dest;

do
{
    Console.WriteLine("Choose sorting direction: write 'ASC' or 'DESC'");
    dest = Console.ReadLine();
} while (dest != "ASC" && dest != "DESC");



Array.Sort(arr3);

if (dest == "DESC")
{
    Array.Reverse(arr3);
}

for(int i = 0; i < arr3.Length; i++)
{
    Console.Write(arr3[i] + " ");
}
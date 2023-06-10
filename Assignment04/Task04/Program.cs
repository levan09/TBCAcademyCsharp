Console.WriteLine("Enter size of array");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int size = 0, mnInd = 0, mxInd = 0, tempsz = 0, tempmn = 0, tempmx = 0;

for(int i = 0; i < n - 1; i++)
{   
    
    if (arr[i] < arr[i + 1])
    {
        tempmx = i + 1;
        tempsz++;
    }
    else
    {
        if(tempsz > size)
        {
            size = tempsz;
            mnInd = tempmn;
            mxInd = tempmx;
            tempmn = i + 1;
        }
    }
}
if (tempsz > size)
{
    mnInd = tempmn;
    mxInd = tempmx;
}

for (int i = mnInd; i <= mxInd; i++)
{
    Console.Write(arr[i] + " ");
}
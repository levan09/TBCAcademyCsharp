char[] FillArr()
{
    Console.WriteLine("Enter size of array");
    int n = int.Parse(Console.ReadLine());

    char[] CharArr = new char[n];
    Console.WriteLine("Enter char elements of array");
    for(int i = 0; i < n; i++)
    {
        CharArr[i] = Convert.ToChar(Console.ReadLine());
    }

    return CharArr;
}


int CountChars(Char[] CharArr, Char c)
{
    int count = 0;
    for(int i = 0;i < CharArr.Length;i++)
    {
        if (CharArr[i] == c)
        {
            count++;
        }
    }

    return count;
}

void WriteAns(Char c, int count)
{
    Console.WriteLine("Symbol: " + c + " was found " + count + " times");
}

char[] Chars = FillArr();

Console.WriteLine("Enter char to look for: ");
Char c = Convert.ToChar(Console.ReadLine());

int count = CountChars(Chars, c);

WriteAns(c, count);
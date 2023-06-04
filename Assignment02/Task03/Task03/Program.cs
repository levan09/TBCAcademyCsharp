Console.WriteLine("sheiyvanet tqveni dabadebis weli");
string Birthdate = Console.ReadLine();
int Birthyear = int.Parse(Birthdate);

int order = Birthyear % 12;

switch (order)
{
    case 0:
        {
            Console.WriteLine("maimunis weli");
            break;
        }
    case 1:
        {
            Console.WriteLine("mamlis weli");
            break;
        }
    case 2:
        {
            Console.WriteLine("dzaglis weli");
            break;
        }
    case 3:
        {
            Console.WriteLine("goris weli");
            break;
        }
    case 4:
        {
            Console.WriteLine("virtxis weli");
            break;
        }
    case 5:
        {
            Console.WriteLine("xaris weli");
            break;
        }
    case 6:
        {
            Console.WriteLine("vefxvis weli");
            break;
        }
    case 7:
        {
            Console.WriteLine("kurdglis weli");
            break;
        }
    case 8:
        {
            Console.WriteLine("drakonis weli");
            break;
        }
    case 9:
        {
            Console.WriteLine("gvelis weli");
            break;
        }
    case 10:
        {
            Console.WriteLine("cxenis weli");
            break;
        }
    case 11:
        {
            Console.WriteLine("txis weli");
            break;
        }
}
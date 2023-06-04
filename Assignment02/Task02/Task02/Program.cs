
Console.WriteLine("airchiet qva, qagaldi an makrateli");
string player = Console.ReadLine();

Random rnd = new Random();
int App = rnd.Next(1, 4);

// 1 == qva, 2 == qagaldi, 3 == makrateli

if (App == 1)
{
    Console.WriteLine("aplikaciam airchia qva");
    switch (player)
    {
        case "qva":
            {
                Console.WriteLine("frea");
                break;
            }
        case "qagaldi":
            {
                Console.WriteLine("motamashem moigo");
                break;
            }
        case "makrateli":
            {
                Console.WriteLine("motamashem waago");
                break;
            }
    }
}
else if (App == 2)
{
    Console.WriteLine("aplikaciam airchia qagaldi");
    switch (player)
    {
        case "qva":
            {
                Console.WriteLine("motamashem waago");
                break;
            }
        case "qagaldi":
            {
                Console.WriteLine("frea");
                break;
            }
        case "makrateli":
            {
                Console.WriteLine("motamashem moigo");
                break;
            }
    }
}
else if (App == 3)
{
    Console.WriteLine("aplikaciam airchia makrateli");
    switch (player)
    {
        case "qva":
            {
                Console.WriteLine("motamashem moigo");
                break;
            }
        case "qagaldi":
            {
                Console.WriteLine("motamashem waago");
                break;
            }
        case "makrateli":
            {
                Console.WriteLine("frea");
                break;
            }
    }
}
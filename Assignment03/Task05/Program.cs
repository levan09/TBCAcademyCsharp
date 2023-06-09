Console.WriteLine("Enter the min number");
int mn = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the max number");
int mx = int.Parse(Console.ReadLine());

Random rnd = new Random();
int Guess;
Guess = rnd.Next(mn, mx + 1);

int player;
int count = 0;
string Decision;

while(true)
{
    Console.WriteLine("Please enter your guess:");
    player = int.Parse(Console.ReadLine());
    count++;

    if(player == Guess)
    {
        Console.WriteLine("The number of attempts: " + count);

        Console.WriteLine("Would you like to continue? write Yes or No");

        Decision = Console.ReadLine();
        if(Decision == "Yes")
        {
            Console.WriteLine("Please enter new min number");
            mn = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter new max number");
            mx = int.Parse(Console.ReadLine());

            Guess = rnd.Next(mn, mx + 1);
            count = 0;
        }
        else
        {
            break;
        }
    }

}
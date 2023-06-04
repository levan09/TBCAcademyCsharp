
Console.WriteLine("ra temperaturaa dges?");
string temperature = Console.ReadLine();

int TempInt = int.Parse(temperature);

if(TempInt < 0)
{
    Console.WriteLine("yinavs");
    return;
}else if(TempInt >= 0 &&  TempInt <= 30)
{
    Console.WriteLine("kargi amindia");
    return;
}
else
{
    Console.WriteLine("cxela");
}
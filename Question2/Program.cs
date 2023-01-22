
Console.WriteLine("Enter the time of flight");
int time = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the fare of ticket");
int fare = int.Parse(Console.ReadLine());
double temp;

if (time >= 6 && time < 9)
{
    temp = (fare * 1.10);
    Console.WriteLine("flight ticket fare :" + temp);
}
else if (time >= 9 && time < 17)

{
    temp = (fare * 1.20);
    Console.WriteLine("flight ticket fare :" + temp);
}

else if (time >= 17 && time < 23)
{
    temp = (fare * 1.07);
    Console.WriteLine("flight ticket fare :" + temp);
}

else
{
    temp = (fare * 1.05);
    Console.WriteLine("flight ticket fare :" + temp);
}
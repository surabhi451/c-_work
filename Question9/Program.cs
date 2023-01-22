Console.WriteLine("Enter your date of birth");
DateTime date = DateTime.Parse(Console.ReadLine());
var temp = DateTime.Now.Year - date.Year;

if (temp < 10)
{
    Console.WriteLine("The passenger is a kid");
}
else if (temp >= 10 && temp < 30)
{
    Console.WriteLine("The passenger is youth");
}
else if (temp >= 30 && temp < 60)
{
    Console.WriteLine("The passenger is adult");
}
else
{
    Console.WriteLine("The passenger is old");
}
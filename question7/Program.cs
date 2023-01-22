Console.WriteLine("Enter the passenger name:");
string Name = Console.ReadLine();


Console.WriteLine("Enter the total miles travelled:");
int Miles = int.Parse(Console.ReadLine());

if (Miles < 10000)
{
    Console.WriteLine(Name + " no frequent flyer points.");
}
else if (Miles > 10000 && Miles < 20000)
{
    Console.WriteLine(Name + "  award 10 frequent flyer points.");
}
else if (Miles >= 20000 && Miles < 50000)
{
    Console.WriteLine(Name + "  award 20 frequent flyer points.");
}
else if (Miles >= 50000 && Miles < 100000)
{
    Console.WriteLine(Name + "  award 30 frequent flyer points.");
}
else
{
    Console.WriteLine(Name + "  award 50 frequent flyer points ");
}

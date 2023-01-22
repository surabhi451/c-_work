Console.WriteLine("Enter the 10 flight fare");
decimal[] fare = new decimal[10];
for (int i = 0; i < fare.Length; i++)
{
    fare[i] = decimal.Parse(Console.ReadLine());
}

Console.WriteLine("FLIGHT FARE IN ASCENTING ORDER:");
Array.Sort(fare);
foreach (var s in fare)
{
    Console.WriteLine(s);
}


Console.WriteLine("FLIGHT FARE IN DESCENTING ORDER:");
Array.Reverse(fare);
foreach (var s in fare)
{
    Console.WriteLine(s);
}

Console.WriteLine("ENTER THE SEARCH ELEMENT:");
decimal search = decimal.Parse(Console.ReadLine());
int flag = 0;
for (int i = 0; i < fare.Length; i++)
{
    if (fare[i] == search)
    {
        flag++;
    }
}
if (flag == 1)
{
    Console.WriteLine(search + " element is found");
}
else
{
    Console.WriteLine(search + " element is not found");
}



{
    Console.WriteLine("maximum fare:" + fare.Max());
    Console.WriteLine("minimum fare:" + fare.Min());
}
Console.WriteLine("The duplicate element:");
for (int i = 0; i < fare.Length; i++)
{
    for (int j = i + 1; j < fare.Length; j++)
    {
        if (fare[i] == fare[j])
        {
            Console.WriteLine("The duplicate flight fare is " + fare[i]);
        }
    }
}
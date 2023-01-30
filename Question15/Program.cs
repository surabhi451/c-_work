Console.WriteLine("Enter the limit");
int limit = int.Parse(Console.ReadLine());

Console.WriteLine("Enter luggage weight");
int[] weight = new int[limit];

for (int i = 0; i < weight.Length; i++)
{
    weight[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < weight.Length; i++)
{
    if (weight[i] >= 24)
    {
        int result = (weight[i]-24) * 15;
        Console.WriteLine("over weight charged " + result);

       
    }
    else
    {

        Console.WriteLine("No overweight");

    }
}
Console.WriteLine("sorted order :");
for (int i = 0; i <weight.Length; i++) 
{ for (int j = 0; j <weight.Length; j++) 
    { if (weight[i] > weight[j]) 
        { int temp = weight[i]; 
            weight[i] = weight[j];
            weight[j] = temp; 
        }
    } 
}

for (int i = 0; i < limit; i++)
{ 
    Console.WriteLine($"{weight[i]}");
}
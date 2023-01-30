
Console.WriteLine("ENTER THE NAME OF PASSENGERS");
string[] Name = new string[10];
for (int i = 0; i < Name.Length; i++)
{
    Name[i] = Console.ReadLine();

}
Console.WriteLine("NAME IN ASCENTING ORDER");
Array.Sort(Name);
foreach (string s in Name)
{
    Console.WriteLine(s);
}
Console.WriteLine("NAME IN DESCENTING ORDER");
Array.Reverse(Name);
foreach (string s in Name)
{
    Console.WriteLine(s);
}

Console.WriteLine("SEARCH ELEMENT");

string? Search = Console.ReadLine();
int flag = 0;
for (int i = 0; i < Name.Length; i++)
{
    if (Search == Name[i])
    {
        flag++;
    }
}

if (flag == 1)
{
    Console.WriteLine("The name is found");
}
else
{
    Console.WriteLine("The name is not found");
}
Console.WriteLine("The length of names in each element");
for (int i = 0; i < Name.Length; i++)
{
    int arrLength = Name[i].Length;
    Console.WriteLine(Name[i] + " : " + arrLength);
}
Console.WriteLine(" Split the name");
for (int i = 0; i < Name.Length; i++)
{
    var arrsplit = Name[i].Split(' ');
    Array.ForEach(arrsplit, s => Console.WriteLine(s));
}

for (int i = 0; i < Name.Length; i++)
{
    for (int j = i + 1; j < Name.Length; j++)
    {
        if (Name[i] == Name[j])
        {
            Console.WriteLine("The duplicate name is: " + Name[i]);
        }
    }
}






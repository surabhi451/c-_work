Console.WriteLine("Enter the name of passenger:");
string[] Name = new string[3];
for (int i = 0; i < Name.Length; i++)
{
    Name[i] = Console.ReadLine();
}

Console.WriteLine("Enter the destination :");
string[] Dest = new string[3];
for (int i = 0; i < Dest.Length; i++)
{
    Dest[i] = Console.ReadLine();
}

Console.WriteLine("Merge two array in one array:");
string[] Result = new string[Name.Length + Dest.Length];
int j = 0;
for (int i = 0; i < Name.Length; i++)
{
    Result[j] = Name[i];
    Result[j + 1] = Dest[i];
    j = j + 2;

}
for (int i = 0; i < Result.Length; i++)
{
    Console.WriteLine(Result[i]);
}
using System.Xml.Linq;

Console.WriteLine("Enter the limit:");
int Limit = int.Parse(Console.ReadLine());

Console.WriteLine("Enter " + Limit + " flight fare:");
double[] fare = new double[Limit];
for (int i = 0; i < fare.Length; i++)
{
    fare[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("Enter "+Limit+" destination:");
string[] des = new string[Limit];
for (int i = 0; i < des.Length; i++)
{
    des[i] = Console.ReadLine();
}
  
Console.WriteLine("display destination and fare:");
int item = Convert.ToInt32(Console.ReadLine());
item = 1;  
Console.Write("Flight fare: " +fare[item ]);
Console.Write(" & Destination: " + des[item ]);

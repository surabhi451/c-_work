Console.WriteLine("Enter the limit:");
int limit = int.Parse(Console.ReadLine());

double[] fare = new double[limit];
double[] temp = new double[limit * 2];
Console.WriteLine("Enter the flight fare:");
for (int i = 0; i < fare.Length; i++)
{
    fare[i] = Convert.ToDouble(Console.ReadLine());
}
int j = 0;
int k = 1;
for (int i = 0; i < fare.Length; i++)
{
    if (fare[i] % 2 == 0)
    {
        temp[j] = fare[i];
        j += 2;

    }
    else
    {
        temp[k] = fare[i];
        k += 2;
    }

}
Console.WriteLine(string.Join(",", temp));













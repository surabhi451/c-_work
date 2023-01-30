Console.WriteLine("enter an alphabet");
string alph = Console.ReadLine();
int[] arr = new int[] { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 153, 127 };
if (alph == "f" || alph == "F")
{
    for (int i = 0; i < 10; i++)
    {
        if (arr[i] % 2 != 0)
        {
            Console.WriteLine("F" + arr[i]);
        }
    }
}
else if (alph == "w" || alph == "W")
{
    for (int i = 0; i < 10; i++)
    {
        if (arr[i] % 2 == 0)
        {
            Console.WriteLine("W" + arr[i]);
        }
    }
}
else if (alph == "Q" || alph == "q")
{
    for (int i = 0; i < 10; i++)
    {
        int c = 0;
        for (int j = 2; j < arr[i] / 2; j++)
        {
            if (arr[i] % j == 0)
            {
                c++;
            }
        }
        if (c == 0)
        {
            Console.WriteLine("Q" + arr[i]);
        }
    }
}
else if (alph == "n" || alph == "N")
{
    int a = 0, c;
    int b = 1;
    int i = 0;
    while (i != 10)
    {
        if (a >= 0)
        {
            Console.WriteLine("N" + a);
            i++;
        }
        c = a + b;
        a = b;
        b = c;
    }
}
else if (alph == "a" || alph == "A")
{
    int i = 0;
    int a = 100;
    while (i != 10)
    {

        int sum = 0;
        int temp = a;
        while (a > 0)
        {
            int r = a % 10;
            sum = sum + (r * r * r);
            a = a / 10;
        }
        if (temp == sum)
        {
            Console.WriteLine("A" + temp);
            i++;
        }
        a++;
    }
}


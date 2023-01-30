Console.WriteLine("Enter the birth day:");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the birth month:");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the birth year:");
int year = int.Parse(Console.ReadLine());

Console.WriteLine("The date of birth is :" + day + " / " + month + " / " + year);

int CurrentYear = DateTime.Now.Year;
Console.WriteLine("Current year :" + CurrentYear);
int diffyear = (CurrentYear) - year;
Console.WriteLine("date of birth in years: " + diffyear);

int diffmonth = diffyear * 12;
Console.WriteLine("date of birth in month: " + diffmonth);

int diffweek = diffmonth * 4;
Console.WriteLine("date of birth in week: " + diffweek);

int diffday = diffweek * 7;
Console.WriteLine("date of birth in day: " + diffday);

int diffhours = diffday * 24;
Console.WriteLine("date of birth in hours: " + diffhours);

if ((0 == year % 4) && (0 != year % 100) || (0 == year % 400))
{
    Console.WriteLine("Year of birth is a leap year");
}
else
{
    Console.WriteLine("Year of birth is not a leap year");
}


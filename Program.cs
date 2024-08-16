// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int amount = 1234;
int months = 12;

int yearlyWage = CalculateYearlyWage(amount,months);

Console.WriteLine($"Yearly Wage: {yearlyWage} ");

Console.ReadLine();


static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    if(numberOfMonthsWorked == 12)
    return monthlyWage * (numberOfMonthsWorked + 1);

    return monthlyWage * numberOfMonthsWorked;
}

﻿// See https://aka.ms/new-console-template for more information
using PieShop;

Console.WriteLine("Hello, World!");

int amount = 1234;
int months = 12;

int yearlyWage = Utilities.CalculateYearlyWage(amount,months);

Console.WriteLine($"Yearly Wage: {yearlyWage} ");

Console.ReadLine();


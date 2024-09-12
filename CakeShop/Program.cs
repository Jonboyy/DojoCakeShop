// See https://aka.ms/new-console-template for more information

using CakeShop;

Console.WriteLine("Hello, World!");

var shop1 = new ShopOfTheCake();
shop1.CakeDay();
shop1.CalculateIncome();
Console.WriteLine(double.Round(shop1.Income, 2));
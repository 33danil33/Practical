//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = number % 2;
if (x ==1)
{
Console.Write("нет");
}
if (x ==0)
{
Console.Write("да");
}
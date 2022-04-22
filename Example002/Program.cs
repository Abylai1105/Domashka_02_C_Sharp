//using System;
//using static System.Console;
//Console.Clear();

int n;
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n > 99 ? n.ToString()[2] :n < -99 ? n.ToString()[3]: "Третьего символа нет");

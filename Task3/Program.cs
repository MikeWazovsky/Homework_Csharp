﻿//  Напишите программу, которая на вход принимает число и выдаёт, 
//  является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет


Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);


if (num % 2 == 0)
{
    Console.WriteLine("Yes");
}

 else
{
    Console.WriteLine("No");
}
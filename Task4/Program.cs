﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.Write("Enter number: ");
// string strNum = Console.ReadLine();
// int num = int.Parse(strNum);

// int num0 = 2;

// while (num0 <= num)
// {
//     Console.WriteLine(num0);
//   num0 = num0 + 2;
// }


Console.Write("Enter number: ");

int num = Convert.ToInt32(Console.ReadLine());

int num0 = 2;

while (num0 <= num)
{
    Console.WriteLine(num0);
  num0 = num0 + 2;
}
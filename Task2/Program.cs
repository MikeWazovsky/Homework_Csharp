﻿//    Напишите программу, которая принимает на вход три числа
//    и выдаёт максимальное из этих чисел.
//    2, 3, 7 -> 7
//    44 5 78 -> 78
//    22 3 9 -> 22


Console.Write("Enter number № 1: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number № 2: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

Console.Write("Enter number № 3: ");
strNum = Console.ReadLine();
int num3 = int.Parse(strNum);

if (num1 == num2)

{
    Console.WriteLine("Write diffrent numbers!");
}

else if (num1 == num3)

{
    Console.WriteLine("Write diffrent numbers!");
}
else if (num2 == num3)

{
    Console.WriteLine("Write diffrent numbers!");
}

else if
(num1 > num2 && num1 > num3)
{
    Console.WriteLine(num1);
}

else if (num2 > num1 && num2 > num3)

{
    Console.WriteLine(num2);
}

else if (num3 > num1 && num3 > num2)

{
    Console.WriteLine(num3);
}


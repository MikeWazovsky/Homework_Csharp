// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Enter number № 1 : ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number № 2: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

if (num1 > num2)
{
    Console.WriteLine(num1);
}


else if (num1 == num2)
{
    Console.WriteLine("Numbers are equal");
}


else if (num2 > num1)
{
    Console.WriteLine(num2);
}

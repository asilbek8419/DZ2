// int n = new Random().Next(100, 1000);
// Console.WriteLine(n);
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3);

//------------------------------------------------
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно

// 14 -> no
// 46 -> no
// 161 -> yes

// int n1 = 5;
// int n2 = 10;

// if (n1 == 5 & n2 == 100)
//     Console.WriteLine("hi");

// Console.Write("n = ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n % 7 == 0 & n % 23 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");
// --------------------------------------
// напишите программу которая будет принимать на входе два числа и выводить является ли второе число кракно первому


// Console.Write("n1 = ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("n2 = ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n1 % n2 == 0)
//     Console.WriteLine("кратно");
// else
//      Console.WriteLine($"не кратнo, остаток {n2 % n1}");

// --------------------------------------
// напишите программу которая будет принимать на входе два числа и выводить является одно число квадратом второго
// Console.Write("n1 = ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("n2 = ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n1 * n1 == n2 || n2 * n2 == n1)
//     Console.WriteLine("yes");
// else
//      Console.WriteLine("no");
//-------------------------------------------

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Напишите трехзначное число = ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(n / 10 % 10);

//------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Напишите трехзначное число = ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 100;
// int n2 = n % 10;

// if (n1 == 0)
//     Console.WriteLine("третьей цыфры нет");
// else
//     Console.WriteLine(n2);

// -----------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Напишите день недели(цыфровое обозначение) = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1 | n == 2 | n == 3 | n == 4 | n == 5)
    Console.WriteLine("Рабочий");
else if (n == 6 | n == 7)
    Console.WriteLine("Выходной");
else 
    Console.WriteLine("Это не день недели");
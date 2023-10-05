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

int Promt (string messege)
{
    Console.Write("Напишите число = ");
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /=10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цыфры нет");
        return false;
    }
    return true;
}
int number = Promt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}

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

// Console.Write("Напишите день недели(цыфровое обозначение) = ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n == 1 | n == 2 | n == 3 | n == 4 | n == 5)
//     Console.WriteLine("Рабочий");
// else if (n == 6 | n == 7)
//     Console.WriteLine("Выходной");
// else 
//     Console.WriteLine("Это не день недели");
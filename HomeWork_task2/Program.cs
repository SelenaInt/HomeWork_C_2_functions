// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите двух- или трех- значное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int characternNumber = 100;

if (number < characternNumber)
{
    Console.Write("В вашем числе нет третьей цифры");
}

else
{
    Console.WriteLine($"третья цифра вашего числа:  {number % 10}"); // int findThird = number % 10; сокращаем алгоритм
}

if (number > characternNumber)
{
    Console.Write("В вашем числе больше трех цифр");
}

// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// find second
// int first = number / 100;
// Console.WriteLine(first);

// int second = number / 10;
// Console.WriteLine(second);

// int Result(int number);

// int findSecond = second % 10;
// Console.WriteLine(findSecond);

int number = new Random().Next(100,1000);
Console.WriteLine(number);

int findSecond = (number / 10) % 10;
Console.WriteLine(findSecond);






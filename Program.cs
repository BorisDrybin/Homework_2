﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num % 100 / 10;

// if((num < 100)||(num >= 1000))
// {
//    Console.WriteLine("Число не трехзначное!");
// }
// else
// {
//     Console.WriteLine(result);
// }


// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// while(num > 999)
// {
//     num = num /10;
// }

// if(num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//    num = num % 10;
//    Console.WriteLine(num);
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num > 0 && num <= 7)
// {
//     if(num > 5)
//     {
//         Console.WriteLine("Выходной");
//     }
//     else
//     {
//         Console.WriteLine("Будний день");
//     }
// }
// else
// {
//     Console.WriteLine("Это не день недели");
// }
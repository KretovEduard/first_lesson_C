﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Numbers(int a)
{
   if (a == 1) Console.Write($" {a}");
   else
   {
        Console.Write($" {a},");
        Numbers(a-1);
   }
}

Numbers(n);
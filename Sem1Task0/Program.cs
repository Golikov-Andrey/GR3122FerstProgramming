﻿// //=============================================================================
// // # 0 Напишите программу, которая на вход принимает число и
// // выдаёт его квадрат (число умноженное на само себя).
// //=============================================================================

// string? inputLine = Console.ReadLine();
// if (inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);
//     int outNumber = 0;

//     DateTime d1 = DateTime.Now;
//     for (int i = 0; i < 10000000; i++)
//     {
//         outNumber = inputNumber * inputNumber;
//     }

//     DateTime d2 = DateTime.Now;
//     Console.WriteLine(d2 - d1);


//     //int outNumber = (int)Math.Pow(inputNumber,2);

//     Console.WriteLine(outNumber);
// }


// ====================================================================
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// ============================================================================

// First way

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 2;
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
if (num < 2)
{
    Console.WriteLine("Нет чётных чисел!");
}
else
{
    while (i <= num - 2)
    {
        Console.Write(i + ", ");
        i += 2;
    }
    Console.Write(i);
}

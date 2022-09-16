// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// //Вариант Евгения
// Console.Write("Введите число: ");
// string? inputLineA = Console.ReadLine();
// int  inputNumberA = int.Parse(inputLineA);

// if(inputNumberA%7==0 && inputNumberA%23==0)
// {
//     Console.Write("Число кратно одновременно 7 и 23");
// }
// else
// {
//     Console.Write("Число не кратно одновременно 7 и 23");
// }


// //Вариант Михаила
// int number, resultA, resultB;

// // запрашивает число у пользователь
// // (принимает текст запроса и команду выхода)
// int RequestNumber(string text = "Enter number", string exitCmd = "q")
// {
//     // цикле выполняется до введения целого число или "q"
//     while (true) 
//     {
//         Console.Write(text + ": ");
//         string? inputLine = Console.ReadLine();

//         //Игнорируем пробел
//         if (inputLine == null)
//         {
//             continue;
//         }
//         //Выходим из программы
//         if (inputLine.ToLower() == exitCmd)
//         {
//             Environment.Exit(0);
//         }
//         //Выдаем полученое число
//         if (int.TryParse(inputLine, out int number))
//         {
//             return number;
//         }
//     }
// }

// // чтение данных из сонсоли
// void ReadData()
// {
//     number = RequestNumber("Enter number");
// }

// // Определяем крат
// // Определяем кратность чисел
// void CalculateData()
// {
//     resultA = number % 7;
//     resultB = number % 23;
// }

// // Вывод данных
// void PrintData()
// {
//     if (resultA == 0 && resultB == 0)
//     {

//         Console.WriteLine("Число кртно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число не кртно 7 и 23");
//     }
// }


// ReadData();
// CalculateData();
// PrintData();

// string? inputLineA = Console.ReadLine();
// if (inputLineA != null) 
// Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA) % 23 == 0)) ? ("Кратно") : ("Не кратно"));

// ---------------------------------------------------------------------
//                                 Задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю
// ---------------------------------------------------------------------

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// считаем сумму элементов (с нечётным номером)
int EvenSumPos(int[] arr)
{
    int a = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        a += arr[i];
    }
    return a;
}

// ищем пары (одинаковые числа в массиве)
void FindSameInArr(int[] arr)
{
    List<int> tempNumbers = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length - 1; j++)
        {
            if ((arr[i] == arr[j]) && i != j && !tempNumbers.Contains(arr[i]))
            {
                PrintResult("Пара равная = " + arr[i] + " имеет индексы " + i + " и " + j);
                tempNumbers.Add(arr[i]);
            }
        }
    }
}

int[] arr = GenArray(50, 1, 10);

PrintArray(arr);
PrintResult("Сумма = " + EvenSumPos(arr));

FindSameInArr(arr);
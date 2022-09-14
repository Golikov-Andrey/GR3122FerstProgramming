// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// string LineNumbers(int numberN, int pow)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + Math.Pow(i,pow) + "\t";
//         ++i;
//     }
//     outLine = outLine + Math.Pow(numberN,pow);
//     return outLine;
// }

// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }


// int num = ReadData("Введите число N:");

// PrintResult(LineNumbers(num,1));
// PrintResult(LineNumbers(num,2));

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//Значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// // чтение данных из консоли
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.WriteLine(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // создаёт строчку от 1 до N(+i) и вторую от 1 до N^3(+i^3)
// void LineNumbersPow(int numberN, int pow)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i <= numberN)
//     {
//         Console.Write("{0,7}" ,Math.Pow(i, pow));
//         i++;
//     }
//     Console.WriteLine();
// }

// int num = ReadData("Введите число N: ");

// LineNumbersPow(num, 1);
// LineNumbersPow(num, 3);

// Метод считывания данных
double ReadData(string line)
{
    Console.Write(line);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод проверки палиндрома
bool PalindromeTest(double a)
{
    char[] charArray = a.ToString().ToCharArray();
    Array.Reverse(charArray); // Тут просто разворачиваем массив
    double reversedArray = double.Parse(charArray);
    if(reversedArray == a) // Проверка на палиндром
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Метод вывода результата
void PrintResult(bool res)
{
    if(res)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}

double inputNumber = ReadData("Введите число: ");
bool res = PalindromeTest(inputNumber);
PrintResult(res);
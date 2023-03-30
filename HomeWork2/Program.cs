// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondNum(int num) 
// {
//     int ten = num / 10;
//     int result = ten % 10;

//     return result;
// }

// int getNum = Convert.ToInt32(Console.ReadLine());
// int newNum = SecondNum(getNum);

// Console.WriteLine(newNum);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int Prompt(string massage)
// {
//     Console.Write(massage);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThird(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("3 цифры нет");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("ВВедите число > ");
// if (ValNumber(number)) 
// {
//     Console.WriteLine(GetThird(number));
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool Holiday(int day)
// {
//     if (day >= 6 && day < 8)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Holiday(day));
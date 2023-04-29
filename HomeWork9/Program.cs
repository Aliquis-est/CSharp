// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"


// void SortToMin(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         SortToMin(n, count + 1);
//         Console.Write(count + " ");
//     }
// }

// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// SortToMin(num, count);




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumOfMAndN(m - 1, n));
// }

// int SumOfMAndN(int m, int n)
// {
//     int result = m;
//      if (m == n)
//         return 0;

//     else if (m > n)
//      {
//         Console.WriteLine("Ошибка ввода. Значение M должно быть меньше значения N");
//      return 0;
//      }

//     else
//     {
//         m++;
//         result = m + SumOfMAndN(m, n);
//         return result;
//     }
// }


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// void AkkermanResult(int m, int n)
// {
//     Console.Write(AkkermanFunction(m, n)); 
// }

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return AkkermanFunction(m - 1, 1);
//     }
//     else
//     {
//         return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
//     }
// }


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanResult(m,n);
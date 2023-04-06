// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// int Degree(int num1, int num2)
// {
//     int num = 1;
//     for (int i= 0; i < num2; i++)

//     num *= num1;
//     return num;
// }


// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

//  int res = Degree(a, b);
// Console.WriteLine($"Число {a} в степени {b} равно {res}");




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumNum(int num)
// {
//     int res = 0;
//     while(num > 0)
//     {
//         res += num % 10;
//         num = num / 10;
//     }
//     return res;
// }

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = SumNum(a);
// Console.WriteLine(result);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



// (взято из решения, но есть проблема с запуском)
// int [] GetArray(int Length, int minValue, int maxValue)
// {
//     int [] array = new int[Length];
//     Random random = new Random();
//     for (int i =0; i < Length; i++)
//     array[i] = random.Next(minValue, maxValue + 1);
//     return array;
// }

// int [] PrintArray(int array)
// {
//    System.Console.Write("[");
//     for (int i =0; i < array.length; i++)
//     {
//            System.Console.Write($"{array[i]}, ");

//     }
//          System.Console.Write($"{array[array.length - 1]}");
//     System.Console.Write("]");

// }

// int Prompt( string massage)
// {
//     System.Console.Write(massage);
//     string ReadInput = System.Console.ReadLine();
//     int result = int.Parse(ReadInput);
//     return result;
// }

// int length = Prompt("Длинна массива: ");
// int min = Prompt("Начальное значение: "); 
// int max = Prompt("Конечное значение: "); 
// int[] array = GetArray(length, min, max);
// PrintArray(array);



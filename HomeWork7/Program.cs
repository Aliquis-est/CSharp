// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// double[,] CreateArray(int[] array, int minValue, int maxValue)
// {

//     double[,] doubleArray = new double[array[0], array[1]];
//     for (int i = 0; i < array[0]; i++)
//     {
//         for (int j = 0; j < array[1]; j++)
//         {
//             doubleArray[i, j] = (new Random().NextDouble() + new Random().Next(minValue, maxValue));
//         }
//     }
//     return doubleArray;
// }
// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array[i, j], 2) + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] CheckArr(int m, int n)
// {
//     int[] checkArray = new int[2];
//     while (m < 1 || n < 1)
//     {
//         if (m < 1)
//         {
//             Console.Write("Введите корректное количество строк: ");
//             m = Convert.ToInt32(Console.ReadLine());
//         }
//         if (n < 1)
//         {
//             Console.Write("Введите корректное количество столбцов: ");
//             n = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     checkArray[0] = m;
//     checkArray[1] = n;
//     return checkArray;
// }


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[] size = CheckArr(rows, colums);

// Console.Write("Введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] dArray = CreateArray(size, minValue, maxValue);

// ShowArray(dArray);






// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//

// int[,] CreateRealyRandomArray2D()
// {
//     int rows = new Random().Next(2, 11);
//     int columns = new Random().Next(2, 11);
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(-100, 100);
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[] CheckInput(int m, int n)
// {
//     int[] checkArray = new int[2];
//     while (m < 0 || n < 0)
//     {
//         if (m < 0)
//         {
//             Console.Write("Позиция по горизонтали не может быть отрицательной. Введите повторно: ");
//             m = Convert.ToInt32(Console.ReadLine());
//         }
//         if (n < 0)
//         {
//             Console.Write("Позиция по вертикали не может быть отрицательной. Введите повторно: ");
//             n = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     checkArray[0] = m;
//     checkArray[1] = n;
//     return checkArray;
// }

// int[,] RealyRandomArray = CreateRealyRandomArray2D();

// Console.Write("Введите значение по горизонтали: ");
// int vertical = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение по вертикали: ");
// int horizontal = Convert.ToInt32(Console.ReadLine());

// int[] PositionArray = CheckInput(horizontal, vertical);

// if (PositionArray[0] > RealyRandomArray.GetLength(0) || (PositionArray[1]) > RealyRandomArray.GetLength(1))
// {
//     Console.WriteLine();
//     Console.WriteLine("Такого элемента нет.");
//     Console.WriteLine("Массив:");
//     Show2DArray(RealyRandomArray);
// }
// else
// {
//     Console.WriteLine();
//     Console.WriteLine($"Значение элемента на заданной позиции: {RealyRandomArray[PositionArray[0], PositionArray[1]]}");
//     Console.WriteLine("Массив:");
//     Show2DArray(RealyRandomArray);
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);

        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] myArray = CreateArray();
ShowArray(myArray);

Console.Write("Среднее арифметическое элементов: ");

for (int j = 0; j < myArray.GetLength(1); j++)
{
    int sum = 0;
    
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        
        sum = sum + myArray[i,j];
    }
double result = Math.Round(Convert.ToDouble(sum) / myArray.GetLength(1), 2);
Console.WriteLine("Среднее арифметическое столбца " + (j+1) + " равно " + result);
}
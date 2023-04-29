// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] CreateArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     //Возможно это избыточное решение
//     Console.Write("Введите минимальное значение: "); 
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);

//         }
//     }
//     return array;
// }
// void ShowArray(int[,] array)
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


// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] myArray = CreateArray();
// ShowArray(myArray);
// Console.WriteLine("Массив после сортировки по убыванию: ");
// SortArray(myArray);
// ShowArray(myArray);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] CreateArray(int rows)
// {

//     int colums = rows;
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(2, 100);

//         }
//     }

//     return array;
// }



// void ShowArray(int[,] array)
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


// int SumOfElements(int[,] myArray)
// {
//     int count = 1;
//     int min = 0;
//     int sum = 0;
//     int result = 0;


//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {


//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             sum = sum + myArray[i, j];

//         }

//         if (min == 0)
//         {
//             min = sum;
//             result = count;
//         }

//         if (sum < min)
//         {
//             min = sum;
//             result = count;
//         }

//         count++;

//         sum = 0;
//     }

//     return result;
// }


// Console.Write("Введите размер массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(rows);

// ShowArray(myArray);
// int rowNumber = SumOfElements(myArray);
// Console.WriteLine("Строка с наименьшей суммой элементов: " + rowNumber);







// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// int[,] CreateArray(int rows, int colums)
// {

//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(2, 10);

//         }
//     }

//     return array;
// }



// void ShowArray(int[,] array)
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


// int[,] ArrayResult(int[,] firstArray, int[,] secondArray, int rows, int colums)
// {
// 	int[,] arrayResult = new int[rows, colums]; 
// 		for (int i = 0; i < firstArray.GetLength(0); i++)
//     {
// 		for (int j = 0; j < firstArray.GetLength(0); j++)

// 		{
// 			arrayResult[i,j] = firstArray[i,j] * secondArray[i,j];		
// 		}
// 	}
// 	return arrayResult;
// } 


// Console.Write("Введите размер матрицы: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// int colums = rows;

// int[,] firstArray = CreateArray(rows, colums);
// ShowArray(firstArray);
// int[,] secondArray = CreateArray(rows, colums);
// ShowArray(secondArray);

// int[,] resultArray = ArrayResult(firstArray, secondArray, rows, colums);
// ShowArray(resultArray);







// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// void ShowIndex(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// void CreateArray3D(int[,,] array)
// {
//     int count = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[k, i, j] += count;

//                int num = new Random().Next(1, 10);
//                count = count + num;
//             }
//         }
//     }
// }

// int[,,] array3D = new int[2, 2, 2];
// CreateArray3D(array3D);
// ShowIndex(array3D);





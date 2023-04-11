// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i += 1)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int CountNumbers(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < (array.Length - 1); i++)
//         if (array[i] % 2 == 0)
//             count++;
// return count;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreateArray(size);

// Console.Write("Новый массив: ");
// ShowArray(newArray);
// Console.WriteLine($"Количество четных чисел: {CountNumbers(newArray)}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.



// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(1, 10000);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i += 1)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int SumNumber(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//         sum += array[i];
//     return sum;
// }


// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateArray(size);

// Console.Write("Новый массив: ");
// ShowArray(newArray);
// Console.WriteLine($"Сумма нечетных чисел: {SumNumber(newArray)}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100); // в условиях этого нет, но я решила ограничить ввод чисел до 100
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double DifferenceMaxMin(double[] newArray)
{
    double max = newArray[0];
    double min = newArray[0];
    for (int i = 1; i < newArray.Length; i++)
    {
        if (newArray[i] > max)
            max = newArray[i];
        if (newArray[i] < min)
            min = newArray[i];
    }
    double result = max - min;
    return result;

}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateArray(size);
Console.Write("Сгенерированный массив: ");
ShowArray(myArray);
Console.Write($"Разница между максимальным и минимальным значением {Math.Round(DifferenceMaxMin(myArray), 2)}");
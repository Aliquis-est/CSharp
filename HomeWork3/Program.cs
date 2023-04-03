// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// bool Palindrom(int n)
// {
//     int Num = n;
//     int New = 0;
//     while (n > 0)
//     {
//         int digit = n % 10;
//         New = New * 10 + digit;
//         n = n / 10;
//     }
//     if (New == Num)
//         return true;
//     else 
//     return false;
// }

// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (Palindrom(number) == true)
//     Console.WriteLine("Это палиндром.");
// else Console.WriteLine("Это не палиндром.");




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// double Length(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }

// Console.Write("Введите x точки А: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите у точки А: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z точки А: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// Console.Write("Введите x точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите у точки B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z точки B: ");
// int z2 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine();

// double distance = Math.Round(Length(x1, y1, z1, x2, y2, z2), 2);

// Console.WriteLine("Расстояние между точками А и В равно " + distance);





// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine($"{index} - {Math.Pow(index, 3)}");
        index += 1;
    }
}
Console.WriteLine("Введите натуральное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Cube(Num);
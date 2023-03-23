// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵); 2, 4 -> 16

// Console.Write("Введите число для возведения в степень: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень в которую будет возводится число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;

// for (int i = 1; i < b; i++)
// {
// step = step * a;
// }
// Console.WriteLine("Полученный результат: " + step);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12;

// Console.Write("Введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("Сумма всех цифр в числе равна: " + sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

// int [] numbers = new int[8];
// Console.Write("Заданный массив из случайных чисел: ");

// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 11);
//     Console.Write(" " + Method (i) + " ");
//  }
// int Method (int a)
// {
//     return numbers[a];
// }


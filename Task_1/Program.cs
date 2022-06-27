//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Enter three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// //  int remains = number % 100;
// //   Console.WriteLine($"The second digit: {remains / 10}");

// int remains = number % 10;
// Console.WriteLine(remains);
// int q = number / 10;
// Console.WriteLine(q);
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int threedigit = number % 1000;
        Console.WriteLine($"The third number: {threedigit}");


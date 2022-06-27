//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter number 1-7");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number == 1)
    {
        Console.WriteLine("Monday");
        Console.WriteLine("The day is not a weekend");
    }
    if (number == 2)
    {
        Console.WriteLine("Tuesday");
        Console.WriteLine("The day is not a weekend");
    }
    if (number == 3)
    {
        Console.WriteLine("Wednesday");
        Console.WriteLine("The day is not a weekend");
    }
    if (number == 4)
    {
        Console.WriteLine("Thursday");
        Console.WriteLine("The day is not a weekend");
    }
    if (number == 5)
    {
        Console.WriteLine(" Friday");
        Console.WriteLine("The day is not a weekend");
    }
    if (number == 6)
    {
        Console.WriteLine("Saturday");
        Console.WriteLine("The day is a weekend");
    }
    if (number == 7)
    {
        Console.WriteLine("Sunday");
        Console.WriteLine("The day is a weekend");
    }
}
else 
{
        Console.WriteLine("Enter only 1-7 numbers");
}
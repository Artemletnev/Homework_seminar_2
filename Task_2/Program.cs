//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
string meaning = number.ToString ();
Console.WriteLine(meaning[2]);


//ver2
// if (number > 99 && number < 1000)
//     {
//         int threedigit = number % 10;
//         Console.WriteLine($"The third number: {threedigit}");
//     }
// if (number > 999  && number < 10000)
//     {
//         int fourdigit = number % 100;
//         Console.WriteLine($"The third number: {fourdigit / 10}");
        
//     }
// if (number > 9999  && number < 100000)
//     {
//         int fivedigit = number % 1000;
//         Console.WriteLine($"The third number: {fivedigit / 100}");
        
//     }

// if (number < 100)
//     {
//         Console.WriteLine("There is no third number");
//     }



















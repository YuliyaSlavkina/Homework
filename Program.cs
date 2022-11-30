// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


// Console.Write("Enter first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter socond number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.WriteLine("max = " + number1);
//     Console.WriteLine("min = " + number2);
// }
// else
// {
//    Console.WriteLine("max = " + number2);
//    Console.Write("min = " + number1); 
// }

// Второй вариант с учётом, если введут одинаковые числа

// Console.Write("Enter first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter socond number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.WriteLine("max = " + number1);
//     Console.WriteLine("min = " + number2);
// }
// else if (number2 > number1)
// {
//    Console.WriteLine("max = " + number2);
//    Console.Write("min = " + number1); 
// }
// else 
//     Console.WriteLine ("Error. Enter different numbers, pleas.");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter socond number: ");
int number2  = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int number3  = Convert.ToInt32(Console.ReadLine());

if ( number1 > number2 && number1 > number3) 
{
    Console.WriteLine("max = " + number1);
}
else if (number2 > number1 && number2 > number3) 
{
    Console.WriteLine("max = " + number2);
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine("max = " + number3);
}
else
{
    Console.WriteLine("Error. Pleas, try to enter different numbers");
}


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number%2==0)
//     Console.Write("This is en even number");
// else
//     Console.Write("This is not even number");


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// while (count <= number)
// {
//     Console.Write(count + " ");
//     count = count + 2;
// }

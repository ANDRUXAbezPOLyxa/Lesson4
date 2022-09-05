// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число А");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int b =int.Parse(Console.ReadLine());
double c = Math.Pow(a,b);
Console.WriteLine("число " + a + " в степени " + b + "=>" + c);
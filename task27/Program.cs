// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число: ");
int n = int.Parse(Console.ReadLine());
if (n>0 && n < 10)
{
    Console.WriteLine(n);
}
if (n >= 10 && n <= 99)
{
    int a = n/10;
    int b = n%10;
    int c = a + b;
    Console.WriteLine(c);
}
if (n >= 100 && n <= 999)
{
    int a = n%10;
    int b = (n%100)/10;
    int d = n/100;
    int c = a + b + d;
    Console.WriteLine(c);
}
if (n >= 1000 && n <= 9999)
{
    int a = n%10; 
    int b = (n%100)/10;
    int d = n/1000; 
    int e = (n%1000)/100;
    int c = a + b + d + e;
    Console.WriteLine(c);
}
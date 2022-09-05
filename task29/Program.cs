//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = new int[8];
void Filler(int [] fill)
{
    int n = fill.Length;
    int i =0;
    while (i < n)
    {
        fill[i] = new Random().Next(1,99);
        i++;
    }
}
void Print(int [] print)
{
    int p = print.Length;
    int j = 0;
    while (j < p)
    {
        Console.WriteLine(print[j]);
        j++;
    }
}
Filler(array);
Print(array);
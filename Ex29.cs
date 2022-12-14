// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
// N: 3 [9, 4, 12] => 2097
//{ 0, 1, 0, 0, 1, 0, 1, 0 };
double[] a = new double[15];
// {0,0,0,0,0,0,0,0,0,0,0,0,9,4,12};
for (int i = 0; i < 15; i++)
{
    a[i] = new Random().Next(0, 14);
    Console.Write($"|{a[i]}|");

}
Console.WriteLine();
double dc = 0;
//int N = Convert.ToInt32(Console.ReadLine());
for (int i = 14; i >= 0; i--)
{
    Console.Write($"{a[i]}");
    double degree = Math.Pow(15, 14 - i);
    dc += (a[i] * degree);
}
Console.WriteLine();
Console.Write($"{dc}");


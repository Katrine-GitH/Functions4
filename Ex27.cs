// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Строки использовать нельззя
int Sum = 0;
// задали размер массива
Console.WriteLine("число равное размеру массива");
int N = int.Parse(Console.ReadLine());
int[] Array = new int[N];
//через цикл присваиваем значения ячейкам массива
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Напишите число по {i} индексу");
    int readnumber = int.Parse(Console.ReadLine());
    Array[i] = readnumber;
    //вывод массива. через строку
    // Console.WriteLine($"Index: {i} = {readnumber}");
}
// foreach (int i in Array)
{
    foreach (int i in Array) ;
}
for (int i = 0; i < N; i++)
{
    // Console.Write($"{i}");
    //Console.Write(Array[i]);
    Sum += Array[i];
}
Console.WriteLine();
Console.WriteLine(Sum);
//Array = int.Parse(Console.ReadLine());

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow

// задали размер массива
Console.WriteLine("число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("число B");
int B = int.Parse(Console.ReadLine());
//number =A^B
int number=1;
for (int i=0; i<B; i++)
{
    number*= A;
}
Console.WriteLine($"число A в натуральной степени B:{number}");

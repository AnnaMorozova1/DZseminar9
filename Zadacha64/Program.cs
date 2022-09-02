// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.

Console.WriteLine("Введите значение M:  ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N:  ");
int N = int.Parse(Console.ReadLine());
for(int i=M; i<=N; i++)
{
    
    Console.Write(i + " ");
}
Console.WriteLine();



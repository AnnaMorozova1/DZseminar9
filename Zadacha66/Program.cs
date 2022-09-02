// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение М: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
int summ = 0;
for (int i = M; i <= N; i++)
{
    summ += i;
}
Console.WriteLine("\n" + "Результат: " + summ);
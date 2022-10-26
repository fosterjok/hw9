//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int n;
Console.Write($"Введите число:  ");
int.TryParse(Console.ReadLine(), out n);
int m;
Console.Write($"Введите число:  ");
int.TryParse(Console.ReadLine(), out m);

int sum = 0;
if (m > n)
    for (int i = n; i <= m; i++)
    {
        sum = sum + i;
    }

else
    for (int i = m; i <= n; i++)
    {
        sum = sum + i;
    }

Console.Write($" {sum}");
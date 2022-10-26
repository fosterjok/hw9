/*int n ;
Console.Write($"Введите число:  ");
int.TryParse (Console.ReadLine(), out n);

int Factorial (int _n)
{
    if (_n<=1)
    return 1;
    else return _n*Factorial(_n-1);
}

Console.Write($"{Factorial(n)}");*/

int n ;
Console.Write($"Введите число:  ");
int.TryParse (Console.ReadLine(), out n);

for (int i = 1; i <= n; i++)
{   
    
    Console.Write($"{i} ");
}


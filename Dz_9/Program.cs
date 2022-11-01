//Задача 64
/*
void showNumber (int n)
{
    if (n>=1)
    {   
        Console.Write (n +" ");
        showNumber(n-1);
    }
}


Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
showNumber(n);
*/

//Задача 66
/*
int FindSum(int n, int m)
{   int Sum=m;
    if(n>=m)
    {
        return  Sum += FindSum(n,m+1);
    } else 
    {
        return 0;
    }
}
Console.WriteLine("Введите значение m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n = ");
int n = Convert.ToInt32(Console.ReadLine());
int Res = FindSum(n,m);
Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {Res}");
*/

//Задача 68
/*
int Ackermann(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.Write("Число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Ackermann (m, n));
*/
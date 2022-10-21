//Задача 25

/*
double DegreeNumber(double a, double b)
{
    return Math.Pow(a, b);
}
Console.WriteLine("Введите число ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите его степень ");
double b = Convert.ToDouble(Console.ReadLine());
double result = DegreeNumber(a, b);
Console.WriteLine($"Число {a} в степени {b} равно {result}");
*/

//Задача 27
/*
void SumOfNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.WriteLine(sum);
}
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
SumOfNum(num);
*/

//Задача 29

/*
void newArray (int size, int min, int max) 
{
    int [] newArray= new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min,max+1);
    }
    var str = string.Join(" ", newArray);

    Console.WriteLine(str);
}

Console.Write("Введите размер массива ");
int userSize = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите минимальное значение массива ");
int min= Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите максимальное значение массива ");
int max= Convert.ToInt32(Console.ReadLine()); 
newArray(userSize,min,max);
*/
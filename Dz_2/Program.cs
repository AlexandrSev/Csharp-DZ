// Задание 10

/*
int SecondDigitOfNumber(int num)
{
    int ed = num % 10;
    int hundred = num / 100;
    int currentSum = hundred * 100 + ed;
    int result = (num - currentSum) / 10;
    return result;
}
Console.WriteLine("Введите число  ");                                         
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondDigitOfNumber(num);
Console.WriteLine($" {result}");
*/

// Задание13

/*
void SecondIndexOfNumber(int num)
{
    if (num >= 100)
       Console.WriteLine($"-> {num.ToString()[2]}");
    else 
        Console.WriteLine("-> Третьей цифры нет");
}
Console.WriteLine("Введите число  ");
int num = Convert.ToInt32(Console.ReadLine());
SecondIndexOfNumber(num);
*/
// Задача 15

/*
bool NeedlyDigit(int num)
{
    if (num > 5)
    return true;
    else
    return false;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
bool Weekend = NeedlyDigit(num);
Console.WriteLine(Weekend);
*/
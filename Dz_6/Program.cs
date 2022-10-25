//Задание 41
/*
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество значений больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
*/

//Задача 43
/*
void InterPoint(double b1, double k1, double b2, double k2)
{   
    double x = (b1 - b2) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / ( k2 - k1);
    if(k1 == k2) Console.WriteLine("Точки не пересекаются");
    else Console.WriteLine($"Точки пересекаются ({x};{y})");
}

Console.WriteLine("Введите число b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1 :");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
InterPoint(b1, k1, b2, k2);
*/
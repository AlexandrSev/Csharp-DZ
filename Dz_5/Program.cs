//Задача 34
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] Array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next (minValue, maxValue + 1);
    }
    return Array;
}

void ShowArray(int[] array)
{
    Console.Write("Массив = ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i]+ " ");
    }
}


void CountArray (int[] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i]%2)==0)
        Count++; 
    }
    Console.WriteLine($"Четных {Count}");
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] Array = CreateRandomArray(a, min, max);
ShowArray(Array);
CountArray (Array);
*/

//Задача 36
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] Array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next (minValue, maxValue + 1);
    }
    return Array;
}

void ShowArray(int[] array)
{
    Console.Write("Массив = ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i]+ " ");
    }
}


void summOddElements (int[] array)
{
    int Count = 0;
    for (int i=1; i < array.Length; i++)
    {
        if ((i%2)!=0)
        Count +=array[i]; 
 
    }
     Console.WriteLine($"Сумма нечетных элементов = {Count}");
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] Array = CreateRandomArray(a, min, max);
ShowArray(Array);
summOddElements (Array);
*/

//Задача 38

/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] Array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next (minValue, maxValue + 1);
    }
    return Array;
}

void ShowArray(int[] array)
{
    Console.Write("Массив = ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i]+ " ");
    }
}

void CountArray (int [] array)
{
    int maxInArray = array[0];
    int minInArray = array[0];
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]>maxInArray)
        maxInArray =array[i]; 
        else
        {
            if (array[i]<minInArray)
            minInArray =array[i]; 
        }
        
    }
    Console.WriteLine($"Разница >>> {maxInArray-minInArray }");

}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] Array = CreateRandomArray(a, min, max);
ShowArray(Array);
CountArray(Array);
*/
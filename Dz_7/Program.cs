// Задача 47
/*
void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Количество строк = ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lines, columns];
CreateArray(numbers);
PrintArray(numbers);
*/

//Задача 50
/*
int [,] CreateRandomArray(int m, int n)
{
    int [,] Array2D = new int[m,n];
    for(int i = 0; i<m ;i++)
    {
        for(int j = 0; j<n; j++)
        {
            Array2D[i,j] = new Random().Next(-100,100);
        }
    }
    return Array2D;
}
void ShowArray(int [,] Array2D)
{
    for(int i = 0; i<Array2D.GetLength(0);i++)
    {
        for(int j = 0; j<Array2D.GetLength(1); j++)
        {
            Console.Write($" {Array2D[i,j]} ");
        }
        Console.Write("\n");
    }
}
void NumberContain(int[,] Array2D,int NColumn,int NRow)
{
    if(Array2D.GetLength(0)>NRow-1 && Array2D.GetLength(1)>NColumn-1)
    {
        Console.WriteLine($"Элемента по этим индексам: {Array2D[NRow-1,NColumn-1]}");
    }
    else Console.WriteLine("Данного элемента не существует");
}
Console.WriteLine("Введите количество строк в вашем массиве:");
int Row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в вашем массиве:");
int Column = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d = CreateRandomArray(Row,Column);
ShowArray(Arr2d);
Console.WriteLine("Введите строку нужного элемента:");
int NRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец нужного элемента:");
int NColumn = Convert.ToInt32(Console.ReadLine());
NumberContain(Arr2d,NColumn, NRow);
*/


//Задача 52
/*
int [,] Create2DRandomArray(int minValue, int maxValue)
{
    int[,] newArray = new int[3, 3];                        
    for(int i = 0; i < 3; i++)                                   
        for(int j = 0; j < 3; j++)                             
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
        return newArray;
}
void Show2DArray(int[,] array)
{
    for(int i = 0; i < 3; i++) 
    {                                   
        for(int j = 0; j < 3; j++)                             
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();}
}
void Average(int[,] array)
{   
    
    for(int j = 0; j < 3; j++)  
    {   
        int sum = 0;                                
        for(int i = 0; i < 3; i++)                             
        {
            sum += array[i,j]; 
        }
        Console.WriteLine();
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {(float)sum / 3}");
    }                        
}
Console.WriteLine("Введите минимальное значение:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение:");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(minValue, maxValue);
Show2DArray(myArray);                                                      
Average(myArray);
*/
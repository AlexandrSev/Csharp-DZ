//Задание 54
/*
int [,] CreateRandomArray(int rows, int columns)
{
    int [,] Array = new int[rows,columns];
    for(int i = 0; i<rows ;i++)
    {
        for(int j = 0; j<columns; j++)
        {
            Array[i,j] = new Random().Next(0,100);
        }
    }
    return Array;
}
void ShowArray(int [,] Array)
{
    for(int i = 0; i<Array.GetLength(0);i++)
    {
        for(int j = 0; j<Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int [,] SortArr(int[,] Arr)
{
    for(int j =0; j < Arr.GetLength(0); j++)
    {
        for(int m = 0; m < Arr.GetLength(1); m++)
        {
            for(int i = 0; i < Arr.GetLength(1)-1; i++)
            {
                if(Arr[j,i]<Arr[j,i+1])
                {
                    int b = Arr[j,i];
                    Arr[j,i]=Arr[j,i+1];
                    Arr[j,i+1]=b;
                }
            }
        }
    }
    return Arr;
}
Console.WriteLine("Введите количество строк в двумерном массиве ");
int Row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерном массиве ");
int Column = Convert.ToInt32(Console.ReadLine());
int[,] Arr = CreateRandomArray(Row,Column);
ShowArray(Arr);
Console.WriteLine();
int[,] Arr1 = SortArr(Arr);
ShowArray(Arr1);
*/

//Задача 56
/*
int [,] CreateRandomArray(int rows, int columns)
{
    int [,] Array = new int[rows,columns];
    for(int i = 0; i<rows ;i++)
    {
        for(int j = 0; j<columns; j++)
        {
            Array[i,j] = new Random().Next(0,100);
        }
    }
    return Array;
}
void ShowArray(int [,] Array)
{
    for(int i = 0; i<Array.GetLength(0);i++)
    {
        for(int j = 0; j<Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SumElementsFromRow(int[,] array, int i)
{
    int rowSum = array[i, 0];
    for(int j = 1; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    return rowSum;
}

int[,] RowWithlowlestSum(int[,] array)
{
    int minSumRow = 0;
    int rowSum = SumElementsFromRow(array, 0);
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int tempRowSum = SumElementsFromRow(array, i);
        if(rowSum > tempRowSum)
        {
            rowSum = tempRowSum;
            minSumRow = i;
        }
        else Console.WriteLine($"\n{minSumRow + 1} - строкa с наименьшей суммой. Сумма элементов в указанной строке -> {rowSum} ");
    }
    return array;
}


Console.WriteLine("Введите количество строк в двумерном массиве ");
int Row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в двумерном массиве ");
int Column = Convert.ToInt32(Console.ReadLine());
int[,] Arr = CreateRandomArray(Row,Column);
ShowArray(Arr);

int[,] myArray = CreateRandomArray(Row, Column);
ShowArray(myArray);
myArray = RowWithlowlestSum(myArray);
Console.WriteLine();
*/

//Задача 58
/*
int [,] CreateRandomArray(int row, int column)
{
    int [,] Array = new int[row,column];
    for(int i = 0; i<row ;i++)
    {
        for(int j = 0; j<column; j++)
        {
            Array[i,j] = new Random().Next(0,10);
        }
    }
    return Array;
}
void ShowArray(int [,] Array)
{
    for(int i = 0; i<Array.GetLength(0);i++)
    {
        for(int j = 0; j<Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] ArrayMulti(int [,] Arr1, int[,] Arr2)
{
    if(Arr1.GetLength(1)==Arr2.GetLength(0))
    {
        int [,] Arr3 = new int[Arr1.GetLength(0),Arr2.GetLength(1)];
        for(int i = 0; i<Arr3.GetLength(0);i++)
        {
            for(int j = 0; j<Arr3.GetLength(1); j++)
            {
                int Res = 0;
                for(int m = 0; m<Arr1.GetLength(1);m++)
                {
                    Res+=(Arr1[i,m]*Arr2[m,j]);
                }
                Arr3[i,j]=Res;
            }
           
        }
        return Arr3;
    }
    else 
    {
        Console.WriteLine("Невозможно выполнить умножение");
        int [,] Arr3 = new int[1,1];
        Arr3[0,0]=0;
        return Arr3;
    }
}
Console.WriteLine("Введите количество строк в первом массиве ");
int Row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в первом массиве ");
int Column = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d1 = CreateRandomArray(Row,Column);
Console.WriteLine("Введите количество строк во втором массиве ");
int Row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов во втором массиве ");
int Column2 = Convert.ToInt32(Console.ReadLine());
int[,] Arr2d2 = CreateRandomArray(Row2,Column2);
ShowArray(Arr2d1);
Console.WriteLine();
ShowArray(Arr2d2);
int[,] Arr2d3 = ArrayMulti(Arr2d1,Arr2d2);
Console.WriteLine();
ShowArray(Arr2d3);
*/

//Задача 60
/*
int [,,] CreateRandomArray(int x, int y,int z)
{
    if(x*y*z<100)
    {
    int [,,] Array = new int[x,y,z];
    int num = 0;
    for(int i = 0; i<x ;i++)
    {
        for(int j = 0; j<y; j++)
        {   for(int g = 0; g<z; g++)
            {
                 Array[i,j,g] = 10+num;
                 num++;
            }   
           
        }
    }
    return Array;
    }
    else
    {
        Console.WriteLine("Массив не создан");
        int [,,] Array = new int[1,1,1];
        Array[0,0,0]=0;
        return Array;
    }
}
void ShowArray(int [,,] Array)
{
    for(int i = 0; i<Array.GetLength(0);i++)
    {
        for(int j = 0; j<Array.GetLength(1); j++)
        {
            for(int g = 0; g<Array.GetLength(2); g++)
            {
                Console.Write($" {Array[i,j,g]} ({i},{j},{g}), ");
            }
        }
    }
}
Console.WriteLine("x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z = ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] Arr = CreateRandomArray(x,y,z);
ShowArray(Arr);
*/
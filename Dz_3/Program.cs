//Задача 19
/*
Console.Write("Введите число ");
string? number = Console.ReadLine();
void PolindromeNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"{number} -> Да.");
  }
  else Console.WriteLine($"{number} -> Нет");
}
if (number!.Length == 5)
{
  PolindromeNumber(number);
}
else Console.WriteLine($"{number} -> Ошибка! Попробуй ввести число из 5 символов ");
*/

//Задача 21
/*
double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
   return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.WriteLine("Введите x1:");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y1:");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z1:");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите x2:");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y2:");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z2:");
double z2 = Convert.ToDouble(Console.ReadLine());

double findDistance = FindDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние ={findDistance} ");
*/

//Задача 23
/*
void Cube(int number)
{
    int step = 1;
    while (step <= number)
    {
        Console.WriteLine($"куб {step} равен {step * step * step}");
        step++;
    }
    
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
*/
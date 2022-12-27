// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите сколько будет чисел");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
int count = 0;
while (i <= num);
{
    Console.WriteLine("Введите число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    i++;
    if (num1 > 0);
    {
        count++;
    }
}
Console.WriteLine("Кол-во числе больше 0 равно:" +count);

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine);
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine);
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine);
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine);
double x = (b1 - b2)/(k2 - k1);
double y = k2 * x + b2;
Console.WriteLine("Точка пересечения:"+" "+"("+x+","+y+")");

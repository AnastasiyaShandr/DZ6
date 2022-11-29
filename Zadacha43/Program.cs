// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = (k1 * x + b1);
    Console.WriteLine($"Прямые с заданными уравнениями имеют точку пересечения: [{x},{y}]");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают и имеют бесконечное количество решений");
}
else if (k1 / k2 == 1)
{
    Console.WriteLine("Прямые с заданными уравнениями параллельны и не имеют точек пересечения");
}

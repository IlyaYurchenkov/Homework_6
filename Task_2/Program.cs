// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

double b1 = ReadInt("Введите точку b1: ");
double k1 = ReadInt("Введите точку k1: ");
double b2 = ReadInt("Введите точку b2: ");
double k2 = ReadInt("Введите точку k2: ");

double intersectionPointX = ((b2 - b1) / (k1 - k2));
double intersectionPointY = ((b1 - b2) / (k2 - k1));

if (k1 == k2)
{
    Console.WriteLine(" Прямые параллельны ");
}
else
{
    Console.WriteLine($"Точка пересечения по Х {intersectionPointX}\nТочка пересечения по Y {intersectionPointY}");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double GetValue(string text)
{
  Console.Write(text);
  return Convert.ToDouble(Console.ReadLine());
}
void DotInterSections(double b1, double b2, double k1, double k2)
{
    if (b1 != k1 & b2 != k2)
    {
        double y = k1 * (b2 - b1)/(k1 - k2) + b1;
        double x = (b2 - b1)/(k1 - k2);
        Console.WriteLine($"Точка пересечения двух прямых -> ({Math.Round(x, 2)};{Math.Round(y, 2)})");
    }
    else Console.WriteLine("Прямые не пересекаются");
}
double b1 = GetValue("Введите b1: ");
double b2 = GetValue("Введите b2: ");
double k1 = GetValue("Введите k1: ");
double k2 = GetValue("Введите k2: ");
DotInterSections(b1, b2, k1, k2);
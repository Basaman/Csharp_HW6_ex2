//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double B1 = GetNumberB1FromUser("Введите значение b1: ");
double K1 = GetNumberK1FromUser("Введите значение k1: ");
double B2 = GetNumberB2FromUser("Введите значение b2: ");
double K2 = GetNumberK2FromUser("Введите значение k2: ");

double CoordX = GetCoordinatesX(B1);
double CoordY = GetCoordinatesY(B2);

Console.WriteLine($"b1 = {B1}, k1 = {K1}, b2 = {K2}, b1 = {B2} -> ({CoordX}; {CoordY})");


double GetNumberB1FromUser(string message)
{
    Console.Write(message);
    double b1 = double.Parse(Console.ReadLine() ?? "");
    return b1;
}

double GetNumberK1FromUser(string message)
{
    Console.Write(message);
    double k1 = double.Parse(Console.ReadLine() ?? "");
    return k1;
}

double GetNumberB2FromUser(string message)
{
    Console.Write(message);
    double b2 = double.Parse(Console.ReadLine() ?? "");
    return b2;
}

double GetNumberK2FromUser(string message)
{
    Console.Write(message);
    double k2 = double.Parse(Console.ReadLine() ?? "");
    return k2;
}


double GetCoordinatesX(double x)
{
    x = (B1 - B2) / ((K1 - K2) * -1);
    return x;
}

double GetCoordinatesY(double y)
{
    y = K2 * CoordX + B2;
    return y;
}

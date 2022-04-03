// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int Parse(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}

int b1 = Parse("Введите b1: ");
int k1 = Parse("Введите k1: ");
int b2 = Parse("Введите b2: ");
int k2 = Parse("Введите k2: ");

double Point1 = ((double)(b2 - b1) / (k1 - k2));
double Point2 = ((double)(k1 * b2 - k2 * b1) / (k1 - k2));
Console.WriteLine($"{Point1}, {Point2}");
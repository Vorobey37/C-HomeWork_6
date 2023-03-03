/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
Console.WriteLine("Введите значения b1, k1, b2, k2 через запятую:");
string text = Console.ReadLine();
double[] GetArrayFromString(string text)
{
    string[] elements = text.Split(",");
    double[] array = new double[elements.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = double.Parse(elements[i]);
    }
    return array;
}
double[] array = GetArrayFromString(text);

if (array[1] == array[3])
{
    Console.WriteLine($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} -> данные прямые не пересекаются");
}
else
{
    double x = GetX(array);
    double y = GetY(array, x);
    Console.WriteLine($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} -> ({x}; {y})");
}

double GetX(double[] array)
{
    double x = (array[2] - array[0]) / (array[1] - array[3]);
    return x;
}

double GetY(double[] array, double x)
{
    double y = array[1] * x + array[0];
    return y;
}

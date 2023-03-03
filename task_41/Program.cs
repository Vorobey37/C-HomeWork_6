/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.WriteLine("Введите числа через пробел:");
string text = Console.ReadLine();
int[] GetArrayFromString(string text)
{
    string[] elements = text.Split(" ");
    int[] array = new int[elements.Length];
    for (int i = 0; i < elements.Length; i++)
    {
        array[i] = int.Parse(elements[i]);
    }
    return array;
}
int[] array = GetArrayFromString(text);

int QuantityPositiveElements (int[]array)
{
    int result = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            result++;
        }
    }
    return result;
}

int result = QuantityPositiveElements (array);

Console.WriteLine($"{String.Join(", ", array)} -> {result}");

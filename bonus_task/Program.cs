/*
У Вас в наличии есть телефонный справочник с информацией о номерах телефонов и адресов абонентов.
Требуется реализовать эффективную структуру данных, реализующую поиск информации об абонентах 
по номерам телефонов.
261498
Pupkin Vasiliy Vasilyevich
Lenina 24-16
921611
Smirnov Pavel Andreevich
Kopylova 10-106
559173
Ivanova Marina Alexandrovna
Kalinina 120-51
267114
Sidorov Dmitriy Evgenyevich
Mira 22-14
861730
Petrova Anna Ivanovna
Totmina 9-3
*/
Console.WriteLine();
string text1 = "261498 "
+ "Pupkin Vasiliy Vasilyevich "
+ "Lenina 24-16 "
+ "921611 "
+ "Smirnov Pavel Andreevich "
+ "Kopylova 10-106 "
+ "559173 "
+ "Ivanova Marina Alexandrovna "
+ "Kalinina 120-51 "
+ "267114 "
+ "Sidorov Dmitriy Evgenyevich "
+ "Mira 22-14 "
+ "861730 "
+ "Petrova Anna Ivanovna "
+ "Totmina 9-3 ";
string text2 = "261498 "
+ "559173 "
+ "861730 ";

string[] GetStringArray(string text)
{
    string[] words = text.Split(" ");
    return words;
}

void FindUsers(string text1, string text2)
{
    string[] words = GetStringArray(text1);
    string[] numbers = GetStringArray(text2);

    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < words.Length; j++)
        {
            if (words[j] == numbers[i])
            {
                if (j < words.Length - 5)
                {
                    Console.WriteLine($"{words[j + 1]} {words[j + 2]} {words[j + 3]} ({words[j + 4]} {words[j + 5]})");
                }
            }
        }
    }
}

FindUsers(text1, text2);



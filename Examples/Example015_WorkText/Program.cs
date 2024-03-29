﻿// Работа с текстом
// Дан текст. В ткст нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменть маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. " 
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty" // есть вспомогательный функционал
//             012345
// s[3] // r - чтобы получить конкретный символ

// 1. метод будет принимать строку и те символы к.е. менять
// 2. возвращаться будет строка
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty; // пустая строка

    //3. получить длинну строки
    int length = text.Length;
    for(int i = 0; i < length; i++) // проходим от 0 до конца строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если текущий символ совпал с тем, что мы хотим заменить, тогда в результат положим новое значение
        else result = result + $"{text[i]}"; //если нет добавить текущий символ, который был
    }
    return result;
}
string newText = Replase(text, ' ', '|'); // строке новый текст присвоить 
Console.WriteLine(newText);
// указать те символы которые нужно заменить, теми на которые нужно заменить
Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replase(newText, 'С', 'с');
Console.WriteLine(newText);

﻿// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что,”
+ "ежели бы вас послали вместо нашего милого Винценгероде,”
+ "вы бы взяли приступом согласие прусского короля."
+ "ы так красноречивы. Вы дадите мне чаю?"";

// string s = "qwerty"
//             012345
// s[3] // r

// string Replase(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{NewValue}";
//         else result = result + $"{str[i]}";
//     }
//     return result;
// }
// string newText = replace(text, ' ',' | ');
// Console.WriteLine(newText);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array)
{
int count = array.Length
for (int i = 0; i < count; i++)
{
Console.Write($”{array[i]}”);
}
Console.WriteLine();
}
PrintArray(arr)

// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

// Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
//Method2(msg: "Текст сообщения");
// Аргументы именованные:

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;//(энкримент)
//     }
// }
// Method21(msg: "Текст",count: 4);


// Вид 3

// int Metod3()//- не принимает никакие аргументы
// {
//     return DataTime.Now.Year;// - обязательное использование оператора return,
// }
// int year = Metod3();
// // Console.WriteLine(year);


// Вид 4

// string Metod4(int count, string text)
// {
//     i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);

// Цикл В Цикле

for ( int i = 2; i < 10; i++)
{
    for ( int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j} ");
    }
    Console.WriteLine();
}
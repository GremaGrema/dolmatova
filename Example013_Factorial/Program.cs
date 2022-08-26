


// int Factorial (int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial (n - 1);
// }
// Console.WriteLine(Factorial(5)); // 1*2*3=6

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonaci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonaci(n - 1) + Fibonaci(n - 2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibonaci(i));
}
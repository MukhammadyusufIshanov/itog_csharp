Console.WriteLine("Task 1");
Console.WriteLine();

// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


void DigitsBetween(int start, int stop)
{
    if (start == stop)
    {
        Console.Write($"{start}");
        return;
    }
    Console.Write($"{start} ");
    DigitsBetween(start + 1, stop);
}


Console.WriteLine("Input M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

DigitsBetween(m, n);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Task 2");
Console.WriteLine();

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int Akkerman (int m, int n)
{
    int res=0;
    if (m==0)
    {
        res=n+1;
    }
    if (m>0 && n==0)
    {
        res=Akkerman(m-1,1);
    }
    if (m>0 && n>0)
    {
        res=Akkerman(m-1,Akkerman(m,n-1));
    }
    return res;
}


Console.WriteLine("Input m");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(m1,n1));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Task 3");
Console.WriteLine();

Console.WriteLine("Input array size");
int num = Convert.ToInt32(Console.ReadLine());

int[] RandomMas(int m)
{
    int[] numbers = new int[m];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 100);
    }
    return numbers;
}
void PrintMas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
};

void ReverseMass(int[] col,int i = 0)
{
    if (i==col.Length)
    {
        return;
    }
    ReverseMass(col,i+1);
    Console.Write($"{col[i]} ");
}


int[] arr = RandomMas(num);
PrintMas(arr);
Console.WriteLine();
ReverseMass(arr);
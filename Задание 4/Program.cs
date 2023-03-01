void Poz(int a)
{
    bool b = a>0;
    if (b == true)
    {
        Console.WriteLine("Число положительное");
    }
    else
    {
        Console.WriteLine("Число отрицательное");
    }
}
void Prost(int a)
{
    bool b = (a == 2 || a == 3 || a == 5 || a == 7 || a == 11 || a == 13 || a == 17 || a == 19 || a == 23 || a == 29);
    if (b == true)
    {
        Console.WriteLine("Число простое");
    }
    else
    {
        Console.WriteLine("Число сложное");
    }
}
void Del(int a)
{
    bool b = (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 6 == 0 || a % 9 == 0);
    if (b == true)
    {
        Console.WriteLine("Число делится на 2, 3, 5, 6, или 9 без остатка");
    }
    else
    {
        Console.WriteLine("Число не делится на 2, 3, 5, 6, или 9 без остатка");
    }
}
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Poz(a);
Prost(a);
Del(a);





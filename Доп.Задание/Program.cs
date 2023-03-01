Console.WriteLine("Введите три числа через Enter"); 
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
double Calculate(int a, int b, int c)
{
    double d = (a + b + c) / 3;
    return d;
}
double d = Calculate(a, b, c);
Console.WriteLine("Среднее арифметическое чисел {0}, {1} и {2} равно {3}",a,b,c,d);
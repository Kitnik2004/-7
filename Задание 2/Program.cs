static double Add(double a, double b, out double c) => c = a + b;
static double Sub(double a, double b, out double c) => c = a - b;
static double Mul(double a, double b, out double c) => c = a * b;
static double Div(double a, double b, out double c) => c = a / b;

Console.WriteLine("Введите первое число");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Выберите действие над числами(+ or - or * or /)");
string d = Console.ReadLine();
double c=0;
switch (d)
{
    case "+":
        {
            Add(a, b, out c);
            Console.WriteLine(c);
            break;
        }
    case "-":
        {
            Sub(a, b, out c);
            Console.WriteLine(c);
            break;
        }
    case "*":
        {
            Mul(a, b, out c);
            Console.WriteLine(c);
            break;
        }
    case "/":
        {
            if (b != 0)
            {
                Div(a, b, out c);
            Console.WriteLine(c); 
            }
            else
                Console.WriteLine("На ноль делить нельзя");
            break;
        }
    default:
        {
            Console.WriteLine("Вы выбрали неправильное действие");
            break;
        }
}

static double Dollar(double a, out double c) => c = a / 75.05;
static double Euro(double a, out double c) => c = a / 79.44;
static double Yena(double a, out double c) => c = a / 0.55;
Console.WriteLine("Введите количество рублей");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Выберите валюту(Доллар - 1, Евро - 2, Йена - 3");
string b = Console.ReadLine();
double c = 0;
switch (b)
{
    case "1":
        {
            Dollar(a, out c);
            Console.WriteLine("{1} рублей равно {2} долларов", a, c);
            break;
        }
    case "2":
        {
            Euro(a, out c);
            Console.WriteLine("{1} рублей равно {2} евро", a, c);
            break;
        }
    case "3":
        {
            Yena(a, out c);
            Console.WriteLine("{0} рублей равно {1} йен", a, c);
            break;
        }
    default:
        {
            Console.WriteLine("Вы неправильно выбрали валюту");
            break;
        }
}
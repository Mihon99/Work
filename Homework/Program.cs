Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int a = int.Parse(number1);
Console.Write("Введите второе число: ");
string number2 = Console.ReadLine();
int b = int.Parse(number2);

int max = a;

if(a>max) max=a;
if(b>max) max=b;

Console.Write("max = ");
Console.WriteLine(max);

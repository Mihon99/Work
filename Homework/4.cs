Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int a = int.Parse(number1);
int b = 1;

while (b<=a)
{
    if(b % 2==0)
    {
    Console.Write(b);
    Console.Write(" ");
    }
    b++;
}
Console.Write("Введите число: ");
string number1 = Console.ReadLine();
int a = int.Parse(number1);

if(a % 2==0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число нечётное!");
}
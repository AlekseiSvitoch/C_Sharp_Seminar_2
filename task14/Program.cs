Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 7;
int c = 23;
if (a % b == 0 && a % c == 0)
{
    Console.Write("Кратно");
}
else
{
    Console.Write("Некратно");
}
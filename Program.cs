/*
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат {number} равен {number*number}");
Console.WriteLine("Ваше имя "+name);
*/
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (b*b==a)
    Console.WriteLine($" {a} квадрат {b}");
else
    Console.WriteLine("Нет не является");
int koren = Convert.ToInt32(Math.Sqrt(a));
if (koren == b)
    Console.WriteLine($" {a} квадрат {b}");
else
    Console.WriteLine("Нет не является");



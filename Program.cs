
/*
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат {number} равен {number*number}");
Console.WriteLine("Ваше имя "+name);
*/
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (b*b==a)
    Console.WriteLine($" {a} квадрат {b}");
else
    Console.WriteLine("Нет не является");
int koren = Convert.ToInt32(Math.Sqrt(a));
if (koren == b)
    Console.WriteLine($" {a} квадрат {b}");
else
    Console.WriteLine("Нет не является");*/
    /*
int a = int.Parse(Console.ReadLine());
if (a == 1)
    Console.WriteLine("Пн");
if (a == 2)
    Console.WriteLine("вт");
if (a == 3)
    Console.WriteLine("ср");
if (a == 4)
    Console.WriteLine("чт");
if (a == 5)
    Console.WriteLine("Пт");
if (a == 6)
    Console.WriteLine("ура суббота");
if (a == 7)
    Console.WriteLine("вс");
if (a > 7)
    Console.WriteLine("ошибка");
if (a < 1)
    Console.WriteLine("ошибка");
    */
/*int N = int.Parse(Console.ReadLine());
int M = -N;
while (M!=N+1){
    Console.Write(M+" ");
    M++;
}*/

/*ДОМАШНЕЕ ЗАДАНИЕ*/
 /* №1 */
 int a = int.Parse(Console.ReadLine());
 int b = int.Parse(Console.ReadLine());
 int max;
if (a>b)
    max = a;
else
    max = b;
Console.WriteLine($"max={max}");
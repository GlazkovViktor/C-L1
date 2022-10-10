/*
int num = new Random().Next(10,9999);
int s1 = num / 10;
int s2 = num % 10;
Console.WriteLine(num);
Console.WriteLine(s1+" "+s2);
if (s1>s2) Console.WriteLine(s1);
else Console.WriteLine(s2);*/
/*int num = new Random().Next(10,9999);
Console.WriteLine(num);
int max = num%10;
while (num!=0){
     int k = num%10;
     if (k>max) max=k; 
     num=num/10;
}
Console.WriteLine(max);*/

/*int num = new Random().Next(100,999);
Console.WriteLine(num);
int result = (num/100)*10 + num%10; 
Console.WriteLine($"Число без второй цифры: {result}");*/

/*Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
if (num1%num2 == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не крастно, остаток равен {num1%num2}");*/

/*string s = Console.ReadLine();
string[] subs = s.Split(' ');
int max = 0;
string MaxWord = subs[0];
foreach (var sub in subs)
{
    int k = 0;
    foreach (var w in sub){
        k++;
    }
    if (k>max)
    {
        MaxWord = sub;
        max = k;
    }
}
Console.WriteLine(MaxWord);*/

//Домашнее задание к семинару 2
//Задача 1
/*int num = new Random().Next(100,999);
Console.WriteLine(num);
int result = (num/10)-((num/100)*10);
Console.WriteLine($"Второе число: {result}");*/

//Задача 2
/*int num = new Random().Next(1,9999);
string num2 = Convert.ToString(num);
Console.WriteLine(num);
int len = num2.Length;
if (len>=3)
Console.WriteLine($"Третье число: {num2[2]}");
else
Console.WriteLine("Третьего числа нет");*/

// Задача 3

/*Console.Write("День недели выходной?:");
int Den = int.Parse(Console.ReadLine());

if (Den == 6 | Den == 7){
    Console.WriteLine("Да");
    
}
    else
    Console.WriteLine("Нет");*/

    //СЕМИНАР 3

   /* void chet(int x, int y)
    {
        if (x > 0 && y > 0)
            Console.WriteLine("Первая четверть");  
        else if (x > 0 && y < 0)
            Console.WriteLine("Вторая четверть");
        else if (x < 0 && y < 0)
            Console.WriteLine("3 четверть");
        else 
            Console.WriteLine("4 четверть");
    }
    string chet2 (int x, int y){
        string name = x>0 && y>0 ? "1 четверть": x>0 && y<0 ? "2 четверть": x<0 && y<0 ? "3 четверть": "4 четверть";
        return name;
    }
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    chet(x,y);
    string otvet = chet2(x,y);
    Console.WriteLine(otvet);*/
       
   /* string chet (int x)
    {
        string name = x == 1 ? "x>0 и y>0": x == 2 ? "x>0 и y<0": x == 3 ? "x<0 и y<0": "x<0 и y>0";
        return name;
    }
    int x = int.Parse(Console.ReadLine());
    chet(x);
    string otvet = chet(x);
    Console.WriteLine(otvet);*/

   /* double dist (int x1, int y1, int x2, int y2){
        double res = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
        return res;
    }
    int x1 = int.Parse(Console.ReadLine());
    int y1 = int.Parse(Console.ReadLine());
    int x2 = int.Parse(Console.ReadLine());
    int y2 = int.Parse(Console.ReadLine());
    double otvet = dist(x1,y1,x2,y2);
    Console.WriteLine(otvet);*/
// ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 3
// ЗАДАЧА 1, решение не универсальное, но соответсвует условию .

/*int num = int.Parse(Console.ReadLine());
//int num = new Random().Next(10000,99999);
string num2 = Convert.ToString(num);
    if (num2[0]==num2[4] && (num2[1]==num2[3]))
    Console.WriteLine("Является");
    else
    Console.WriteLine("Не является");*/

//Задача 2
double dist (int x1, int y1, int x2, int y2, int z1, int z2){
        double res = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
        return res;
    }
    int x1 = int.Parse(Console.ReadLine());
    int y1 = int.Parse(Console.ReadLine());
    int z1 = int.Parse(Console.ReadLine());
    int x2 = int.Parse(Console.ReadLine());
    int y2 = int.Parse(Console.ReadLine()); 
    int z2 = int.Parse(Console.ReadLine());
    double otvet = dist(x1,y1,x2,y2,z1,z2);
    Console.WriteLine(otvet);
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
int num = new Random().Next(100,999);
Console.WriteLine(num);
int result = (num/10)-((num/100)*10);
Console.WriteLine($"Второе число: {result}");
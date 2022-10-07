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

int num = new Random().Next(100,999);
Console.WriteLine(num);
int result = (num/100)*10 + num%10; 
Console.WriteLine($"Число без второй цифры: {result}");


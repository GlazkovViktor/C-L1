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
/*double dist (int x1, int y1, int x2, int y2, int z1, int z2){
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
    */

    //Задача 3

   /* int n = int.Parse(Console.ReadLine());
    
    double[] arr = new double[n];
    int len = arr.Length;
    int k = 0;
    while (n!=0){
        
        double kub = Math.Pow(n,3);
        arr[k] =  kub;
        n = n-1;
        k++;
        
        
    }
    Console.Write("кубы от 1 до N:");
    for (len=len-1; len>=0; len--){
    Console.Write($" {arr[len]};");
    }*/
    
    // семинар 4
   /* int A = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int  i = 0;  i < A+1;  i++)
    {
         sum = sum + i;
        
    }
    Console.WriteLine($"Сумма равна: {sum}" );*/
    void Vivod(string[] array){
         foreach (var i in array)
    {
         Console.Write(i+" "); 
    }
    }
    string[] perestanovka(string[] array){
        for(int i =0; i<array.Length/2; i++){
            string t = array[i];
            array[i] = array[array.Length-i-1];
            array[array.Length-i-1] = t;
        }
        return array;
    }
   /* int A = int.Parse(Console.ReadLine());
    string[] name = new string[A];
    for(int i=0; i < A; i++)
    { 
        name[i] = Console.ReadLine();
    }
    Vivod(name);
    perestanovka(name);
    Console.WriteLine();
    Vivod(name);*/

    //задача 2 , самое часто повторяющееся число
    
   /* int[] CreateMass(int A)
    {
    int[] arr = new int[A];
    for( int i =0; i<A; i++)
        arr[i] = new Random().Next(0,8);
        return arr;
    }
    void PrintArray(int[] arr){
        Console.WriteLine(String.Join(" ", arr));
    }
    int count(int[] arr){
        int k = 0;
        int max = 0;
        for(int i=0; i<arr.Length; i++){
            k=0;
            for(int j = 0; j<arr.Length; j++){
                if (arr[i] == arr[j])k++;
            }
            if (k>max){
                max = k; 
            }
        }
        return max;
    }
    Console.WriteLine("Введите количество элементов: ");
    int A = int.Parse(Console.ReadLine());
    int[] array = new int[A];
    array = CreateMass(A);
    PrintArray(array);
    count(array);
    Console.WriteLine(count(array));*/

    //Задача 3 , сгененировать 12 числе, 6 положительных, 6 отриц. диапоазон от -10 до 10

   /* int[] CreateMass(){
        int kol = 12; 
        int[] arr = new int[12];
        int Posit = 0;
        int Negat = 0;
        int Zero = 0;
        while (Posit != 6 && Negat != 6) {
        Posit = 0;
        Negat = 0;
        Zero = 1;
            for(int i = 0; i<kol; i++){
            arr[i] = new Random().Next(-10,10);
            if (arr[i]>0) Posit++;
            else if (arr[i]<0) Negat++;
            else  i--;
            }   
        }
        
        return arr;
    }
    void PrintArray(int[] arr){
        Console.WriteLine(String.Join(" ", arr));
    }
    
    int[] arr = new int[12];    
    arr = CreateMass();
    PrintArray(arr);*/

    //ДОМАШНЕЕ ЗАДАНИЕ СЕМИНАР 4
    //ЗАДАЧА 1
  
             
   /* double AB(double A, double B){
       double step = Math.Pow(A,B);
    return step;
    }
        double A = int.Parse(Console.ReadLine());
        double B = int.Parse(Console.ReadLine());
        if (B>=0){
    double pow = AB(A,B);
    Console.WriteLine(pow);
        }
        if (B<0) Console.WriteLine("Ошибка: степень отриц");
// немного не понимаю в функциях и для чего она тут нужна, ведь без нее еще короче было бы .?*/

//Задача 2 , принимает число и выдет сумму цифр в числе
 /* double A = int.Parse(Console.ReadLine());
  string array = Convert.ToString(A);
  int[] arr = new int[array.Length];
  for (int i = 0; i<array.Length; i++){
    arr[i] = Convert.ToInt32(array[i].ToString());
  }
  int sum1 = 0;
  for (int j = 0; j<arr.Length; j++){
    sum1 = sum1+arr[j];
  }
  Console.WriteLine(sum1);
  */

  //Задача 3 рандомный массив из 8 элементов.итоговый массив содержит в себе суммы цифр числа. В хажагии не быдл сказано какие именно рандомыне числа задаем,
  // ер универсального решения я не смог придумать к сожалению. Судя по примеру нужно было для числе от 1 до 99

  int[] CreateMass(){
        int kol = 8; 
        int[] arr = new int[kol];
            for(int i = 0; i<kol; i++){
            arr[i] = new Random().Next(1,99999);
            } 
        return arr;
    }
    void PrintArray(int[] arr){
        Console.WriteLine(String.Join(" ", arr));
    }
    int[] arr = new int[8];    
    arr = CreateMass();
    PrintArray(arr);
    int sum = 0;
    int[] NewArr = new int[8];
    for (int i=0;i<arr.Length;i++){
        if (arr[i]<=99)
        sum = arr[i]/10 + arr[i]%10;
        NewArr[i] = sum;
        if (arr[i]<=999)
        sum = arr[i]/100 + (arr[i]%100)/10+arr[i]%10;
        NewArr[i] = sum;
        if (arr[i]<=9999)
        sum = arr[i]/1000 + (arr[i]%1000)/100+(arr[i]%100)/10+arr[i]%10;
        NewArr[i] = sum;
        sum = arr[i]/10000 + (arr[i]%10000)/1000+(arr[i]%1000)/100+(arr[i]%100)/10+arr[i]%10;
        NewArr[i] = sum;
    }
    PrintArray(NewArr);
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
/*  void Vivod(string[] array){
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

/*int[] CreateMass(int A)
 {
 int[] arr = new int[A];
 for( int i =0; i<A; i++)
     arr[i] = new Random().Next(0,8);
     return arr;}


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

/*int[] CreateMass(){
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
   /*
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
   */

//Семинар 5  

void CreateList(List<int> numb)
{
    for (int i = 0; i < 10; i++)
        numb.Add(new Random().Next(1, 22));
}
int[] CreateMass(int A)
{
    int[] arr = new int[A];
    for (int i = 0; i < A; i++)
        arr[i] = new Random().Next(100, 999);
    return arr;
}
void PrintArray(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.WriteLine();
}
/*
List<int> num = new List<int>();
int[] array = new int[10];
array = CreateMass(10);
PrintArray(array);
array.ToList();
CreateList(num); 
Console.Write(" ");
 foreach (var n in num){
    Console.Write(n + " ");
}
num.AddRange(array);

foreach (var n in num){
    Console.Write(n + " ");
}
*/
//задача 1 сеимнар, заменить элементы в массиве на противоположные по знаку 
/*string[] sbitie(string[] array, int k){
    for (int i=0;i<k;i++){
        Console.Write("Введите от: ");
        int l1 = int.Parse(Console.ReadLine());
        Console.Write("Введите до: ");
        int r1 = int.Parse(Console.ReadLine());
        for (int j=l1; j<r1+1; j++)
        array[j-1] = ".";
    }
    return array;
}
int[] zamena(int[] array){
    for (int i=0; i<array.Length; i++)
    array[i] = -array[i];
    return array;
}*/
//int[] array = new int[10];
//array = CreateMass(10);
//Console.WriteLine("Количество кеглей: ");
//int N = int.Parse(Console.ReadLine());
//string[] nums = new string[N];
//for (int i = 0; i<nums.Length; i++){
//  nums[i] = "I";

//}
// PrintArray(nums);
//Console.Write("Введите количетсво бросков: ");
//int K = int.Parse(Console.ReadLine());
//nums = sbitie(nums,K);

//PrintArray(nums);

//ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 5

// Задача 1
/*Console.Write("Введите количство числе в массиве: ");
int A = int.Parse(Console.ReadLine());
int[] array = CreateMass(A);
PrintArray(array);
int k = 0;
for(int i =0; i<array.Length; i++){
    if (array[i]%2==0) {
        k = k+1;}
}
Console.WriteLine(k);
*/
//ЗАДАЧА 2
/*
    Console.Write("Введите количство числе в массиве: ");
   int A = int.Parse(Console.ReadLine());
   int[] array = CreateMass(A);
    PrintArray(array);
    int k = 0;
    for(int i =0; i<array.Length; i++){
        if (i%2!=0) {
            k = k + array[i];
    }
    }
    Console.WriteLine(k);*/
//Задача 3
/* List<int> num = new List<int>();
 int[] array = new int[10];
 array = CreateMass(10);
 PrintArray(array);
 num.AddRange(array);
 Console.Write(" ");
  foreach (var n in num){
     Console.Write(n+" ");
 }
int max = num.Max();
int indexMax = num.IndexOf(max);
int min = num.Min();
int indexMin = num.IndexOf(min);
Console.WriteLine(" ");
Console.WriteLine($"Максимальное значение: {max} ");
Console.WriteLine($"Индекс макс элемента: {indexMax} ");
Console.WriteLine($"Минимальное значение:  {min} ");
Console.WriteLine($"Индекс минимального элемента: {indexMin} ");
int diff = 0;
int IndexDiff = 0;
IndexDiff = indexMax-indexMin;
diff = max-min;
Console.WriteLine($"Разница:  {diff} ");
Console.WriteLine($"Разница индексов:  {IndexDiff} ");*/

//СЕМИНРА 6 

/*int number = int.Parse(Console.ReadLine());
int osn = 16;
string number2 = Convert.ToString(number,osn);
Console.WriteLine(number2);
Console.WriteLine(perevod(number, osn));

string perevod(int number, int osn) {
    string res = "";
    string nums = "0123456789ABCDEF";
    while (number>0) {
        int del = number/osn;
        res = nums[number - del*osn] + res;
        number = number/osn;
    }
    return res;
    }*/
/*  
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a+b>c && a+c>b &&  b+c>a) 
Console.WriteLine("ДА");
else
Console.WriteLine("нет");*/

/*int n = int.Parse(Console.ReadLine());
int first = 0;
int second = 1;
Console.Write(first+ " " + second + " ");
for (int i = 2; i<n; i++){
    int next = first + second;
    Console.Write(next + " ");
    first = second;
    second = next;
    }*/

/* int[,] array = new int[100, 100];
 int n = array.GetLength(0);
 void Print()
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++){
             if (i==j || i == n - 1- j || i == n/2 || j==n/2)
             Console.Write("*");
             else 
             Console.Write(".");
         }
         Console.WriteLine();
     }
 }
 Print();*/

//ДОМАШНЕЕ ЗАДАНИЕ СЕМИНАР 6 Ввести Н чисел, посчитать сколько >0

/* int N = int.Parse(Console.ReadLine());
 int[] array = new int[N];
 int count = 0;
 void vvod(){
     for (int i = 0; i<array.Length; i++){
     array[i] = int.Parse(Console.ReadLine());
     if (array[i]>0)
     count = count+1;
     }
 } 
 vvod();
 Console.WriteLine(count);*/

// Задача 2, найти точку пересечения двух прямых 

/*void peres(double x1, double y1, double x2, double y2)
{
    double x = (y2 - y1) / (x1 - x2);
    double y = (x2 * y1 - x1 * y2) / (x2 - x1);
    if (x1 != x2) Console.Write($"Точка пересечения: ({x}; {y})");
    else
        Console.Write(" не пересекаются ");
}

Console.WriteLine("x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("y2: ");
int y2 = int.Parse(Console.ReadLine());

peres(x1, y1, x2, y2);*/
/*void FillList(List<List<double>> MyList)
{
    for (int i = 0; i < 5; i++)
    {
        MyList.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            MyList[i].Add(Math.Round(new Random().NextDouble() * 5));
    }


}
void PrintList(List<List<double>> MyList)
{
    for (int i = 0; i < MyList.Count; i++)
    {
        for (int j = 0; j < MyList[i].Count; j++)
            Console.Write(MyList[i][j] + " ");
        Console.WriteLine();
    }
}
double Zapolnenie(List<List<double>> MyList)
{
    double sum = 0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            if (i == j)
                sum = sum + MyList[i][j];


    }
    return sum;
    Console.WriteLine();
}
void swap(List<List<double>> MyList, int j1, int j2)
{
    double temp = 0;
    for (int i = 0; i < MyList.Count; i++)
    {
        for (int j = 0; j < MyList[i].Count; j++)
            temp = MyList[i][j1];
        MyList[i][j1] = MyList[i][j2];
        MyList[i][j2] = temp; 
    }

}

List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
 Console.WriteLine();
Zapolnenie(numbers);
swap(numbers, 1, 3);
//PrintList(numbers);
//Console.WriteLine(Zapolnenie(numbers));
PrintList(numbers);*/

// ДОМАШНЕЕ ЗАДАНИЕ, СЕМИНАР 7, ЧАСТЬ 1
// ЗАДАНИЕ 1 ИЗ ЛЕКЦИИ, взял из лекции, добавил 2 точки после запятой
void FillList(List<List<double>> MyList)
{
    for (int i = 0; i < 5; i++)
    {
        MyList.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            MyList[i].Add(Math.Round(new Random().NextDouble() * 5, 2));
    }
}
void PrintList(List<List<double>> MyList)
{
    for (int i = 0; i < MyList.Count; i++)
    {
        for (int j = 0; j < MyList[i].Count; j++)
            Console.Write(MyList[i][j] + " ");
        Console.WriteLine();
    }
}
List<List<double>> numbers = new List<List<double>>();
//FillList(numbers);
//PrintList(numbers);

//ЗАДАЧА 2, ВВЕСТИ ЧИСЛОю НАЙТИ ЕСТТ ЛИ ТАКОЙ ЭЛЕМЕНТ, 
//СМОГ РЕШИТЬ ТОЛЬКО ТАК ,ЧЕРЕЗ ПРЕОБРАЗОВАНИЕ В СТРОКУ И ВЫТАСКИВАТЬ ОТ ТУДА НЕ ВЫШЛО 

/*double swap(List<List<double>> MyList, int j1, int j2)
{
    double temp1 = 0;
    for (int i = 0; i < MyList.Count; i++)
    {
        for (int j = 0; j < MyList[i].Count; j++)
            if (j1 > 5 && j2 > 5)
            {
                Console.WriteLine("Нет такого");
            }
            else
            {
                temp1 = MyList[i][j];
            }
    }
    return temp1;
}

FillList(numbers);
PrintList(numbers);
int j1 = int.Parse(Console.ReadLine());
int j2 = int.Parse(Console.ReadLine());
swap(numbers, j1, j2);
Console.WriteLine(swap(numbers,j1,j2));*/

//ЗАДАЧА 3
//не смог 
//СЕМИНАР 8
// заменить первую строку на последнюю
/*void FillMass(int[,] arr)
{
    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
            arr[i, j] = new Random().Next(1, 9);

}
void OutPut(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] swap(int[,] arr)
{
    int LastIndex = arr.GetLength(0) - 1;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[0, j];
        arr[0, j] = arr[LastIndex, j];
        arr[LastIndex, j] = temp;

    }
    return arr;
}
// двумерный массив меняем строки на столбцы
int[,] FullSwap(int[,] arr){
int[,] rArr = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rArr[j, i] = arr[i, j];


        }

    }
    return rArr;
}

int[,] array = new int[5, 5];
FillMass(array);
//OutPut(array);
int[,] NewArr = new int[5, 5];
NewArr = swap(array);
OutPut(NewArr);
int[,] ReverseArr = new int[5, 5];
ReverseArr = FullSwap(NewArr);
OutPut(ReverseArr);*/

// Домашнее задание 8,2
//Задание , отсартировать строки по убыванию.

/*void FillMass(int[,] arr)
{
    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
            arr[i, j] = new Random().Next(1, 9);

}
void OutPut(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] swap(int[,] arr)
{
    int s = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1)-1 ; k++)
            {
                if (arr[i, k]*s > arr[i,k+1]*s)
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k+1];
                    arr[i, k+1] = temp;
                }
            }
        }
    }
    return arr;
}

int[,] array = new int[5, 5];
FillMass(array);
OutPut(array);
int[,] NewArr = new int[5, 5];
NewArr = swap(array);
OutPut(NewArr);
*/

/*void FillMass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(1, 9);

}
void OutPut(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Main(int[,] arr)
        {
            int sum = int.MaxValue;
            int index = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int temp = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    temp += arr[i, j];
                }
                if (temp < sum)
                {
                    sum = temp;
                    index = i;
                }
            }
            Console.WriteLine("Строка: "+index+" Сумма - "+sum);
            Console.WriteLine();
            
        }
int[,] array = new int[7, 5];
FillMass(array);
OutPut(array);
Main(array);*/

// Задача 3 произведение матриц 
/*void FillMass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(1, 9);

}
void OutPut(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static int[,] MatrixMultiplication(int[,] arr, int[,] arr1)
{
    if (arr.GetLength(0) != arr1.GetLength(1))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    var ResArr
     = new int[arr.GetLength(1), arr1.GetLength(0)];

    for (var i = 0; i < arr.GetLength(1); i++)
    {
        for (var j = 0; j < arr1.GetLength(0); j++)
        {
            ResArr
            [i, j] = 0;

            for (var k = 0; k < arr.GetLength(0); k++)
            {
                ResArr
                [i, j] += arr[i, k] * arr1[k, j];
            }
        }
    }

    return ResArr
    ;
}
int[,] array = new int[5, 5];
int[,] array1 = new int[5, 5];
FillMass(array);
FillMass(array1);
OutPut(array);
OutPut(array1);
int[,] matrix = new int[5, 5];
matrix = MatrixMultiplication(array, array1);
OutPut(matrix);*/

//Задача 4 трехмерный массив из неповторяющихся 2х значных числе


/*void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
int[,,] array3D = new int[2, 2, 2];
CreateArray(array3D);
WriteArray(array3D);*/

//Задача 4 заполнить спирально массив 4*4

/* int temp = 1;
int i = 0;
int j = 0;
int[,] spiral = new int[4,4];

while (temp <= spiral.GetLength(0) * spiral.GetLength(1))
{
  spiral[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiral.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiral.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiral.GetLength(1) - 1)
    j--;
  else
    i--;
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

WriteArray(spiral);*/

//ЗАКЛЮЧИТЕЛЬНЫЙ СЕМИНАР

// вывод всех натуральныъ чисел при помощи рекрсии. от 1 до Н
/*int k = 0;
string FillNumbers(int N)
{
    if (N == 1) return (k+1).ToString();
    else
        k++;
        return (k + " " + FillNumbers(N-1));
        
}
Console.WriteLine(FillNumbers(15));*/

// задача 2 от м до н
/*
string FillNumbers(int N, int A)
{
    if (N == A) return (N).ToString();
    else
        return (N + " " + FillNumbers(N+1,A));
        
}
Console.WriteLine(FillNumbers(5,111));*/

// выводить сумму числе числа

/*int Summa(int n)
{
    if (n % 10 == 0) return 0;
    else
        return (n % 10 + Summa(n / 10));
}
Console.WriteLine(Summa(24546454));*/

/*int Summa(int A, int B)
{
    if (B == 0) return 1;
    if (B == 1) return A;
    else
        B = B - 1;
    return (A * Summa(A, B));
}
Console.WriteLine(Summa(5,3));*/

/*string FindDictionary(int n)
{
    Dictionary<string, string> Dict = new Dictionary<string, string>();
    for (int i = 0; i < n; i++)
    {   
        Console.WriteLine("Введите пары слов");
        string[] names = Console.ReadLine().Split();
        Dict.Add(names[0],names[1]);
        Dict.Add(names[1],names[0]);
    }
    Console.WriteLine("Введите name");
    string chooseName = Console.ReadLine();
    return Dict[chooseName];
}

Console.WriteLine("Введите число слов");
int kol = int.Parse(Console.ReadLine());
Console.WriteLine(FindDictionary(kol));*/


// Домашнеезадание закл семинар
// зад 1. от A lj N

string FillNumbers(int N, int A)
{
    if (N == A) return (A).ToString();
    else
        return ( A+ " " + FillNumbers(N,A-1));
        
}
Console.WriteLine(FillNumbers(5,10));
//от  N до 1
string FillNumbers1(int N)
{
    if (N == 1) return (1).ToString();
    else
        return ( N+ " " + FillNumbers1(N-1));
        
}
Console.WriteLine(FillNumbers1(5));



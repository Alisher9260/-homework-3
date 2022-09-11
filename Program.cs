// задача 19 : необходимо написать программу, которая принимает на вход некоторое число ,
 //а на выходе выдает -является ли это число палиндромом.
/*void Numbers (int num1)
 {
   int th10 = num1 / 10000; 
   int th = (num1 / 1000) % 10; 
   int hund =  (num1 / 1000) % 10;
   int dec = (num1 /  10)% 10;
   int ed = (num1 % 10);
    if ((th10 == ed)&&(th == dec))

   Console.Write("да");
else
   Console.Write ("нет");
}  
 
Console.Write("введите число A");
int n1 = Convert.ToInt32(Console.ReadLine());
Numbers(n1);*/

/*void Digit(string? str)
 {
    int len = str.Length;

    for (int i = 0; i< len / 2;i++)
    {
    if (str[i] != str [len - i - 1])

   Console.Write("нет");
else
   Console.Write ("да");
}  
 }
Console.Write("введите число A");
int n1 = Convert.ToInt32(Console.ReadLine());
Digit(str);*/
// задача 21 : необходимо написать программу, принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве
/* double FindDisance (double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt ((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2 - z1) * (z2-z1));

}
Console.Write("Введите координаты 1 точки(x,y,z): ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты 2 точки(x,y,z): ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());

double dist = FindDisance (xA, yA, xB, yB,zA,zB);
Console.WriteLine ($"дистанция {dist} ");*/

// задача 23 : необходимо написать программу, которая принимает на вход некоторое число N,
 //а на выходе выдает кубы этого числа
 /*void cube (int number)
{
int i = 1;
while (i<= number)
{
   Console.Write($"{i * i* i},");
    i++;
}
}
Console.Write("введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
cube(number1);*/

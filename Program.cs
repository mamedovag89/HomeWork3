// Task 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Numbers(int number)
{
    while(number > 99999 || number <= 9999)
    {
    Console.WriteLine( "Incorrect input, try again: "  );
    number = Convert.ToInt32(Console.ReadLine());
    }
int num1 = number / 10000;
int num2 = number / 1000 % 10;
int num4 = number % 100 / 10;
int num5 = number % 10;

if(num1 == num5 && num2 == num4)
{
    Console.WriteLine("Число является палиндромом");
 }
 else
    Console.WriteLine("Число не является палиндромом");
}
 
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);



// Task2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Dist3D(double xa, double xb, double ya, double yb, double za, double zb)
{
    double lenth = Math.Sqrt((yb - ya) * (yb - ya) + (xb - xa) * (xb - xa) + (zb -za) * (zb -za));
    return lenth;
}

Console.Write("Введите значение координаты Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Х точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());


double lenth = Dist3D(xa, xb, ya, yb, za, zb);
Console.Write($"Расстояния между точками A и B равно {lenth}");

*/

// Task3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Numbers(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write(current * current * current + " ");
        current++;
    }
}
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);
*/

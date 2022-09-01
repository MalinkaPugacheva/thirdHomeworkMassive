// Задача 19. Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom (int i)

{
    int time = i;
    int number=0;
    while (i>0)
    {
        int a=i%10;
        number=number*10+a;
        i=i/10;
    } 
    if(time==number)
        {
        Console.WriteLine($"Your number is a palindrom!!!");
        }
    else 
    {
        Console.WriteLine("It's not a palindrom!!!");
    }
}

Console.WriteLine("Write your fifth-digit number: ");
int i=Convert.ToInt32(Console.ReadLine());

Palindrom(i);
*/

//Задача 21. Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.
/*
double LenSegment(double a1, double b1, double a2, double b2, double c1, double c2)
{
    double da=a1-a2;
    double db=b1-b2;
    double plane=c1-c2;
    double len=Math.Sqrt(da*da+db*db+plane*plane);
    return len;
}

Console.WriteLine("Write coordinate a 1: ");
int a1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Write coordinate b 1: ");
int b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Write coordinate a 2: ");
int a2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Write coordinate b 2: ");
int b2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Write coordinate c 1: ");
int c1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Write coordinate c 2: ");
int c2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Length of interval({a1},{b1})({a2},{b2})({c1},{c2})={LenSegment(a1,b1,a2,b2,c1,c2)}");
*/
// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubedTables (int number)
{
    int n =1;
    while(n<=number)
    {
        Console.WriteLine($"Cubed of this number {n}={n*n*n}");
        n++;
    }
}

Console.Write("Write number: ");
int cub=Convert.ToInt32(Console.ReadLine());
CubedTables(cub);
*/

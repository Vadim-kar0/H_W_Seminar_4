// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (палиндром - число читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
string text = Console.ReadLine();
if(text.Length != 5)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
if (text[0] == text[4] && text[1] == text[3])
{
    Console.WriteLine("Число палиндром");
}
else{
     Console.WriteLine("Число не палиндром");
}


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите ось х1 : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ось y1 : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ось z1 : ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ось x2 : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ось у2 : ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ось z2 : ");
double z2 = Convert.ToDouble(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2- y1),2) + Math.Pow((z2- z1),2));

Console.WriteLine($"Расстояние между точками в 3d пространстве =  {Math.Round(distance, 2)}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; Console.Write($"{Math.Pow(i,3)} "), i++);
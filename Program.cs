//Программа, которая принимает 5-значное число и проверяет, палиндром ли оно

Console.Clear();

void Reverse(int num)
{
    int d5 = num % 10;
    int d4 = num / 10 % 10;
    int d3 = num / 100 % 10;
    int d2 = num / 1000 % 10;
    int d1 = num / 10000 % 10;
    num = d5 * 10000 + d4 * 1000 + d3 * 100 + d2 * 10 + d1;
    Console.WriteLine(num);
}

Console.WriteLine("Введите пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99999 || n < 10000)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    Reverse(n);
}


//Программа  принимает на вход координаты 2х точек и находит расстояние в трехмерном пространстве

// Console.Clear();

// double Dots3Ddistance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }

// Console.WriteLine("Введите координаты первой точки: a1, b1, c1:");
// int a1 = Convert.ToInt32(Console.ReadLine());
// int b1 = Convert.ToInt32(Console.ReadLine());
// int c1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки: a2, b2, c2:");
// int a2 = Convert.ToInt32(Console.ReadLine());
// int b2 = Convert.ToInt32(Console.ReadLine());
// int c2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Расстояние между точками: " + Dots3Ddistance(a1, a2, b1, b2, c1, c2));


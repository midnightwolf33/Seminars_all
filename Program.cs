// // Семинар 3

// void CheckKoord(int x, int y);
// {
// Console.WriteLine("Введите координату Х");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0);
//     Console.WriteLine("четверть № 1");
// else if (x > 0 && y < 0);
//     Console.WriteLine("четверть № 4");
// else if (x < 0 && y < 0);
//     Console.WriteLine("четверть № 3");
// else if (x < 0 && y > 0);
//     Console.WriteLine.("четверть № 2");
// else 
//     Console.WriteLine("Точка находится на координатной оси");
// }

// // Задача 2

// void CheckKoord2(int x, int y);






// Задача 3

Console.WriteLine("Введите целую координату X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую координату Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую координату X");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую координату Y");
int y2 = Convert.ToInt32(Console.ReadLine());
double dist = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
Console.WriteLine(dist);

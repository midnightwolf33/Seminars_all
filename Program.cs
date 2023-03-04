// Семинар 3

Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0);
    Console.WriteLine("четверть № 1");
else if (x > 0 && y < 0);
    Console.WriteLine("четверть № 4");
else if (x < 0 && y < 0);
    Console.WriteLine("четверть № 3");
else if (x < 0 && y > 0);
    Console.WriteLine.("четверть № 2");
else 
    Console.WriteLine("Точка находится на координатной оси");
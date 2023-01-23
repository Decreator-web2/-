// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 
// Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите значение");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 10000)
    {
    int x1 = number / 10000;
    int y1 = number % 10;
    if(x1 == y1)
            {
            number = number / 10; 
            int x2 = (number / 100) % 10;
            int y2 = number % 10;
            if(x2 == y2)
            Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            }
                else
                Console.WriteLine("Некорректное число");

//  Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
//  чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите значение");
// int N = Convert.ToInt32(Console.ReadLine());
// for(int x=1;x<N+1;x++)
// {
//     Console.WriteLine($"{x*x}");
// }
// Console.WriteLine();

// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату x первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y первой точки");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z первой точки");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y второй точки");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z второй точки");
// int z2 = Convert.ToInt32(Console.ReadLine());

// int A = (x2 - x1);
// int B = (y2 - y1);
// int C = (z1 - z2);

//     {
//     double Lenth=Math.Sqrt(A*A+B*B+C*C);
//     Console.WriteLine($"Расстояние равно {Lenth}");
//     }
    

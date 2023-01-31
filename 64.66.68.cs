// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите натуральное число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(AllNumber(N));
// string AllNumber(int N)
// {
//     if (N==1) return $" 1";
//     return  $" {N}" + AllNumber(N-1);
// }


//  Задача 66:Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//  элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите начальное число M:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начальное число N:");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{SumFor(M, N)}");

// int SumFor(int M, int N)
// {
//     if (M == 0) return (N * (N + 1)) / 2;            
//     else if (N == 0) return (M * (M + 1)) / 2;       
//     else if (M == N) return M;                       
//     else if (M < N) return N + SumFor(M, N - 1); 
//     else return N + SumFor(M, N + 1);            
// }
    


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите начальное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int N = Convert.ToInt32(Console.ReadLine());

int f = Ack(M, N);

Console.Write($"Функция Аккермана = {f} ");

int Ack(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Ack(M - 1, 1);
  else return Ack(M - 1, Ack(M, N - 1));
}

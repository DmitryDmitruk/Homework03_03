/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.Clear();
Console.WriteLine("Введите число m");
int M=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n");
int N=int.Parse(Console.ReadLine()!);
int AckermannFunction(int M, int N)
{
    if (M==0) return N+1;
    if(M!=0 && N==0) return AckermannFunction(M-1,1);
    if (M>0 && N>0) return AckermannFunction(M-1,AckermannFunction(M,N-1));
    return AckermannFunction(M,N);

}
Console.WriteLine($"Функция аккермана для чисел А({M},{N}) = {AckermannFunction(M,N)}" );
/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();
Console.WriteLine("Введите число m");
int m=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n");
int n=int.Parse(Console.ReadLine()!);
int PrintNumbers ( int m,  int n)
{
   if(n>m) return m+n+n-1;
   else
   {
    return m;
   }
}  

Console.WriteLine(PrintNumbers(m,n));

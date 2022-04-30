/*: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.*/
Console.WriteLine("введите числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());



if (a > b & a > c)
{
    Console.WriteLine(a);
}
if (b > a & b > c)
{
    Console.WriteLine(b);
}
if (c > a & c > b)
{
    Console.WriteLine(c);
}
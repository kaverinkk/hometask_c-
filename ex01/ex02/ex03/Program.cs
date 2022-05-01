 /*Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).*/

Console.WriteLine("Введите чисо: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.Write("Число является четным.");
}
else
{
    Console.Write("Число не является четным.");
}
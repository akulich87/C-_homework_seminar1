// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число четным(делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

if ( number1 % 2 == 0)
{
  Console.Write("Число является четным ");
}
else
{
  Console.Write("Число является нечетным ");
}
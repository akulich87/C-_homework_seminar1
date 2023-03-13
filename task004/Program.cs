// Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int first = 1;

while (first<number)
{
  Console.WriteLine(first+1);
  first+=2;
}
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
string s_num1 = Console.ReadLine();
Console.Write ("Введите второе число: ");
string s_num2 = Console.ReadLine();
Console.Write ("Введите третье число: ");
string s_num3 = Console.ReadLine();
int num1 = Convert.ToInt32(s_num1);
int num2 = Convert.ToInt32(s_num2);
int num3 = Convert.ToInt32(s_num3);
if (num1 > num2) 
{
    num1 = max;
}
else
{
    num2 = max;
}
if (num2 > num3)
{
    num2 = max;
}
else
{
    num3 = max;
}
if (num3 > num1)
{
    num3 = max;
}
else
{
    num1 = max;
}
Console.Write( $" max = { max } " );
 Console.Write("max = ");
 Console.Write("max");
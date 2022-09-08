// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int dig = Convert.ToInt32(Console.ReadLine());

if (dig > 9999 && dig < 100000)
{
    bool palin(int dig1)
    {
        return (dig1 / 10000 == dig1 % 10 && dig1 % 100 / 10 == dig1 % 10000 / 1000);
    }

    bool results = palin(dig);
    if (results) Console.WriteLine("Палиндром");
    else Console.WriteLine("Не палиндром");
}
else
{
    Console.WriteLine("Введите пятизначное число");
}


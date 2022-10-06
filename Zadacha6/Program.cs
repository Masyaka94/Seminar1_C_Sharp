//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.WriteLine("Vvedite chislo a");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine(a + " - chetnoe chislo");
}
else
{
    Console.WriteLine(a + " - nechetnoe chislo");
}
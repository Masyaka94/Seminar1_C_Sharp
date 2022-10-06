//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какой меньшее.

Console.WriteLine ("Vvedite chislo a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Vvedite chislo b");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (a>b) 
{
max = a;
min = b;
Console.WriteLine ("maximal'noe chislo " + max);
Console.WriteLine ("minimal'noe chislo " + min);
}
else
{
max = b;
min = a;
Console.WriteLine ("maximal'noe chislo " + max);
Console.WriteLine ("minimal'noe chislo " + min);
}
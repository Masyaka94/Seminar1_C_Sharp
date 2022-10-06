//Напишите программу, которая на вход принимает три числа и выдаёт, какое число большее, а какой меньшее.

Console.WriteLine ("Vvedite chislo a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Vvedite chislo b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Vvedite chislo c");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a>b) 
{
	if(a>c)
	{
	max = a;
	Console.WriteLine ("maximal'noe chislo " + max);
	}
	else
	{
	max=c;
	Console.WriteLine ("maximal'noe chislo " + max);
	}
}
else
{
	if(b>c)
	{
	max = b;
	Console.WriteLine ("maximal'noe chislo " + max);
	}
	else
	{
	max=c;
	Console.WriteLine ("maximal'noe chislo " + max);
	}
}
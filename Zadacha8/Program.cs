Console.WriteLine("Vvedite chislo N");
int N = int.Parse(Console.ReadLine());

int i = 0;
while (i <= N) 
{
    if (i % 2 == 0) 
    {
        Console.WriteLine(i);
    }
    i++;
}

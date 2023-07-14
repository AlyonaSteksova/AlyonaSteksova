Random rnd = new Random();
Console.WriteLine("Введите начальную дату: ");
DateTime min=Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Введите конечную дату: ");
DateTime max = Convert.ToDateTime(Console.ReadLine());
int a = 1;

for (DateTime i=min; i<max; i=i.AddHours(1))
{
    int value = rnd.Next(-15, 15);
    Console.WriteLine(a + "  |  " + i + "  |  " + value);
    a++;
}
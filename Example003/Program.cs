int n;
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    if(n < 8)
    {
        Console.WriteLine(n == 6 ? "Weekend": n == 7 ? "Weekend" : "Workday");
    }
    else
    {
        Console.WriteLine("Не найден день недели");
    }
}
else
{
    Console.WriteLine("Не найден день недели");
}
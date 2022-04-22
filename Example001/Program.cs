int number;
Console.WriteLine("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());
if(number > 99)
{
    if(number < 1000)
    {
        number = number/10;
        int result = number%10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Данные не соответствуют");
    }
}
else
{
    Console.WriteLine("Данные не соответствуют");
}

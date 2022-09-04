Console.WriteLine("Введите цифру, обозначающую день недели (пн-1, вт-2, ср-3, чт-4, пт-5, сб-6, вс-7) ");
int num_user = int.Parse(Console.ReadLine());

if (num_user <6)
{
    Console.WriteLine("нет");
}
else
{
    if (num_user>7)
    {
    Console.WriteLine("введите цифру от 1 до 7");
    }
    else
    {
        Console.WriteLine("да"); 
    }
}

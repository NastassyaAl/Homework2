Console.WriteLine("Введите число ");
int num_user = int.Parse(Console.ReadLine());

int n = 0;
int number = num_user;
while (num_user % 10 > 0)
{
    n = n + 1;
    num_user = num_user / 10;
}

int size = 1;
for (int i = 0; i < (n - 1); i++)
{
    size *= 10;
}
int a = number / size;
if (n<2)
{
    Console.WriteLine("третьей цифры нет");
}
int b = (number-a*size)/(size/10); 

if (n < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int c = (number-a*size-b*(size/10))/(size/100);
    int[] array = { a, b, c };
    Console.WriteLine(array[2]);
}




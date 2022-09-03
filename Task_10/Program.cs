Console.WriteLine("Введите трехзначное число ");
int num_user = int.Parse(Console.ReadLine());

int a = num_user/100;
int b = (num_user-a*100)/10;
Console.WriteLine(b);

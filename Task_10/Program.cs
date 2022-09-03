Console.WriteLine("Введите трехзначное число ");
int num_user = int.Parse(Console.ReadLine());

int a = num_user/100;
int b = (num_user-a*100)/10;
int c = num_user-a*100-b*10;

int [] array = {a,b,c};

Console.WriteLine(array[1]);
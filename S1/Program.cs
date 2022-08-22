/*Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = int.Parse(Console.ReadLine());
Console.WriteLine ("Max=");
if (x<y) {
    Console.WriteLine (y);
}
else if (x>y) {
    Console.WriteLine (x);
}
else {
    Console.WriteLine ("Максимума нет - числа равны");
}*/

/*Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int z = int.Parse(Console.ReadLine());
int max = x;
Console.WriteLine("Максимальное число:");
if (y>max) {
    max=y;
}
if (z>max) {
    max=z;
}
Console.WriteLine(max);*/

/*Console.WriteLine("Введите целое число");
int x = int.Parse(Console.ReadLine());
if ((x%2)==0) {
    Console.WriteLine ("Четное");
}
else {
    Console.WriteLine ("Нечетное");
}*/

Console.WriteLine("Введите целое число");
int n = int.Parse(Console.ReadLine());
int x=1;
while (x<=n) {
if (x%2==0) {
    Console.WriteLine(x);
}
x++;
}





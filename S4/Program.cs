/*Console. WriteLine("Число А"); //задача 1
int a = int. Parse(Console.ReadLine());
Console. WriteLine("Число B");
int b = int. Parse(Console.ReadLine());
int temp =a; 
if (b == 0 || a == 1) {
    Console.WriteLine("Результат равен 1");//любое число в нулевой это единица или 1 в любой степени 1
}
else if (a==0) {
    Console.WriteLine("Результат равен 0");
}
else {
    for (int i=1;i<b;i++)
    {
    
        temp = a*temp;
    }
    Console.WriteLine("Результат равен " + temp);
       
}*/


/*Console. WriteLine ("Введите число"); //задача 2
int n = int. Parse(Console.ReadLine());
int sum=0;
 while (n>0) {
    sum=sum+n%10;
    n=n/10;
}
Console.WriteLine("Сумма всех цифр равна " + sum);*/




/*void FillArray(int[]array) //задача 3
{
for (int i=0; i<array.Length;i++) {
     Console.WriteLine("Введите число (я спрошу 8 чисел)");
    array[i]= int. Parse(Console.ReadLine());}
};

void PrintArray(int[]array)
{
    for(int i=0;i<array.Length;i++) {
    Console.Write(array[i] + " ");
    }
}

int [] array = new int[8];
FillArray(array);
PrintArray(array);*/


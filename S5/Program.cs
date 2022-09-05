/*void FillArray(int[] array) //задача 1
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(100,1000);
        Console.Write(array[i] + " ");
    }
    
}

void CountChet(int [] array)
{ int counter =0;
    for (int i=0; i<array.Length;i++) {
    if (array[i]%2 == 0) counter++;
}  
Console.Write("Количество четных чисел " + counter + " ");
}


int[] array= new int [5];
FillArray(array);
CountChet(array); */ //работает но выводит не очень красиво, хочется красивее


/*void FillArray(int[] array) //задача 2
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(-99,99);//завожу такой диапазон случайных
        Console.Write(array[i] + " ");
    }
    

}

void PoiskNechet(int [] array)
{ int sum=0;
    for (int i=0;i<array.Length; i++) {
        if (i%2>0) {
        sum+=array[i];
        }
    }
    Console.WriteLine("Сумма нечетных элементов равна " + sum);

}

int[] array= new int [5];
FillArray(array);
PoiskNechet(array);*/

/*void FillArray(int[] array) //задача 3
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(0,99);//завожу такой диапазон случайных
        Console.Write(array[i] + " ");
    }
}

void FindMinMax(int [] array)
{
int max = array[0];
int min = array[0];
int razn=0;
for (int i=0; i<array.Length;i++) {
    if (array[i]>max) max=array[i];
    else if (array[i]<min) min=array[i];
}
razn = max-min;
Console.WriteLine("Разность равна " + razn);
}

int[] array= new int [3];
FillArray(array);
FindMinMax(array);*/
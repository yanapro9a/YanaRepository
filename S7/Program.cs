/*double[,] GetArray(int m, int n) {//задача 1
double[,] result = new double[m, n];
Random r = new Random();
for (int i = 0; i < m; ++i) {
for (int j = 0; j < n; ++j) {
result[i, j] =(double) r.Next(-100, 100)/10;
}
}

return result;
}

void PrintArray(double[,] array) {
for (int i = 0; i < array.GetLength(0); ++i) {
for (int j = 0; j < array.GetLength(1); ++j) {
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}}

double[,] result = GetArray(3,4);
PrintArray(result);*/



/*int[,] GetArray(int m, int n, int minValue, int maxValue) {//ЗАДАЧА 2
int[,] result = new int[m, n];

for (int i = 0; i < m; ++i) {
for (int j = 0; j < n; ++j) {
result[i, j] = new Random().Next(minValue, maxValue + 1);
}
}

return result;
}

void PrintArray(int[,] array) {
for (int i = 0; i < array.GetLength(0); ++i) {
for (int j = 0; j < array.GetLength(1); ++j) {
Console.Write(array[i, j] + "  ");
}
Console.WriteLine();
}}

void Poisk(int[,] array) {
Console.WriteLine("Веедите первый индекс");
int i = int. Parse(Console.ReadLine());
 Console. WriteLine("Введите второй индекс");
 int j = int. Parse(Console.ReadLine());
if(i>=array.GetLength(0) || i<0 || j>=array.GetLength(1) || j<0) {
    Console.WriteLine("Числа по такому индексу нет");
}
else Console.Write(array[i,j] + "  ");
}

int[,] result = GetArray(3,4,10,20);
PrintArray(result);
Poisk(result);*/






/*int[,] GetArray(int m, int n, int minValue, int maxValue) {//задача 3
int[,] result = new int[m, n];

for (int i = 0; i < m; ++i) {
for (int j = 0; j < n; ++j) {
result[i, j] = new Random().Next(minValue, maxValue + 1);
}
}

return result;
}

void PrintArray(int[,] array) {
for (int i = 0; i < array.GetLength(0); ++i) {
for (int j = 0; j < array.GetLength(1); ++j) {
Console.Write(array[i, j] + "  ");
}
Console.WriteLine();
}}

void SrArifm(int[,] array) {
for (int j = 0; j < array.GetLength(1); ++j)
{
int arifm = 0; 
for (int i = 0; i < array.GetLength(0); ++i){

 arifm=arifm + array[i,j];
}
double srArifm=(double) arifm/array.GetLength(0);
Console.WriteLine("Среднее арифметическое" + "  " + srArifm);}
}


int[,] result = GetArray(3,4,1,5);
PrintArray(result);
SrArifm(result);*/

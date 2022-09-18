/*int [,] GetArray(int m, int n, int minValue, int maxValue) {//ЗАДАЧА 1
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


void SortArray(int[,] array) {
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int x = 0; x < array.GetLength(1) - 1; x++)
      {
        if (array[i, x] < array[i, x + 1])
        {
          int temp = array[i, x + 1];
          array[i, x + 1] = array[i, x];
          array[i, x] = temp;
        }
      }
    }
  }
}
}

int[,] array = GetArray(2,2,1,8);
PrintArray(array);
SortArray(array);
PrintArray(array);*/

/*int [,] GetArray(int m, int n, int minValue, int maxValue) {//ЗАДАЧА 2
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


int sumLine(int[,] array, int i)
{ 
  int sumLine = array[i,0]; 
  for (int j = 1; j < array.GetLength(1); j++) 
  { 
    sumLine += array[i,j]; 
  } 
  return sumLine; 
}


int[,] array = GetArray(3,3,1,8);
PrintArray(array);
int minSumLine = 0;
int sumLine0 = sumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempsumLine = sumLine(array, i);
  if (sumLine0 > tempsumLine)
  {
    sumLine0 = tempsumLine;
    minSumLine = i;
  }
}

Console.WriteLine("Номер строки с наименьшей суммой элементов" + "  " + (minSumLine+1));*/

/*int [,] GetArray(int m, int n, int minValue, int maxValue) {//ЗАДАЧА 3
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

void MultiplyMatrix(int[,]firstMatrix, int[,]secondMatrix, int[,] resultMatrix) { 
    
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}




int[,] firstMatrix = GetArray(2,2,1,8);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix); 
int[,] secondMatrix = GetArray(2,2,1,8);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix); 
int[,] finalMatrix = new int[2,2];
MultiplyMatrix(firstMatrix, secondMatrix, finalMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(finalMatrix);*/


/*void GetArray3(int [, ,] array3) {//задача 4
    int [] array1 = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
int  num;
  for (int i = 0; i < array1.GetLength(0); i++)
  {
    array1[i] = new Random().Next(10, 100);
    num = array1[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (array1[i] == array1[j])
        {
          array1[i] = new Random().Next(10, 100);
          j = 0;
          num = array1[i];
        }
          num = array1[i];
      }
    }
  }
  int k = 0; 
  for (int x = 0; x < array3.GetLength(0); x++){
    for (int y = 0; y < array3.GetLength(1); y++){
      for (int z = 0; z < array3.GetLength(2); z++)
      {
        array3[x, y, z] = array1[k];
        k++;
      }
    }
  }
}
void PrintArray3(int[,,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++){
    for (int j = 0; j < array3.GetLength(1); j++){
      for (int k = 0; k < array3.GetLength(2); k++){
        Console.Write( $"{array3[i,j,k]} ({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

int[,,] array3 = new int[2, 2, 2];
GetArray3(array3);
PrintArray3(array3);*/















/*int[,] spiralArray = new int[4, 4];//задача 5

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
  spiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(spiralArray);


void PrintArray(int[,] array) {
for (int i = 0; i < array.GetLength(0); ++i) {
for (int j = 0; j < array.GetLength(1); ++j) {
Console.Write(array[i, j] + "  ");
}
Console.WriteLine();
}}*/

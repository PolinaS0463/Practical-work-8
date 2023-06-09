Console.Write("Введите число строк 1-й матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int colsAndRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 2-й матрицы: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] FirstMatrix = new int[rows, colsAndRows];
fillMatrix(FirstMatrix);
Console.WriteLine("Первая матрица:");
printMatrix(FirstMatrix);

int[,] SecondMatrix = new int[colsAndRows, cols];
fillMatrix(SecondMatrix);
Console.WriteLine("Вторая матрица:");
printMatrix(SecondMatrix);

int[,] ResultMatrix = new int[rows, cols];
MultiplyMatrix(FirstMatrix, SecondMatrix, ResultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
printMatrix(ResultMatrix);

void MultiplyMatrix(int[,] FirstMatrix, int[,] SecondMatrix, int[,] ResultMatrix)
{
  for (int i = 0; i < ResultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int l = 0; l < FirstMatrix.GetLength(1); l++)
      {
        sum += FirstMatrix[i,l] * SecondMatrix[l,j];
      }
      ResultMatrix[i,j] = sum;
    }
  }
}

int[,] fillMatrix(int[,] matrix){
    Random num = new Random();
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            matrix[i, j] = num.Next(-10, 11);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            Console.Write($"{matrix[i, j]}," + "\t");
        }
        Console.WriteLine();
    }
}

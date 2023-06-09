Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок массива: ");
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix = new int[rows, cols];

int[,] filled_matrix = fillMatrix(matrix);
printMatrix(filled_matrix);
changeRowsFromMaxToMin(filled_matrix);
Console.WriteLine();
Console.WriteLine("Готовая матрица: ");
printMatrix(filled_matrix);

int[,] fillMatrix(int[,] matrix){
    Random num = new Random();
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            matrix[i, j] = num.Next(-10, 21);
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

int[,] changeRowsFromMaxToMin(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            for(int l = 0; l < matrix.GetLength(1)-1; l+=1){
                if(matrix[i,l] < matrix[i,l + 1]){
                    int temp = matrix[i,l];
                    matrix[i,l] = matrix[i,l + 1];
                    matrix[i,l + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

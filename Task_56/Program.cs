Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок массива: ");
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix = new int[rows, cols];

int[,] filled_matrix = fillMatrix(matrix);

int min = Int32.MaxValue;
int min_row = 0;

printMatrix(filled_matrix);
findRowWithMinSum(min, filled_matrix);

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

void findRowWithMinSum(int min, int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            sum += matrix[i,j];
        }
        if (sum < min){
            min = sum;
            min_row = i + 1;
        }
    }
    Console.WriteLine($"В {min_row}-й строке минимальная сумма элементов: {min}");
}
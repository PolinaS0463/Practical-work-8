Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок массива: ");
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] SpiralMatrix = new int[rows, cols];

int temp = 1;
int i = 0;
int j = 0;

fillSpiralMatrix(SpiralMatrix);
printMatrix(SpiralMatrix);

void fillSpiralMatrix(int[,] SpiralMatrix){
    while (temp <= SpiralMatrix.GetLength(0) * SpiralMatrix.GetLength(1)){
        SpiralMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < SpiralMatrix.GetLength(1) - 1){
            j++;
        }
        else if (i < j && i + j >= SpiralMatrix.GetLength(0) - 1){
            i++;
        }
        else if (i >= j && i + j > SpiralMatrix.GetLength(1) - 1){
            j--;
        }
        else{
            i--;
        }
    }
}

void printMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            Console.Write($"{matrix[i, j]}," + "\t");
        }
        Console.WriteLine();
    }
}
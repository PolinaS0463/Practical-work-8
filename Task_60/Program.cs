int rows;
int cols;
int deapth;

Prompt();

if((rows * cols * deapth) > 90){
    Console.WriteLine("Невозможно создать матрицу такого размера из неповторяющихся двузначных элеметов. Попробуйте еще раз");
    Prompt(); 
}

int[,,] matrix_3D = new int[rows, cols, deapth];

// Способ с добавлением элементов в список + shuffle:

List<int> list = new List<int>();

fillSingleDimensionArray(list);
shuffleArray(list);
fillAndPrintMatrix(matrix_3D, list);
Console.WriteLine();

List<int> fillSingleDimensionArray(List<int> list){
    int elem = 10;
    for(int i = 0; i < 90; i++){
        list.Add(elem);
        elem++;
    }
    return list;
}

void shuffleArray(List<int> list){
    Random random_num = new Random();
    for (int i = list.Count - 1; i >= 0; i--){
        int random_item = random_num.Next(i);
        int shuffled_item = list[random_item];
        list[random_item] = list[i];
        list[i] = shuffled_item;
    }
}

void fillAndPrintMatrix(int[,,] matrix_3D, List<int> list){
    for(int x = 0; x < matrix_3D.GetLength(0); x++){
        for(int y = 0; y < matrix_3D.GetLength(1); y++){
            for(int z = 0; z < matrix_3D.GetLength(2); z++){
                Random random = new Random();
                int index = random.Next(0, list.Count);
                matrix_3D[x,y,z] = list[index];
                list.RemoveAt(index);
                Console.WriteLine($"{matrix_3D[x,y,z]}({x},{y},{z})"); 
            }
        }
    }
}

void Prompt(){
    Console.Write("Введите количество строк массива: ");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество колонок массива: ");
    cols = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите глубину массива: ");
    deapth = Convert.ToInt32(Console.ReadLine());
}


// Найти произведение двух матриц

int[,] CreateMatrix(int length, int width, int min, int max)    //Функция создания матрицы

{
    int[,] matrix = new int[length, width];
    var random = new Random();
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            matrix[i,j] = random.Next(min, max);
    return matrix;
}
void PrintMatrix(int[,] matrix)         //Функция вывода матрицы
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write($"{matrix[i,j]} \t ");
        Console.WriteLine();
    }
}
int[] ProductMatrix(int[] matrix length, int width)      //Функция умножения матриц
{
    int[,] matrix2 = new int[length, width];
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix1.GetLength(1); j++)

            matrix2[i,j] = 0;
            for (int k = 0; k < matrix.GetLength(0); k++)
                matrix2[i,j] = matrix[i,k] * matrix1[k,j];
                return new int[]{i,j};
    return new int[] {-1,-1};  
}

  // Вывод матрицы произведения
//  cout << "Матрица произведения" << endl;
//  for (int i = 0; i < row1; i++)
//  {
//    for (int j = 0; j < col2; j++)
//      cout << c[i][j] << " ";
//    cout << endl;
//  }
//  cin.get(); cin.get();
//  return 0;
//}



Console.Clear();
int m = 5;
int n = 5;
int[,] matrix = CreateMatrix(m, n, 1, 100);
Console.WriteLine("matrix");
PrintMatrix(matrix);

Console.WriteLine("matrix1");
int[,] matrix1 = CreateMatrix(m, n, 1, 100);
PrintMatrix(matrix1, matrix1);                  //Что указать в аргумент?
PrintMatrix(matrix);











//Console.Write("Введите номер элемента, чтобы узнать его координаты: : ");
//int value = int.Parse(Console.ReadLine() ?? "0");
//int[] position = NumberPosition(matrix,value);
//Console.WriteLine(position[0]< 0 || position[1]< 0
//    ? "Такого элемента нет в массиве"
//    : $"Элемент имеет координаты: строка ({position[0]} , {position[1]}) столбец.");

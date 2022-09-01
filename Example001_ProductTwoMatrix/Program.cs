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
    //matrix2 = new int * matrix[m];
    for(int i = 0; i < matrix.GetLength(0); i++)

        //matrix2[i] = new int matrix1[n];
        for(int j = 0; j < matrix1.GetLength(1); j++)

            matrix2[i,j] = 0;
            for (int k = 0; k < matrix.GetLength(0); k++)
                matrix2[i,j] = matrix[i,k] * matrix1[k,j];
                return new int[]{i,j};
    return new int[] {-1,-1};  
}


Console.Clear();
int m = 5;
int n = 5;
int[,] matrix = CreateMatrix(m, n, 1, 100);
Console.WriteLine("matrix");
PrintMatrix(matrix);

Console.WriteLine("matrix1");
int[,] matrix1 = CreateMatrix(m, n, 1, 100);
ProductMatrix(matrix1, matrix1);                  //Что указать в аргумент?
PrintMatrix(matrix);

Console.WriteLine("Произведение 2-х матриц: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
            Console.WriteLine($"{matrix2[i,j]}" + " ");
    }




//Console.Write("Введите номер элемента, чтобы узнать его координаты: : ");
//int value = int.Parse(Console.ReadLine() ?? "0");
//int[] position = NumberPosition(matrix,value);
//Console.WriteLine(position[0]< 0 || position[1]< 0
//    ? "Такого элемента нет в массиве"
//    : $"Элемент имеет координаты: строка ({position[0]} , {position[1]}) столбец.");

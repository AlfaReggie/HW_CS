// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] getRandMatrix(int[] sizeArray, int[] bordArray)
{
    int[,] mtrx = new int[sizeArray[0], sizeArray[1]];

    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            mtrx[idx, jdx] = new Random().Next(bordArray[0], bordArray[1]);
        }
    }
    return mtrx;
}

void printMean(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0.0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        Console.WriteLine($"Average values {i + 1} column = {Math.Round(sum/matrix.GetLength(0), 3)}");
    }
}

void printMtrx(int[,] matrix)
{
    for(int idx = 0; idx < matrix.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < matrix.GetLength(1); jdx++)
        {
            Console.Write(matrix[idx, jdx] + " ");
        }
        Console.Write("\n");
    }
}

int[] userArray(string[] array, Func<string, int> f)
{
    int[] array_01 = new int[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
    {
        int nextEl = f($"Enter {array[idx]}: ");
        array_01[idx] = nextEl;
    }
    return array_01;
}

int nextElArrSize(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while(resVal == false || num < 0)
    {
        string elem = Console.ReadLine();
        resVal = Int32.TryParse(elem, out num);
        if(resVal == false || num < 0)
        {
            Console.WriteLine("Enter error! Try again!");
        }
    }
    return num;
}

int nextElArrBord(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = Int32.TryParse(elem, out num);
        if(resVal == false)
        {
            Console.WriteLine("Enter error! Try again!");
        }  
    }
    return num;
}

while(true)
{
    Console.Write("\n");
    Console.WriteLine("\nEnter 's' to start or enter 'q' to stop: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        string[] usArrayStrSize = {"rows", "cols"};
        int[] usArrayIntSize = userArray(usArrayStrSize, nextElArrSize);
        string[] usArrayStrBord = {"min border", "max border"};
        int[] usArrayIntBord = userArray(usArrayStrBord, nextElArrBord);
        int[,] matriX = getRandMatrix(usArrayIntSize, usArrayIntBord);
        printMtrx(matriX);
        printMean(matriX);
    }    
}
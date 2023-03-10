// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

double[,] getRandMatrix(int[] sizeArray, int[] bordArray)
{
    double[,] mtrx = new double[sizeArray[0], sizeArray[1]];

    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            Random rnd = new Random();
            double d = Math.Round(bordArray[0] * 1.0 + rnd.NextDouble() * (bordArray[1] * 1.0 - bordArray[0] * 1.0), 3);
            mtrx[idx, jdx] = d;
        }
    }
    return mtrx;
}

void printMtrx(double[,] matrix, int[] coords)
{
    for(int idx = 0; idx < matrix.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < matrix.GetLength(1); jdx++)
        {
            Console.Write(matrix[idx, jdx] + " ");
        }
        Console.Write("\n");
    }
    if((coords[0]) < matrix.GetLength(0) & (coords[1]) < matrix.GetLength(1))
    {
        Console.Write($"\nElement with coords - ({coords[0] + 1}, {coords[1] + 1}) = {matrix[coords[0], coords[1]]}");
    }
    else
    {
        Console.Write("Element with this coords not find");
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
    Console.Write(massage);
    int num = -1;
    bool resVal = false;
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
    Console.Write(massage);
    int num = 0;
    bool resVal = false;
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

int nextElArrCoords(string massage)
{
    Console.Write(massage);
    int num = 0;
    bool resVal = false;
    while(resVal == false || num < 1)
    {
        string elem = Console.ReadLine();
        resVal = Int32.TryParse(elem, out num);
        if(resVal == false || num < 1)
        {
            Console.WriteLine("Enter error! Try again! Remember, position can't zero!");
        }      
    }
    return num - 1;
}

while(true)
{
    Console.WriteLine("\nEnter 's' to start or enter 'q' to stop: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        string[] usArrayStrSize = {"cols", "rows"};
        int[] usArrayIntSize = userArray(usArrayStrSize, nextElArrSize);
        string[] usArrayStrBord = {"min border", "max border"};
        int[] usArrayIntBord = userArray(usArrayStrBord, nextElArrBord);
        double[,] matriX = getRandMatrix(usArrayIntSize, usArrayIntBord);
        Console.WriteLine("\nTest check position element: ");
        string[] coorArrayStr = {"axis X", "axis Y"};
        int[] res_val = userArray(coorArrayStr, nextElArrCoords);
        printMtrx(matriX, res_val);
    }    
}
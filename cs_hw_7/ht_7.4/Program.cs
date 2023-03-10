// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] getRandMatrix(int[] array)
{
    int[,] mtrx = new int[array[0], array[1]];
    int sumMainDiagonal = 0;
    for(int idx = 0; idx < mtrx.GetLength(0); idx++)
    {
        for(int jdx = 0; jdx < mtrx.GetLength(1); jdx++)
        {
            mtrx[idx, jdx] = nextElArr($"Enter element with ({idx}, {jdx}) position: ");
            if(idx == jdx)
            {
                sumMainDiagonal += mtrx[idx, jdx];
            }
        }
    }
    Console.WriteLine($"\nSum elements main diagonal = {sumMainDiagonal}...\n\n...from your matrix:");
    return mtrx;
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

int[] userArray(string[] array)
{
    int[] array_01 = new int[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
    {
        int nextEl = nextElArr($"Enter {array[idx]} coords: ");
        array_01[idx] = nextEl;
    }
    return array_01;
}

int nextElArr(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = inpValid(elem);
        if(resVal == true)
        {
            num = Int32.Parse(elem);
        }
        else
        {
            Console.WriteLine("Enter error! Try again!");
            continue;
        }      
    }
    return num;
}

bool inpValid(string num)
{
    bool res_val = Int32.TryParse(num, out int res_num);
    if(res_val == true)
    {
        return true;
    }   
    else
    {
        return false;
    }
}

while(true)
{
    Console.Write("\n");
    Console.WriteLine("Enter 's' to start or enter 'q' to stop: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        string[] array_01 = {"cols", "rows"};
        int[] doubArray = userArray(array_01);
        int[,] matriX = getRandMatrix(doubArray);
        printMtrx(matriX);
    }    
}
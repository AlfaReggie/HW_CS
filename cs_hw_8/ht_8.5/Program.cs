// Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] getMatrix(int[] array)
{
    int[,] mtrx = new int[array[0], array[1]];
    return mtrx;
}

void printMtrx(string[,] matrix)
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

string[,] FillImage(int row, int col)
{
    string[,] fillMatrx = new string[row, col]; 
    int x = 0;
    int y = 0;
    int dx = 0;
    int dy = 1;
    int dirChanges = 0;
    int visits = col;

    for (int i = 0; i < fillMatrx.Length; i++) 
    {
        visits--;
        
        if(i < 9)
        {
            fillMatrx[x, y] = $"0{(i + 1).ToString()}";
        }
        else
        {
            fillMatrx[x, y] = (i + 1).ToString();
        }
        
        if (visits == 0) 
        {
            visits = col * (dirChanges % 2) + row * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dy;
            dy = -dx;
            dx = temp;
            dirChanges++;
        }

        x += dx;
        y += dy;
    }
    return fillMatrx;
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
        int[,] matriX = getMatrix(usArrayIntSize);
        string[,] flMatriX = FillImage(matriX.GetLength(0), matriX.GetLength(1));
        printMtrx(flMatriX);
    }    
}

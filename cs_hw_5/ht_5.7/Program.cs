// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] usRandArr(int[] array)
{
    int[] res_array = new int[array[0]];
    for(int idx = 0; idx < array[0]; idx++)
    {
        if(array[1] <= array[2])
        {
            res_array[idx] = new Random().Next(array[1], array[2] + 1);
        }
        else
        {
            res_array[idx] = new Random().Next(array[2], array[1] + 1);
        }
    }
    return res_array;
}

int resFunk(int[] array)
{
    int reSum = 0;
    for(int idx = 0; idx < array.Length; idx++)
    {
        if(idx % 2 == 0)
        {
            continue;
        }
        else
        {
            reSum += array[idx];
        }
    }
    return reSum;
}

bool inpValid(string num)
{
    bool res_val = int.TryParse(num, out int res_num);
    if(res_val == true)
    {   
        return true;
    }   
    else
    {
        return false;
    }
}

int[] paramArr(string[] array)
{
    int[] paramArray = new int[array.Length];
    string strNxtPar = "";
    int nxtPar = 0;
    for(int idx = 0; idx < array.Length; idx++)
    {
        while(true)
        {
            Console.Write(array[idx]);
            strNxtPar = Console.ReadLine();
            bool resVal = inpValid(strNxtPar);
            if(resVal == true)
            {
                nxtPar = Int32.Parse(strNxtPar);
                break;
            }
            else
            {
                Console.WriteLine("Error enter!");
                continue;
            }
        }
        paramArray[idx] = nxtPar;
    }
    return paramArray;
} 

string[] nameParam = {"Size array: ", "Min border: ", "Max border: "};
int[] randArr = paramArr(nameParam);
int[] userAr = usRandArr(randArr);
int resultt = resFunk(userAr);


Console.WriteLine($"User enter: {String.Join(", ", randArr)}");
Console.WriteLine($"User enter: {String.Join(", ", userAr)}");
Console.WriteLine(resultt);


// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string binSys(int num)
{
    int tempNum = 0;
    string binNum = "";
    while(num != 0)
    {
        tempNum = num % 2;
        num /= 2;
        binNum += tempNum;
    }
    string revBin = "";
    int num_rev = Int32.Parse(binNum);
    int temp = 0;
    for(int idx = binNum.Length; idx > 0; idx--)
    {
        temp = num_rev % 10;
        num_rev /= 10;
        revBin += temp.ToString();
    }
    return revBin;
}

Console.WriteLine(binSys(102));
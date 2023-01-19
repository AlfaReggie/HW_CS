// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Random rnd = new Random();

int[] randArr(int[] smArry)
{
    for(int idx = 0; idx < smArry.Length; idx++)
    {
        smArry[idx] = new Random().Next(0, 2);
    }
    return smArry;
}

void prntArry(int[] array)
{
    for(int idx = 0; idx < array.Length; idx++)
    {
        Console.Write($"{array[idx]}, ");
    }
}



while(true)
{   
    Console.WriteLine("Enter number or enter 'q' to stop: ");
    string user_answ = Console.ReadLine();
    if(user_answ.ToLower() == "q")
    {
        Console.WriteLine("Ok, Bye!");
        break; 
    }
    else
    {
        int[] array_1 = new int[8];
        randArr(array_1);
        prntArry(array_1);
        continue;
    }
}
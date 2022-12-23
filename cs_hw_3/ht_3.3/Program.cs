// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

while (true)
{
    Console.WriteLine("Enter 'n' if you want start or enter 'q' to stop: ");
    string user_answ = Console.ReadLine();
    if (user_answ.ToLower() == "q")
    {
        Console.WriteLine("Ok, Bye!");
        break; 
    }
    else if (user_answ.ToLower() == "n")
    {
        string user_num = Console.ReadLine();
            try
            {
                int u_num = Int32.Parse(user_num);
                for (int idx = 1; idx <= u_num; idx++)
                {
                    Console.Write($"{Math.Pow(idx, 3)}, ");
                }
            }
            catch
            {
                Console.WriteLine("Enter error!");
                continue;
            }
        Console.Write($"\n");
    }
    else
    {
        Console.WriteLine("Enter error!");
        continue;
    }
}
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

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
        string[] array_coor = new string[3] {"x", "y", "z"};
        List<int> coorList_1 = new List<int>();
        List<int> coorList_2 = new List<int>();
        for (int idx = 0; idx <= array_coor.Length - 1; idx++)
        {
            Console.WriteLine($"Enter {array_coor[idx]}_1");
            string next_coor_1 = Console.ReadLine();
            try
            {
                int fd_int_1 = Int32.Parse(next_coor_1);
                coorList_1.Add(fd_int_1);
            }
            catch
            {
                Console.WriteLine("Enter error!");
                continue;
            }
        }
        for (int idx = 0; idx <= array_coor.Length - 1; idx++)
        {
            Console.WriteLine($"Enter {array_coor[idx]}_2");
            string next_coor_2 = Console.ReadLine();
            try
            {
                int fd_int_2 = Int32.Parse(next_coor_2);
                coorList_2.Add(fd_int_2);
            }
            catch
            {
                Console.WriteLine("Enter error!");
                continue;
            }
        }
        int[] coor_array_1 = coorList_1.ToArray();
        int[] coor_array_2 = coorList_2.ToArray();
        Console.WriteLine(Math.Sqrt(Math.Pow(coor_array_2[0]-coor_array_1[0], 2) + Math.Pow(coor_array_2[1]-coor_array_1[1], 2) + Math.Pow(coor_array_2[2]-coor_array_1[2], 2)));
    }
    else
    {
        Console.WriteLine("Enter error!");
        continue;
    }
}
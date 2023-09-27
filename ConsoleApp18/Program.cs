using System;

class Program
{
    static void Main()
    {
       

        Random random = new Random();
        int[,] array = new int[5, 5];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(0, 10);
            }
        }


        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == 0 || i == array.GetLength(0) - 1 ||
                    j == 0 || j == array.GetLength(1) - 1)
                {
                    Console.Write(array[i, j] + " ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

        {
            Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) Main();
            return;
        }
        Console.ReadLine();

    }
}

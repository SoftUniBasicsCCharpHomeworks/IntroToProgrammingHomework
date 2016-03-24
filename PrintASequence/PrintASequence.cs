using System;



class PrintMyName
{
    static void Main()
    {

        for (int i = 2; i <= 11; i++)
        {

            if (!(i % 2 == 0))
            {
                if (i < 11)           // To remove the last comma.
                {
                    Console.Write(-i + ",");
                }
                else
                {
                    Console.Write(-i);
                }
            }
            else
            {
                Console.Write(i + ",");
            }
        }
        Console.WriteLine();
    }
}











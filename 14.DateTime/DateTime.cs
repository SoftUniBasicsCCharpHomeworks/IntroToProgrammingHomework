using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime time = DateTime.Now;
        string format = "d.MM.yyyy г. HH:mm:ss ч.";
        Console.WriteLine(time.ToString(format));
    }
}

// Console template
using System;
class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.Clear();
        Console.WriteLine("Enter the message: ");
        string message = Console.Readline();
        Condole.WriteLine("Enter limit: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int index = 0;
        int total = 0;

        foreach(char c in message)
        {
            int i = int(c);
            total += i;
        }
        
        int total2 = total * total;
        string totalString = total2.ToString();
        int middleIndex = totalString.Length / 2;
        string middle2 = totalString.Substring(middleIndex, 2);
        int middle = Convert.ToInt32(middle2);
        int hash = middle%limit;
        Console.WriteLine("Hash value is: ", hash);
    }
}

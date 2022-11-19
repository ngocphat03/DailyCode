using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] newList = new int[] {0, 1, 1, 3, 1, 1};
        var print = NumberAndNumber(newList, 10);
        Console.WriteLine(print);
    }
    
    public static bool NumberAndNumber(int[] listNumber, int k)
    {
        bool result = false;
        for(int i=0; i<listNumber.Length; i++)
        {
            for(int j=0; j<listNumber.Length; j++)
            {
                if((listNumber[i] + listNumber[j]) == k) { result = true; }
            }
        }
        return result;
    }
}
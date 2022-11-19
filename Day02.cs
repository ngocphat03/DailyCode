using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] ttt = {1, 2, 3, 4, 5};
        
        int[] test = Day2(ttt);
        
        for(int i=0; i<test.Length; i++)
        {
            Console.WriteLine(test[i]);
        }
    }
    public static int[] Day2(int[] input)
    {
        int[] output = new int[input.Length];
        int clone = 1;
        for(int i=0; i<input.Length; i++)
        {
            for(int j=0; j<input.Length; j++)
            {
                if(i == j){}
                else { clone = clone * input[j]; }
            }
            output[i] = clone; 
            clone = 1;
        }
        return output;
    }
}
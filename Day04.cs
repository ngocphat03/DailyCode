using System;
using System.Collections.Generic;

public class AXit
{
    public static void Main(string[] args)
    {
        int[] input = {1,2,3,4,5,7,9,2,1,4,-1,-2,-3,-4,-6,-7,-8};
        int output = FindFirstMissingNumberSmallest(input);
        Console.WriteLine(output);
    }
    
    public static int FindFirstMissingNumberSmallest(int[] array)
    {
        //filter values less than 0
        for(int i=0; i<array.Length; i++)
        {
            if(array[i] < 0)
                array[i] = 0;
        }
        
        //sort by small to large
        int cache;
        for(int i=0; i<array.Length; i++)
        {
            for(int j=0; j<array.Length; j++)
            {
                if(array[i] < array[j])
                {
                    cache = array[i];
                    array[i] = array[j];
                    array[j] = cache;
                }
            }
        }
        
        // delete duplicate numbers
        int[] output = new int[array.Length];
        output[0] = array[0];
        int index=1;
        for(int i=1; i<array.Length; i++)
        {
            if(array[i] == array[i-1])
                continue;
            if(array[i] != array[i-1]){
                output[index] = array[i];
                index++;
            }
        }
        array = output;
        
        //find first missing number (smallest)
        int numberMissing = 0;
        for(int i=0; i<array.Length-1; i++)
        {
            if(array[i]+1 != array[i+1]){
                numberMissing = array[i] + 1;
                break;
            }
            else
                numberMissing = array[array.Length-1] + 1;
        }
        return numberMissing;
    }
}
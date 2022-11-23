#include <iostream>
using namespace std;

int FindFirstMissingNumberSmallest(int array[])
{
	
        //filter values less than 0
        for(int i=0; i<sizeof(array)/sizeof(array[0]); i++)
        {
            if(array[i] < 0)
                array[i] = 0;
        }
        
        //sort by small to large
        int cache;
        for(int i=0; i<sizeof(array)/sizeof(array[0]); i++)
        {
            for(int j=0; j<sizeof(array)/sizeof(array[0]); j++)
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
        int output[sizeof(array)/sizeof(array[0])];
        output[0] = array[0];
        int index=1;
        for(int i=1; i<sizeof(array)/sizeof(array[0]); i++)
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
        for(int i=0; i<sizeof(array)/sizeof(array[0]); i++)
        {
            if(array[i]+1 != array[i+1]){
                numberMissing = array[i] + 1;
                break;
            }
            else
                numberMissing = array[sizeof(array)/sizeof(array[0])] + 1;
        }
        return numberMissing; 
}


int main()
{
	int input[] = {1,2,0};
	int output = FindFirstMissingNumberSmallest(input);
	cout << output;
}  

using System;
class IterationStatement
{

    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileloops();
    }
    void LearnForLoops()
    {
        
        for(int i = 0;i<10;i++)
        {
            Console.WriteLine("Hello World");
        }
        int[] numbers = { 1,2,3,4,5,6,7,8,13};
        // for(int j = 0;j<numbers.Length;j++)
        // {
        //     Console.WriteLine(numbers[j]);
        // }
        foreach(int num in numbers)
        {
            if(num % 2 == 0)
            Console.WriteLine(num);
        }
    }

    void LearnWhileloops()
    {
        int j = 0;
        while(j<10)
        Console.WriteLine("hello world");
        j++;
    }
    
    
}
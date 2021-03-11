using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelAndAsync
{
    class Program
    {
      

        static void Main()
        {
            
          //TPL - Task Parallel Library

          int[] numbers = { 12,14,45,67,78,79,89,21,34};
          Stopwatch stopwatch = new Stopwatch();
          //Sequential
          stopwatch.Start();
          foreach(var num in numbers)
          {
              Compute(num);
          }

          Console.WriteLine($"Time taken(Sequential):{stopwatch.ElapsedMilliseconds} ms");
          stopwatch.Restart();
          // Parallel
           stopwatch.Restart();
           Parallel.ForEach(numbers,num =>{
               Compute(num);
           });
           Console.WriteLine($"Time taken(Parallel):{stopwatch.ElapsedMilliseconds} ms");
        }

        static void Compute(int x)
        {
            Thread.Sleep(100);
            Console.WriteLine($"Computed for {x}");
        }
    }
    //Learned about Parallel using TPL
}

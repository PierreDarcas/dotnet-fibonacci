// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Fibonacci;

Console.WriteLine(Fibonacci.Class1.Test());

// int Fib(int i) { 
//     if(i<=2) return 1;
//     return Fib(i-2) + Fib(i-1);
// }
//
// try { 
//     int result = System.Int32.Parse(args[0]); 
//     Console.WriteLine("Hello, World!" + Fib(Convert.ToInt32(result)));
// } catch (FormatException) { 
//     Console.WriteLine($"Unable to parse '{args[0]}'"); 
// }

//
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();



// string[] numbers = args;
// foreach (string i in numbers)
// {
//     try { 
//        int result = System.Int32.Parse(i); 
//        Console.WriteLine("Hello, World!" + Fib(Convert.ToInt32(result)));
//     } catch (FormatException) { 
//         Console.WriteLine($"Unable to parse '{i}'"); 
//     }
// }

using var fibonacciDataContext = new FibonacciDataContext();

var tasks = await new Fibonacci.Compute(fibonacciDataContext).ExecuteAsync(args);

foreach (var task in tasks)
{
    Console.WriteLine($"Fibo result: {task}");
}

stopwatch.Stop();
Console.WriteLine($"{stopwatch.Elapsed.Seconds} s");

/*List<Task<int>>? RunFibonaccis(string[] strings)
{
    static int Fib(int i) =>
        i switch
        {
            int when i <= 2 => 1,
            _ => Fib(i - 2) + Fib(i - 1)
        };

    var list = new List<Task<int>>();
    foreach (var input in strings)
    {
        var task = Task.Run(() => Fib(int.Parse(strings[0])));
        list.Add(task);
    }

    return list;
}*/


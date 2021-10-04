using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class Class1
    {
        public static int Test()
        {
            return 1;
        }
    }

    public class Compute
    {

            public static async Task<List<int>> ExecuteAsync(string[] arguments)
            {
                var results = new List<int>();

                var tasks = RunFibonaccis(arguments);

                foreach (var task in tasks)
                {
                    var resultAwaited = await task;
                    results.Add(resultAwaited);
                }

                return results;
            }
            
            private static List<Task<int>>? RunFibonaccis(string[] args)
            {
                static int Fib(int i) =>
                    i switch
                    {
                        int when i <= 2 => 1,
                        _ => Fib(i - 2) + Fib(i - 1)
                    };

                var list = new List<Task<int>>();
                foreach (var input in args)
                {
                    var task = Task.Run(() => Fib(int.Parse(args[0])));
                    list.Add(task);
                }

                return list;
            }

        }
    
}



using System;
using Xunit;
using System.Threading.Tasks;
using Fibonacci;
using Microsoft.EntityFrameworkCore;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {

            // using var fibonacciDataContext = new FibonacciDataContext();
            //
            // var result = await new Fibonacci.Compute(fibonacciDataContext).ExecuteAsync(new[] {"6"});
            //
            // //var result = await Fibonacci.Compute.ExecuteAsync(new[] {"6"});
            // Assert.Equal(1, result.Count);
            // Assert.Equal(8, result[0]);
            
            var builder = new DbContextOptionsBuilder<FibonacciDataContext>();
            var dataBaseName = Guid.NewGuid().ToString();
            builder.UseInMemoryDatabase(dataBaseName);
            
            var options = builder.Options;
            var fibonacciDataContext = new FibonacciDataContext(options);
            await fibonacciDataContext.Database.EnsureCreatedAsync(); 

            var result = await new Fibonacci.Compute(fibonacciDataContext).ExecuteAsync(new[] {"6"});
            Assert.Equal(1, result.Count);
            Assert.Equal(8, result[0]);
            
        }
    }
}


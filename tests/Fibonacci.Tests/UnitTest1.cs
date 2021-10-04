using Xunit;
using System.Threading.Tasks;
using Fibonacci;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {

            var result = await Fibonacci.Compute.ExecuteAsync(new[] {"44"});
                Assert.Equal(701408733, result[0]);
            
        }
    }
}


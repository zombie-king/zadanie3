using System;
using Xunit;

namespace zadanie3.Tests
{
    public class RestTests
    {
        [Theory]
        [InlineData(210u,   200u, 10u)]
        [InlineData(10u,    10u)]
        [InlineData(1380u,  200u, 100u, 50u, 20u, 10u)]
        public void TestGiveTheRest(params uint[] data)
        {
            var result = Rest.GiveTheRest(data[0]);
            
            Assert.Equal(data[Range.StartAt(1)], result);
        }
        
        [Fact]
        public void RestEqualsToZero_ThrowsArgumentException()
        {
            var rest = new Rest();
 
            var ex = Assert.Throws<ArgumentException>(() => Rest.GiveTheRest(0));
 
            Assert.Equal("Brak reszty do wydania. Wartość powinna być większa od zera.", ex.Message);
        }
        
        [Theory]
        [InlineData(211u)]
        [InlineData(3u)]
        [InlineData(1388u)]
        public void InvalidRest_ThrowsArgumentException(uint rest)
        {
            var ex = Assert.Throws<ArgumentException>(() => Rest.GiveTheRest(rest));
 
            Assert.StartsWith($"Nie można wydać {rest} reszty mając banknoty o nominałach", ex.Message);
        }
    }
}
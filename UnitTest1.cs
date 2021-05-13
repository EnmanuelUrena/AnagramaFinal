using System;
using Xunit;

namespace Anagrama_Final
{
    public class UnitTest1
    {
        [Fact]
        public void verificarAnagramaTest()
        {
            Assert.True(Program.verificarAnagrama("fresa","frase"));
        }
        [Fact]
        public void verificarAnagramaTestF()
        {
            Assert.False(Program.verificarAnagrama("lomo","romo"));
        }
         [Fact]
        public void verificarErrorTest()
        {
            Assert.Throws<ArgumentNullException>(() => Program.verificarAnagrama("",""));
        }
    }
}

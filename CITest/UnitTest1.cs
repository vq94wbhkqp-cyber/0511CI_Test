using CILib;
using System.Runtime.InteropServices;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var clac = new Class1();
            Assert.Equal(4, clac.Add(1, 3));
        }
    }
}
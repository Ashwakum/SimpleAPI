using System;
using Xunit;
using SimpleAPI.Controllers;

namespace simpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var retrunValue = controller.Get(1);
            Assert.Equal($"Something for me", retrunValue.ToString());
        }

        [Fact]
        public void Test1()
        {

        }
    }
}

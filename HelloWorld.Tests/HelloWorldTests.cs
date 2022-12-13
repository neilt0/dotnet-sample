using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void  HelloWorld_IsNotNull()
        {
          HelloWorld hi = new HelloWorld();
          Assert.IsNotNull(hi);
        }
    }
}


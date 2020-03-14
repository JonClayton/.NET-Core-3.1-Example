using FluentAssertions;
using Libraries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Libraries
{
    [TestClass]
    public class GreetingsTests
    {
        [TestMethod]
        public void Earthlings()
        {
            Greetings.Earthlings().Should().Be("Hello World");
        }
    }
}
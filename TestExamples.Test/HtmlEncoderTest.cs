using NUnit.Framework;
using System;
using TestExamples.Code;

namespace TestExamples.Test
{
    [TestFixture]
    public class HtmlEncoderTests
    {
        HtmlEncoder _enc=new HtmlEncoder();

        [SetUp]
        public void Config()
        {
            _enc=new HtmlEncoder();
        }

        [Test]
        public void Strong_WhenCalled_ReturnContentWithStrongWrapping()
        {
            var text = "Andreas";
            var result = _enc.Strong(text);
           
            Assert.That(result,Does.StartWith("<strong>").IgnoreCase);
            //Assert.That(result,Does.EndWith("</strong>").IgnoreCase);
            //Assert.That(result,Does.Contain(text).IgnoreCase);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExamples.Code;

namespace TestExamples.Test2
{
    [TestFixture]
    public  class HtmlEncoderTests
    {

        private HtmlEncoder _encoder;

        [SetUp]
        public void Config()
        {
            _encoder=new HtmlEncoder();
        }

        [Test]
        public void Strong_CallWithText_ReturnsTextEncapsulatedWithStrongTag()
        {
            var text = "Andreas";
            var result = _encoder.Strong(text);

            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain(text));
           
        }
    }
}

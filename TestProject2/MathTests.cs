using NUnit.Framework;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExamples.Code;

namespace TestProject2
{
    [TestFixture]
    public  class MathTests
    {

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnsOddNumbersUpToLimit()
        {
            var math=new Math();
            var result = math.GetOddNumbers(11);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5, 7, 9 }));
            Assert.That(result, Has.Exactly(1).EqualTo(3));
        }
    }
}

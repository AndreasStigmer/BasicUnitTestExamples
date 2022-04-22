using NUnit.Framework;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExamples.Code;

namespace TestExamples.Test2
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void Config()
        {
            _math = new Math();

        }

        [Test]
        public void Add_Call2Integers_ReturnsSumOfIntegers()
        {

            var result = _math.Add(2, 3);
            var result2 = _math.Add(8, 2);
            var result3 = _math.Add(5, 4);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(5));
                Assert.That(result2, Is.EqualTo(10));
                Assert.That(result3, Is.EqualTo(9));
            });
        }

        [Test]
        public void GetOddNumbers_GetOddNumberswithLimitOf13_ReturnsArrayWithOddNUmbersBelow13()
        {
            var limit = 13;
            var result = _math.GetOddNumbers(limit);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5, 7, 9, 11 }));

            
        }
       

    }
}

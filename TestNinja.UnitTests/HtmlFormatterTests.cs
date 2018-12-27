using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
   public class HtmlFormatterTests
    {
        private HtmlFormatter _formatter;

        [SetUp]
        public void SetUp()
        {
            _formatter = new HtmlFormatter();
        }


        [Test]
        public void FormatAsBold_WhenCalled_EncolseWithStrongElement()
        {
            var result = _formatter.FormatAsBold("abc");

            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
        }
    }
}

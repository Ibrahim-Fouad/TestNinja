using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {

        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            var logger = new ErrorLogger();
             
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidErrors_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();

            TestDelegate testDelegate = () => logger.Log(error);

            Assert.That(testDelegate, Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();


            var id = Guid.Empty;

            logger.ErrorLogged += (sender, guid) => id = guid;

            logger.Log("error");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

    }
}

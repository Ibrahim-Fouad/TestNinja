using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> stack;

        [SetUp]
        public void SetUp()
        {
            stack = new Stack<string>();
        }

        [Test]
        public void Push_NullObject_ThrowArgumentNullException()
        {
            string obj = null;
            Assert.That(() => stack.Push(obj), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidObject_CountWillBe1()
        {
            string obj = "abc";
            stack.Push(obj);
            int count = stack.Count;
            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_WhenCalledWithCountZero_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WhenCalledWithCount1_ReturnDataAndCountWillBe0()
        {
            string obj = "abc";
            stack.Push(obj);
            var result = stack.Pop();

            Assert.That(result, Is.EqualTo(obj));
            Assert.That(stack.Count, Is.EqualTo(0));
        }




    }
}

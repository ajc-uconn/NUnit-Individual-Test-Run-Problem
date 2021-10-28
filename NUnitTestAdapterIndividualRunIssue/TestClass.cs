using NUnit.Framework;

namespace NUnitTestAdapterIndividualRunIssue
{
    [TestFixture]
    internal class TestClass
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, true);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(true, true);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(true, true);
        }
    }
}

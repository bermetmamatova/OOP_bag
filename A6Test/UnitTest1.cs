using System.Collections.Generic;
using A6Set;

namespace A6Test
{
    [TestClass]
    public class UnitTest1
    {
       

        public Set set;
        [TestInitialize]
        public void SetUp()
        {
            set = new Set();

        }
        //arrange
        [TestMethod]
        public void TestInsert()
        {
            set.InsertElem(1);
            set.InsertElem(2);
            Assert.ThrowsException<Set.TheSetContains>(() => set.InsertElem(2));
            Assert.IsTrue(set.ContainsElem(1));
            Assert.IsTrue(set.ContainsElem(2));

        }
        [TestMethod]
        public void TestRemove()
        {
            set.InsertElem(1);
            set.InsertElem(2);
            Assert.ThrowsException<Set.TheSetDoesNotContain>(() => set.RemoveElem(4));
            Assert.IsFalse(set.ContainsElem(4));
            set.RemoveElem(1);
            Assert.IsTrue(set.ContainsElem(2));
            Assert.IsFalse(set.ContainsElem(1));
            Assert.ThrowsException<Set.TheSetDoesNotContain>(() => set.RemoveElem(1));

        }
        [TestMethod]
        public void TestIsContains()
        {
            set.InsertElem(1);
            set.InsertElem(2);
            set.InsertElem(3);
            Assert.IsTrue(set.ContainsElem(1));
            Assert.IsTrue(set.ContainsElem(2));
            Assert.IsTrue(set.ContainsElem(3));
            Assert.IsFalse(set.ContainsElem(4));

        }
        [TestMethod]
        public void TestIsEmpty()
        {
            Assert.IsTrue(set.IsEmpty());
            set.InsertElem(1);
            Assert.IsFalse(set.IsEmpty());
            set.RemoveElem(1);
            Assert.IsTrue(set.IsEmpty());
        }
        [TestMethod]
        public void TestReturnRandom()
        {
            set.InsertElem(1);
            set.InsertElem(2);
            set.InsertElem(3);
            int random= set.RandomElem();
            Assert.IsTrue(set.ContainsElem(random));
        }
        [TestMethod]
        public void TestNumEven()
        {
            set.InsertElem(1);
            set.InsertElem(2);
            set.InsertElem(4);
            int even = set.NumEven();
            Assert.IsTrue(even == 2);
            set.RemoveElem(1);
            set.RemoveElem(2);
            set.RemoveElem(4);
            Assert.ThrowsException<Set.TheSetIsEmpty>(() => set.NumEven());
        }
    }
}
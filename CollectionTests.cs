using Collections;
using NUnit.Framework;

namespace CollectionTests
{
    public class CollectionTests

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Empty_Constructor()
        {
            var nums = new Collection<int>();
            Assert.AreEqual(0, nums.Count);
            Assert.AreEqual(16, nums.Capacity);
        }

        [Test]
        public void Test_Add_Method()
        {
            var nums = new Collection<int>();
            nums.Add(10);
            Assert.AreEqual(1, nums.Count);
            Assert.AreEqual(nums[0], 10);
        }
        [Test]
        public void Test_Constructor_SingelItem()
        {
            var nums = new Collection<int>(10);
            Assert.That(nums.ToString(), Is.EqualTo("[10]"));

        }
        [Test]
        public void Test_Remove_At_Possition()
        {
            var nums = new Collection<int>(new int[] { 10, 20, 30, 40, 50 });
            nums.RemoveAt(0);
            Assert.AreEqual(nums[0], 20);
            Assert.AreEqual(nums.Count, 4);

        }
        [Test]
        public void Test_Clear()
        {
            var nums = new Collection<int>(new int[] { 10, 20, 30, 40, 50 });
            nums.Clear();
            Assert.AreEqual(nums.Count, 0);

        }

        [Test]
        public void Test_Exchange()
        {
            var nums = new Collection<int>(new int[] { 10, 20, 30, 40, 50 });
            nums.Exchange(1, 2);
            Assert.AreEqual(nums[1], 30);

        }

        [Test]
        public void Test_InsertAt()
        {
            var nums = new Collection<int>(new int[] { 10, 20, 30, 40, 50 });
            nums.InsertAt(1, 25);
            Assert.AreEqual(nums[1], 25);

        }

        [Test]
        public void Test_AddRange()
        {
            var nums = new Collection<int>();
            nums.AddRange(new int[] { 10, 20, 30, });
            Assert.AreEqual(nums.Count, 3);
            Assert.AreEqual(nums[0], 10);   
            Assert.That(nums.ToString(), Is.EqualTo("[10, 20, 30]"));
        }
                
    }
}
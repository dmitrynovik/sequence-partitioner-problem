using System.Collections.Generic;
using NUnit.Framework;

namespace SequencePartitioner
{
    [TestFixture]
    public class SequencePartitionerTest
    {
        [Test]
        public void TestAbc()
        {
            var result = SequencePartitioner<char>.Partition(new List<char>(new List<char>(new[] { 'a', 'b', 'c' })));
            CollectionAssert.AreEqual(new[] {1, 1, 1}, result);
        }

        [Test]
        public void TestAbca()
        {
            var result = SequencePartitioner<char>.Partition(new List<char>(new[] { 'a', 'b', 'c', 'a' }));
            CollectionAssert.AreEqual(new[] { 4 }, result);
        }

        [Test]
        public void Test978()
        {
            var result = SequencePartitioner<char>.Partition(new List<char>(new[]
            {
                'a', 'b', 'a', 'b', 'c', 'b', 'a', 'c', 'a',
                'd', 'e', 'f', 'e', 'g', 'd', 'e',
                'h', 'i', 'j', 'h', 'k', 'l', 'i', 'j'
            }));
            CollectionAssert.AreEqual(new[] { 9, 7, 8 }, result);
        }
    }
}

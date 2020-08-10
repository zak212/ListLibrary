using Xunit;

namespace ListLibrary.Tests
{
    /// <summary>
    /// Contains tests that ensure the correctness of the DoubleLinkedList class.
    /// </summary>
    public class DoubleLinkedListTests
    {
        [Fact]
        public void Verify_List_Test()
        {
            const string testValue1 = "test1";
            const string testValue2 = "test2";
            var list = new DoubleLinkedList();

            list.Add(testValue1);
            list.Add(testValue2);

            Assert.Equal(2, list.Count);
            Assert.Equal(testValue1, list.First.Value);
            Assert.Equal(testValue2, list.Last.Value);
            Assert.Equal(testValue2, list.First.Next.Value);
            Assert.Equal(testValue1, list.Last.Previous.Value);
        }

        [Fact]
        public void Add_Test()
        {
            const string testValue = "test";
            var list = new DoubleLinkedList();

            list.Add(testValue);
            
            Assert.Equal(1, list.Count);
            Assert.Equal(testValue, list.First.Value);
            Assert.Equal(testValue, list.Last.Value);
        }

        [Fact]
        public void Find_Test()
        {
            const string testValue = "test";
            var list = new DoubleLinkedList();
            list.Add(testValue);

            var node = list.Find(testValue);

            Assert.Equal(testValue, node.Value);
        }

        [Fact]
        public void Remove_Test()
        {
            const string testValue = "test";
            var list = new DoubleLinkedList();
            list.Add(testValue);

            var node = list.Find(testValue);
            list.Remove(node);

            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void ToArray_Test()
        {
            const string testValue1 = "test1";
            const string testValue2 = "test2";

            var list = new DoubleLinkedList();
            
            list.Add(testValue1);
            list.Add(testValue2);

            var array = list.ToArray();

            Assert.Equal(2, array.Length);
            Assert.Equal(testValue1, array[0]);
        }
    }
}

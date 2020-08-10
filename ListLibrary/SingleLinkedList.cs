using System;

namespace ListLibrary
{
    public class SingleLinkedList : ILinkedList
    {
        private ListNode _firstNode;
        private ListNode _lastNode;
        private int _count;

        public int Count => _count;
        public ListNode First => _firstNode;
        public ListNode Last => _lastNode;
        
        public void Add(string value)
        {
            var result = new ListNode(this, value);

            if (_lastNode == null)
            {
                _firstNode = result;
                _lastNode = result;
                _count++;
            }
            else
            {
                _lastNode.next = result;
                _lastNode = result;

                _count++;
            }
        }

        public ListNode Find(string value)
        {
            if (_firstNode == null)
            {
                return null;
            }

            if (value == null)
            {
                return null;
            }

            var node = _firstNode;

            do
            {
                if (node.item == value)
                {
                    return node;
                }

                node = node.next;
            } while (node != null);

            return null;
        }

        public void Remove(ListNode node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node.list != this)
            {
                throw new InvalidOperationException("The node does not belong to current list.");
            }

            if (_count == 0)
            {
                throw new InvalidOperationException("This method shouldn't be called on empty list!");
            }

            var prevNode = FindPreviousNode(node);

            if (prevNode != null)
            {
                prevNode.next = node.next;
            }

            if (_lastNode == node)
            {
                _lastNode = prevNode;
            }

            node.UnLink();

            _count--;
        }

        public string[] ToArray()
        {
            if (_count == 0)
            {
                return Array.Empty<string>();
            }

            var array = new string[_count];

            var node = _firstNode;
            var index = 0;

            do
            {
                array[index++] = node.item;
                node = node.next;
            } while (node != null);

            return array;
        }

        private ListNode FindPreviousNode(ListNode currentNode)
        {
            if (currentNode == null)
            {
                return null;
            }

            var node = _firstNode;

            do
            {
                if (node.next == currentNode)
                {
                    return node;
                }

                node = node.next;
            } while (node != null);

            return null;
        }
    }
}
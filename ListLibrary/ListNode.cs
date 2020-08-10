namespace ListLibrary
{
    public sealed class ListNode
    {
        internal ILinkedList list;
        internal ListNode next;
        internal ListNode prev;
        internal string item;

        public ListNode(string value)
        {
            item = value;
        }

        internal ListNode(ILinkedList linkedList, string value)
        {
            list = linkedList;
            item = value;
        }

        public string Value
        {
            get => item;
            set => item = value;
        }

        public ListNode Next => next;

        public ListNode Previous => prev;

        internal void UnLink()
        {
            list = null;
            next = null;
            prev = null;
        }
    }
}

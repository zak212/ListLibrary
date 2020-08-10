namespace ListLibrary
{
    public interface ILinkedList
    {
        void Add(string value);
        ListNode Find(string value);
        void Remove(ListNode node);
        string[] ToArray();
    }
}
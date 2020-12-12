using System;
namespace Stack
{
    public class Item<T>
    {
        public T Value { get; set; }
        public Item<T> Next { get; set; }
        public Item<T> Back { get; set; }
    }

    public class Stack<T>
    {
        private Item<T> head;

        public void Push(T item)
        {
            if (head == null)
            {
                head = new Item<T> {Value = item, Next = null};
            }
            else
            {
                var newItem = new Item<T> { Value = item, Next = null, Back = head};
                head.Next = newItem;
                head = newItem;
            }
        }

        public T Pop()
        {
            var result = head.Value;
            head = head.Back;
            return result;
        }
    }
}
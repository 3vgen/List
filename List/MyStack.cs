using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class MyStack<T>: IEnumerable<T>
    {
        public Item<T> Head { get; private set; }
        public int Count { get; private set; }
        public bool IsEmpty
        {
            get { return Count == 0; }
        }
        public void Push(T data)
        {
            Item<T> node = new Item<T>(data);
            node.Next = Head;
            Head = node;
            Count++;
        }
        public T Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст");
            Item<T> temp = Head;
            Head = Head.Next;
            Count--;
            return temp.Data;
        }
        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст");
            return Head.Data;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            Item<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Item<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        
    }

}

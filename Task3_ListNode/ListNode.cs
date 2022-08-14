using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Написать две функции: 
/// замены элемента в списке и объединения двух списков.

namespace Task3_ListNode
{
    //реализовали узел односвязного списка
    class ListNode<T>
    {
        public ListNode(T value)
        {
            Value = value;

        }
        public ListNode<T> next
        {
            get => Next;
            set
            {
                if (value != null)
                {
                    Next = value;
                }
            }
        }
        public readonly T Value;
        public ListNode<T> Next;

    }
}

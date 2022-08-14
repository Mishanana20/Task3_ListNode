using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_ListNode
{
    //реализуем инициализацию односвязного списка и работу с ним
    public class LinkedList<T>
    {
        ListNode<T> head;
        ListNode<T> tail;
        private int length; //для вывода кол-ва элементов в списке

        public void Add(T value)
        {
            ListNode<T> listNode = new ListNode<T>(value);

            if (head == null)
            { 
                head = listNode; 
            }
            else
            {
                tail.Next = listNode; 
            }
            tail = listNode;
            length++;
        }

        public static LinkedList<T> Union(LinkedList<T> first, LinkedList<T> second)
        {
            first.tail.next = second.head;
            first.length += second.length;
            return first;
        }

        public void Replace(int position, T value)
        {
            if (position < 0 || position >= length)
            {
                throw new IndexOutOfRangeException("Элемент не найден");
            }

            var newListNode = new ListNode<T>(value);

            if (position == 0)
            {
                newListNode.Next = head.Next;
                head = newListNode;
                return;
            }

            //проходимся по списку до нужной позиции
            var currentListNode = head;
            for (int i = 1; i < position; i++)
            {
                currentListNode = currentListNode.Next;
            }
            newListNode.Next = currentListNode.Next.Next;
            currentListNode.Next = newListNode;
        }

        public string ShowList()
        {
            StringBuilder sb = new StringBuilder();

            var listNode = head;
            while (listNode != null)
            {
                sb.Append(listNode.Value + " ");
                listNode = listNode.Next;
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_ListNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> firstList = new LinkedList<int>();
            for (int i = 0; i <= 10; i++)
            {
                firstList.Add(i);
            }
            Console.WriteLine(firstList.ShowList() + "\n");

            LinkedList<int> listSecond = new LinkedList<int>();
            for (int i = 11; i < 20; i++)
            {
                listSecond.Add(i);
            }
            Console.WriteLine(listSecond.ShowList() + "\n");

            //объединение двух списков
            firstList = LinkedList<int>.Union(firstList, listSecond);

            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine(firstList.ShowList() + "\n");

            //замена элемента по списку
            firstList.Replace(12, 455);

            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Console.WriteLine(firstList.ShowList() + "\n");

            Console.ReadLine();
        }
    }
}

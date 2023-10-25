using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NonGeneric
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            for (int i = 0; i < arrayList.Count; i++) {
                Console.WriteLine(arrayList[i]);
            }
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveAt(1);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Clear();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.Contains(4));
            Console.WriteLine(arrayList.IndexOf(4));

        }
        public void StackHandling()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push("ss");
            stack.Push(1.2);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine("count : "+stack.Count);
        }
        public void QueueHandling()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(12.34567);
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
        }
        public void HashHandling()
        {
            Hashtable hash = new Hashtable();
            hash.Add("a", "b");
            hash.Add("c", "d");
            hash.Add("d", "e");
            hash.Add("e", "f");
            hash.Add(1, "gq");
            hash.Add(2, 2);
            hash.Add(3, 3);
            foreach(var item in hash)
            {
                Console.WriteLine(item);
            }
            hash.Remove("c");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(hash.ContainsKey(1));
            Console.WriteLine(hash.Count);
            foreach (var item in hash.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in hash.Values)
            {
                Console.WriteLine(item);
            }
        }
        public void SortListHandling()
        {

        }
    }
}

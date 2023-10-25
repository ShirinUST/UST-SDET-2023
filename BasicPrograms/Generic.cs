using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Generic
    {
        public void ListHandling()
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(655);
            foreach (int i in numbers) {
                Console.WriteLine(i);
            }
            numbers.Reverse();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Remove(1);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Clear();
            Console.WriteLine("--------------");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(numbers.Contains(1));
        }
        public void StackHandling()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine("count : " + stack.Count);
        }
        public void QueueHandling()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
        }
        public void DictionaryHandling()
        {
            Dictionary<string,int> dictionary = new Dictionary<string,int>();
            dictionary.Add("Shirin", 90);
            dictionary.Add("Jachithra", 90);
            dictionary.Add("Vishnu", 50);
            dictionary.Add("Gokul", 30);
            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }
            dictionary.Remove("Shirin");
            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dictionary.ContainsKey("Vishnu"));
            foreach(var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            foreach(var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
        }
        public void SortedListHandling()
        {
            
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_lab_1
{
    public class Node 
    {
        public int data;
        public Node next;

        // Constructor to create a new node.Next is by default initialized as null  
        public Node(int d)
        {
            data = d;
            next = null;
        }

       
    }
    public class LinkListStack<T> : IEnumerable, ICollection, IEnumerable<T>,IReadOnlyCollection<T>
    {
        Node top;
        Node head = null;
        Node current = null;
        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public LinkListStack()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return;
            }

            Console.WriteLine("Item popped is {0}", top.data);
            top = top.next;
        }
        public void Peek()
        {
            if (top == null)
            {
                
                throw new BaseException(string.Format("Stack Underflow."));
                
                
            }

            Console.WriteLine("{0} is on the top of Stack", this.top.data);
        }
        public int Counter()
        {
            var counter = 0;
            var node = top;
            while (!ReferenceEquals(node, head))
            {
                node = node.next;
                ++counter;
            }
            //Console.WriteLine(counter);
            return counter;
        }
        public void Clear()
        {
            
            var node = top;
            while (!ReferenceEquals(node, head))
            {
                node = node.next;
                top = top.next;
            }
        }
        public void Contains(int item_to_search)
        {
            var counter = 0;
            var node = top;
            if (node.data != item_to_search)
            {
                node = node.next;
                
            }
            else
            {
                Console.WriteLine("Contains");
            }
        }
        public bool Contains(int item_to_search,bool bool1)
        {
            var counter = 0;
            var node = top;
            if (node.data != item_to_search)
            {
                node = node.next;

            }
            if (node.data == item_to_search)
            {
                return true;

            }
            return false;
        }
        public class BaseException : Exception
        {
            public BaseException(string message)
               : base(message)
            {
            }
        }
        public void PrintStack()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }

            Node temp = this.top;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        //System.Collections.IEnumerator IEnumerable.GetEnumerator()
        //{
        //    // uses the strongly typed IEnumerable<T> implementation
        //    return this.GetEnumerator();
        //}

        public IEnumerator GetEnumerator()
        {
            current = top;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }
        //void ICollection.CopyTo(Array myArr, int index)
        //{
        //    foreach (int i in intArr)
        //    {
        //        myArr.SetValue(i, index);
        //        index = index + 1;
        //    }
        //}
        public int[] ToArray()
        {
            var count=20;
            var result = new int[count];
            var index = 0;
            var node = top;
            while (node != null)
            {
                result[index] = node.data;
                node = node.next;
            }

            return result;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }

}

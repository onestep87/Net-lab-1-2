using System;
using System.Collections.Generic;

namespace Net_lab_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedListStackCaller();
          
           
            LinkListStack<int> linkListStack = new LinkListStack<int>();
            linkListStack.Push(5);
            linkListStack.Push(5);
            linkListStack.Push(5);
            linkListStack.Push(5);
            int[] arr = new int[5];
            int[] arr2 = new int[100];
            arr = linkListStack.ToArray();
            //int[] array = linkListStack.ToArray();
            arr.CopyTo(arr2, 0);
            linkListStack.Counter();
            
        }
        public static void LinkedListStackCaller()
        {
            LinkListStack<int> linkList = new LinkListStack<int>();
            bool flag = true;
            while (flag==true)
            {

                string var = null;
                int num;

                Console.WriteLine("\n1-Push\n2-Pop\n3-Peek\n4-Print\n5-Exit\n");
                var = Console.ReadLine();

                switch (var)
                {

                    case "1":
                        Console.WriteLine("enter number");
                        num = 0;
                        try
                        { 
                            num = Convert.ToInt32(Console.ReadLine());
                            linkList.Push(num);
                            
                        }
                        catch 
                        { 
                            Console.WriteLine("Ivalid input"); 
                        }
                        break;
                        
                    case "2":
                        linkList.Pop();
                        break;
                    case "3":
                        linkList.Peek();
                        break;
                    case "4":
                        linkList.PrintStack();
                        break;                   
                    case "5":
                        linkList.Counter();
                        
                        break;
                    case "6":
                        linkList.Clear();
                        
                        break;
                    case "7":
                        Console.WriteLine("enter number");
                        num = 0;
                        try
                        {
                            num = Convert.ToInt32(Console.ReadLine());
                            linkList.Contains(num);

                        }
                        catch
                        {
                            Console.WriteLine("Ivalid input");
                        }
                        break;
                    case "8":

                        flag = false;
                        break;
                }
            }

        }
        //public int  Convertor(int num)
        //{
        //    if(num=int)
        //    Convert.ToInt32(Console.ReadLine());
        //    return 1;
        //}
    }
}

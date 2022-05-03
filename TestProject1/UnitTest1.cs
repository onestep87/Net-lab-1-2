using NUnit.Framework;

using Net_lab_1;
using static Net_lab_1.LinkListStack<int>;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LinkList_Push_Test()
        {
            //arrange

            LinkListStack<int> linkList = new LinkListStack<int>();

            //act
            linkList.Push(7);
            string ConsoleOutput = "7";
            string test;

            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                //All console outputs goes here
                foreach (var v in linkList)
                {
                    Console.WriteLine(v);
                }

                string consoleOutput = stringWriter.ToString();
                test = consoleOutput;

            }

            test = test.Replace("\r\n", string.Empty);
            //assert

            Assert.AreEqual(ConsoleOutput, test);

        }
        [Test]
        public void LinkList_Pop_Test()
        {

            //arrange

            LinkListStack<int> linkList = new LinkListStack<int>();

            //act

            linkList.Push(5);
            linkList.Push(7);
            linkList.Pop();
            string ConsoleOutput = "5";
            string test;
            using (StringWriter stringWriter1 = new StringWriter())
            {
                Console.SetOut(stringWriter1);

                //All console outputs goes here


                foreach (var v in linkList)
                {
                    Console.WriteLine(v);
                }
                string consoleOutput = stringWriter1.ToString();
                test = consoleOutput;

                stringWriter1.Close();
            }
            test = test.Replace("\r\n", string.Empty);

            //assert

            Assert.AreEqual(ConsoleOutput, test);
        }
        [Test]
        public void LinkList_Peek_Test()
        {
            LinkListStack<int> linkList = new LinkListStack<int>();

            //act
            linkList.Push(7);
            string ConsoleOutput = "7 is on the top of Stack";
            string test;

            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                //All console outputs goes here
                linkList.Peek();

                string consoleOutput = stringWriter.ToString();
                test = consoleOutput;
            }
            test = test.Replace("\r\n", string.Empty);
            //assert

            Assert.AreEqual(ConsoleOutput, test);
        }
        [Test]
        public void LinkList_Clear_Test()
        {
            LinkListStack<int> linkList = new LinkListStack<int>();
            linkList.Push(5);
            linkList.Clear();
            Assert.That(linkList.Counter() == 0);

        }
        [Test]
        public void LinkList_Counter_Test()
        {
            LinkListStack<int> linkList = new LinkListStack<int>();
            linkList.Push(5);
            Assert.That(linkList.Counter() == 1);

        }
        [Test]
        public void LinkList_ToArray_Test()
        {
            LinkListStack<int> linkList = new LinkListStack<int>();
            int[] arr1 = new int[100];
            linkList.ToArray();
            int[] arr2 = new int[100];
            linkList.CopyTo(arr2, 0);
            Assert.AreEqual(arr2, arr1);
                       
        }
        [Test]
        public void LinkList_Contains_Test()
        {
            LinkListStack<int> linkList = new LinkListStack<int>();
            linkList.Push(5);
            bool true1 = false;
            Assert.IsTrue(linkList.Contains(5, true1));
            
        }
    }
}
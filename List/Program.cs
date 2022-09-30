using System.Collections;
using System.Collections.Generic;
using System;

namespace List
{
   


    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(32);
            stack.Push(44);
            stack.Push(4);
         
            foreach (var item in stack) Console.WriteLine(item);

            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Head);



            foreach (var itme in stack) Console.WriteLine(itme.ToString());

            Console.WriteLine("djsabdb");
            Console.WriteLine("dkjajdsado");
           
        }
    }
}

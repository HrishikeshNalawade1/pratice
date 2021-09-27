using System;
using System.Collections.Generic;

namespace Gen_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(88);
            st.Push(33);
            st.Push(45);
            st.Push(56);
            st.Push(44);
            foreach(int ob in st)
            {
                Console.Write(ob+" ");
            }
            Console.WriteLine("\nRemove an element");
            st.Pop();
            foreach (int ob in st)
            {
                Console.Write(ob+" ");
            }
            
        }
       
    }
}

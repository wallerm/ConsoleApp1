using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public delegate void gametest();
    public interface MyClass
    {
        event gametest G_del;
        string m_name
        {
            set; 
        }
        string this[int index]
        {
            get;
        }
    }
    public class MTinterface<T>
    {
        public void printT(T hello) { }
       
    }
    public class helloTinterface<T>: MTinterface<T>
    {
        public void printT(T hello) { Console.WriteLine(hello); }
    }
    public class hello : MyClass
    {
        ArrayList m_versions = new ArrayList  { "a1", "a2" };
        public string this[int index]
        {
            get =>
getFriendName(); set => throw new NotImplementedException();
        }

        public String m_name { set => m_name = "sdf"; }

        public event gametest G_del;

        private string getFriendName()
        {
            return "hello friend";
        }
        public  void print_v()
        {
            foreach(string k in m_versions) Console.WriteLine(k);
            List<String> list = new List<String>() { "25", "哈3", "26", "花朵" };
            IEnumerator listEnumerator = list.GetEnumerator();
            while (listEnumerator.MoveNext())
            {
                Console.WriteLine(listEnumerator.Current);
            }
            
        }
    }
}

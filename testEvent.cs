using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    delegate void showhello(string a);
    public delegate void NumManipulationHandler();
    public class EventTest
    {
        private int value;

        public event NumManipulationHandler ChangeNum;
        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum(); /* 事件被触发 */
            }
            else
            {
                Console.WriteLine("event not fire");
                Console.ReadKey(); /* 回车继续 */
            }
        }


        public EventTest()
        {
            value = 5;
        }


        public void SetValue(int n)
        {
            if (value != n)
            {
               // value = n;
                OnNumChanged();
            }
        }
    }
    public class subscribEvent
    {
        public void printf()
        {
            Console.WriteLine("event fire");
            //Console.ReadKey(); /* 回车继续 */
        }
    }
    public class showenvent
    {
        public void printf()
        {
            Console.WriteLine("event click");
           
        }
    }
    class testEvent
    {
        public event showhello say_hi;
        public testEvent()
        {

        }
        public void who_said(string b)
        {
            string des = "niu bi";
            if (b == "c")
            {
                des = "nike";
               
            }
            say_hi(des);
        }
    }
    class jim
    {
        private string m_country;
        public jim(testEvent a,string country)
        {
            a.say_hi += jim_say;
            m_country = country;
        }

        public void jim_say(string a)
        {
            Console.WriteLine(m_country +"jim say hello:"+a);
        }
    }
    class tom
    {
        private string m_country;
        public tom(testEvent a, string country)
        {
            a.say_hi += tom_say;
            m_country = country;
        }
        public void tom_say(string a)
        {
            Console.WriteLine(m_country+"tom say hello:"+a);
        }
    }

}

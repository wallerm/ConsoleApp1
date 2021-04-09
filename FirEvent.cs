using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public delegate void Handler(string a);
    class Incrementer//发布者
    {
        public event Handler CountedADozen;
        public void DoCount()//触发事件的方法
        {
            for (int i = 1; i < 50; i++)
            {
                if (i % 12 == 0 && CountedADozen != null)//每增加12个计数就触发事件一次，私有委托为空就不执行
                {
                    CountedADozen("");
                }
            }
        }
    }

    class Dozens
    {
        public Dozens(Incrementer incrementer)
        {
            incrementer.CountedADozen += IncrementDozensCount;//在发布者私有委托里增加方法
        }


        void IncrementDozensCount(string a)//事件成员被触发时要调用的方法
        {
            Console.WriteLine("Dozens");
        }
    }




    class SomeOtherClass
    {
        public SomeOtherClass()
        {

        }
            public SomeOtherClass(Incrementer incrementer)
        {
            incrementer.CountedADozen += DoSomething;//在发布者私有委托里增加方法
        }


        public void DoSomething(string a)//事件成员被触发时要调用的方法
        {
            Console.WriteLine("SomeOtherClass");
        }
    }

}

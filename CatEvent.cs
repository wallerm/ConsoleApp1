using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

        //定义猫叫委托
        public delegate void CatCallEventHandler();
        public class Cat
        {
            //定义猫叫事件
            public event CatCallEventHandler CatCall;
            public void OnCatCall()
            {
                Console.WriteLine("猫叫了一声");
                CatCall?.Invoke();
            }
        }
        public class Mouse
        {
            //定义老鼠跑掉方法
            public void MouseRun()
            {
                Console.WriteLine("老鼠跑了");
            }
        }
        public class People
        {
            //定义主人醒来方法
            public void WakeUp()
            {
                Console.WriteLine("主人醒了");
            }
        }

}

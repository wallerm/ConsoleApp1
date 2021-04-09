using System;

namespace ConsoleApp1
{
    class Program
    {
        delegate void GreetingDelegate(string s); //声明委托，定义Greeting方法的类

        public static void Hello(string s)
        {
            Console.WriteLine("  Hello, {0}!", s);
            // do something (hug or shake hand...)
        }
        public static void Goodbye(string s)
        {
            Console.WriteLine("  Goodbye, {0}!", s);
            // do something (hug or wave hand...)
        }
        static void MakeGreeting(string name, GreetingDelegate d)
        {
            d(name);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Rectangle hlelo = new Rectangle(10,20);
            //hlelo.Display();
            //System.Attribute[] attrs = System.Attribute.GetCustomAttributes(typeof(Rectangle));
            //foreach (System.Attribute attr in attrs)
            //{
            //    DeBugInfo a = (DeBugInfo)attr;
            //    Console.WriteLine(a.BugNo);
            //}
            // *********************firdelegate.cs*********************
            //FirstDelegate f_delegate = new FirstDelegate();
            //printString ps1 = new printString(FirstDelegate.WriteToScreen);
            //printString ps2 = new printString(FirstDelegate.WriteToFile);
            //FirstDelegate.sendString(ps1);
            //FirstDelegate.sendString(ps2);
            //Console.ReadKey();
            //*********************secdelegate.cs************************
            //ProductFactory productFactory = new ProductFactory();
            //WrapFactory wrapFactory = new WrapFactory();
            //Func<string, Product> hello;
            //Func<string,Product> func1 =new Func<string, Product>(productFactory.MakePizza);
            //Func<string,Product> func2 = new Func<string, Product>(productFactory.MakeToyCar);
            //hello = func1 + func2;
            //Logger logger = new Logger();
            //Action<Product> log = new Action<Product>(logger.Log); //Log的委托;

            //Box box1 = wrapFactory.WrapProduct(hello("sdf"), log);
            ////Box box2 = wrapFactory.WrapProduct(func2("safdsd"), log);

            //Console.WriteLine(box1.Product.Name);
            /**********************firevent.cs**********************/
            //Incrementer incrementer = new Incrementer();
            //Dozens dozensCounter = new Dozens(incrementer);
            SomeOtherClass other = new SomeOtherClass();
            ////incrementer.CountedADozen()     
            //incrementer.DoCount();
            testEvent say = new testEvent();
            jim a = new jim(say,"america");
            tom b = new tom(say,"france");
            //say.who_said("c");
            //EventTest e = new EventTest(); /* 实例化对象,第一次没有触发事件 */
            //subscribEvent v = new subscribEvent(); /* 实例化对象 */
            //e.ChangeNum += v.printf; /* 注册 */
            //showenvent t = new showenvent();
            //e.ChangeNum += t.printf;
            //e.SetValue(7);
            //e.SetValue(11);
            //hello test = new hello();
            //test.print_v();
            //helloTinterface<string> printT = new helloTinterface<string>();
            //printT.printT("show printT");
            /************************************catevent***************************/
            Cat cat = new Cat();
            Mouse m = new Mouse();
            People p = new People();
            //关联绑定 
            cat.CatCall += new CatCallEventHandler(m.MouseRun);
            cat.CatCall += new CatCallEventHandler(p.WakeUp);
            cat.OnCatCall();

            Console.ReadKey();
        }
    }
}

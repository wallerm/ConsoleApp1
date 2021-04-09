using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ConsoleApp1
{
    // 委托声明
    public delegate void printString(string s);
    class FirstDelegate
    {
         static FileStream fs;
         static StreamWriter sw;


        // 该方法打印到控制台
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }
        // 该方法打印到文件
        public static void WriteToFile(string s)
        {
            fs = new FileStream("D:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        // 该方法把委托作为参数，并使用它调用方法
        public static void sendString(printString ps)
        {
            ps("Hello World");
        }
    }
}

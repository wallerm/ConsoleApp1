using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Product //产品类
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        class Box //盒子类
        {
            public Product Product { get; set; }
        }
        class Logger
        {
            public void Log(Product product)
            {
                Console.WriteLine(product.Price);
            }
        }
        class WrapFactory  //包装工厂
        {
            public Box WrapProduct(Product getProduct, Action<Product> logCallback)
            {
                Box box = new Box();
                //Product product = getProduct;//此处使用的是间接的同步调用，如果使用间接异步调用用BeginInvoke();
                if (getProduct.Price > 50) //如果产品价格大于50，就执行回调方法;
                {
                    logCallback(getProduct);
                }
                box.Product = getProduct;
                return box;
            }
        }
        class ProductFactory  //产品工厂
        {
            public Product MakePizza(string pname)
            {
                Product product = new Product();
                product.Name = pname;
                product.Price = 30;
                return product;
            }
            public Product MakeToyCar(string uname)
            {
                Product product = new Product();
                product.Name = uname;
                product.Price = 100;
                return product;
            }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ishchenko.Lab01.Task02.ClassLib;

namespace Task02.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product();
            prod1.setHeight(22);
            prod1.setId(21321);
            prod1.setName("Name");
            prod1.setWidth(233);
            prod1.setPrice(40);

            Product prod2 = new Product();
            prod2.setHeight(44324);
            prod2.setId(4324);
            prod2.setName("Not Name");
            prod2.setWidth(213);
            prod2.setPrice(876);

            Product prod3 = new Product();
            prod3.setHeight(33);
            prod3.setId(312);
            prod3.setName("Not Name Too");
            prod3.setWidth(876);
            prod3.setPrice(98);

            prod1.print();
            prod2.print();
            prod3.print();
        }
    }
}

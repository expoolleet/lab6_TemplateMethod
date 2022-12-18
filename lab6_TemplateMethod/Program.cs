using System;
using lab6_TemplateMethod.Beverages;

namespace lab6_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffe = new Coffe();
            Beverage tea = new Tea();

            coffe.Prepare();
            Console.WriteLine("\n");
            tea.Prepare();
            Console.ReadKey();
        }
    }
}

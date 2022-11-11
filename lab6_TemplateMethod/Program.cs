using lab6_TemplateMethod.Drinks;
using System;

namespace lab6_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffe = new Coffe();
            Beverage tea = new Tea();

            coffe.Prepare(true);
            Console.WriteLine("\n");
            tea.Prepare(false);
            Console.ReadKey();
        }
    }
}

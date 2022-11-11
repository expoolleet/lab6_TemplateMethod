using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_TemplateMethod.Beverages
{
    class Coffe : Beverage
    {
        private protected override void Brew() => Console.WriteLine("Заварить кофе");

        private protected override bool CustomerWantsCondiments()
        {
            return false;
        }

        private protected override void AddCondiments()
        {
            Console.WriteLine("Добавить молоко в кофе");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_TemplateMethod.Drinks
{
    class Coffe : Beverage
    {
        private protected override void Brew() => Console.WriteLine("Заварить кофе");
        private protected override bool AddCondiments()
        {
            Console.WriteLine("Добавить молоко в кофе");
            return base.AddCondiments();
        }
    }
}

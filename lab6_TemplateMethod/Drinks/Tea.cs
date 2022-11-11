using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_TemplateMethod.Drinks
{
    class Tea : Beverage
    {
        private protected override void Brew() => Console.WriteLine("Заварить чай");

        private protected override bool AddCondiments()
        {
            return false;
        }

        private protected override void CustomerWantsCondiments(bool condition)
        {
            switch (condition)
            {
                case true:
                    Console.WriteLine("Добавить молоко в чай");
                    base.AddCondiments();
                    break;
                case false: break;

            }
        }


    }
}

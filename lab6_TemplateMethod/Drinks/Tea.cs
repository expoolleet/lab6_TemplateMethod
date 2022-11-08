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


    }
}

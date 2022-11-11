using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_TemplateMethod.Beverages
{
    abstract class Beverage
    {
        private protected void BoilWater() => Console.WriteLine("Вскипятить воду");
        abstract private protected void Brew();
        private protected void Pour() => Console.WriteLine("Налить в чашку");
        abstract private protected void AddCondiments();


        private protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public void Prepare()
        {
            BoilWater();
            Brew();
            Pour();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }
    }
}

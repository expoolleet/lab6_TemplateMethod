using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_TemplateMethod.Drinks
{
    abstract class Beverage
    {
        private protected void BoilWater() => Console.WriteLine("Вскипятить воду");
        private protected virtual void Brew() => Console.WriteLine("Заварить напиток");
        private protected void Pour() => Console.WriteLine("Налить в чашку");
        private protected bool AddCondiments()
        {
            return true;
        }

        private protected virtual void CustomerWantsCondiments(bool condition)
        {
            switch (condition)
            {
                case true: AddCondiments(); break;
                case false: break;
                default: throw new ArgumentException();
            }
        }
        //private protected virtual bool Addition(bool condition)
        //{
        //    if (condition)
        //    {
        //        return true;
        //    }
        //   else
        //    {
        //        return false;
        //    }
        //}
        public void Make()
        {
            BoilWater();
            Brew();
            Pour();
            AddCondiments();
        }
    }
}

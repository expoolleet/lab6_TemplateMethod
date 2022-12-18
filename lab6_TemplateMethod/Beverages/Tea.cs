using System;

namespace lab6_TemplateMethod.Beverages
{
    class Tea : Beverage
    {
        private protected override void Brew() => Console.WriteLine("Заварить чай");

        private protected override void AddCondiments()
        {
            Console.WriteLine("Добавить молоко в чай");
        }
    }
}

using System;

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

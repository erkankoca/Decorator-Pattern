using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Entity;

namespace DecoratorPattern {
    public class MilkDecorator : Decorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
            //description += " with Milk";
            //cost += 2;
            SetExtOrder(" with Milk");
            SetExtCost(2);
        }
        public override void GetCost()
        {
            base.GetCost();   
        }
        private void SetExtCost( int ExtraPrice)
        {
            base.SetCost(ExtraPrice);
        }
        private void SetExtOrder(string ExtraOrder)
        {
            base.SetOrder(ExtraOrder);
        }

    }

    public class SugarDecorator : Decorator
    {
        public SugarDecorator(IBeverage beverage) : base(beverage)
        {
            //description += " with Sugar";
            //cost += 1;
            SetExtOrder(" with Sugar");
            SetExtCost(1);
        }
        public override void GetCost()
        {
            base.GetCost();
        }
        public void SetExtCost(int ExtraPrice)
        {
            base.SetCost(ExtraPrice);
        }
        private void SetExtOrder(string ExtraOrder)
        {
            base.SetOrder(ExtraOrder);
        }
    }
}

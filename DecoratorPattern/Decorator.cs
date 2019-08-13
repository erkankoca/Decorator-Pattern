using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Entity;

namespace DecoratorPattern {
    public abstract class Decorator : IBeverage
    {
        IBeverage beverage;

        //protected string description = null;
        //protected int cost = 0;

        public Decorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        //public string GetDescription()
        //{
        //    return beverage.GetDescription();// + description;
        //}

        public virtual void GetCost()
        {
            beverage.GetCost();//; + cost;
        }
        public virtual void SetCost( int ExtraPrice)
        {
            beverage.SetCost(ExtraPrice);
        }

        public virtual void SetOrder( string ExtraOrder)
        {
            beverage.SetOrder(ExtraOrder);
        }
    }
}

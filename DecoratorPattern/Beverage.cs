using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Entity {
    public interface IBeverage
    {
        //string GetDescription();
        void GetCost();
        void SetCost(int ExtraPrice);
        void SetOrder(string ExtraOrder);
    }

 public class GeneralBeverage : IBeverage
    {
        private string order;
        private int cost;

        public GeneralBeverage(string Order,int Cost)
        {
            this.order = Order;
            this.cost = Cost;
        }

        public void SetCost (int ExtraPrice)
        {
            cost = cost + ExtraPrice;
        }

        public void GetCost()
        {
            Console.WriteLine("Order: {0}, Cost: {1} ", order, cost);
            //return cost;
        }


        public void SetOrder( string ExtraOrder)
        {
            order = order + ExtraOrder;
        }
    }

    //public class Espresso : IBeverage
    //{
    //    public string GetDescription() {
    //        return "Decaf";
    //    }

    //    public int GetCost() {
    //        return 7;
    //    }
    //}

    //public class Decaf : IBeverage
    //{
    //    public string GetDescription()
    //    {
    //        return "Espresso";
    //    }

    //    public int GetCost()
    //    {
    //        return 5;
    //    }
    //}
}

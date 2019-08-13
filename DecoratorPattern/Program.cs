using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Entity;

namespace DecoratorPattern {
    class Program {
        static void Main(string[] args) {

            //var firstOrder = new MilkDecorator(new SugarDecorator(new Espresso()));
            //var billOfFirstOrder = $"Price of {firstOrder.GetDescription()} is {firstOrder.GetCost()} dollars";

            //var secondOrder = new Espresso();
            //var billOfSecondOrder = $"Price of {secondOrder.GetDescription()} is {secondOrder.GetCost()} dollars";

            //var thirdOrder = new SugarDecorator(new SugarDecorator(new MilkDecorator(new Espresso())));
            //var billOfThirdOrder = $"Price of {thirdOrder.GetDescription()} is {thirdOrder.GetCost()} dollars";


            //Console.WriteLine(billOfFirstOrder);
            //Console.WriteLine(billOfSecondOrder);
            //Console.WriteLine(billOfThirdOrder);
            //Console.ReadKey();

            IBeverage espressoBeverage = new GeneralBeverage(Beverages.Espresso.ToString(),(int) Beverages.Espresso);
            IBeverage espressoWithMilk = new MilkDecorator(espressoBeverage);
            IBeverage espressoWithMilkWithSugar = new SugarDecorator(espressoWithMilk);
            espressoWithMilkWithSugar.GetCost();



            IBeverage deCafBeverage = new GeneralBeverage(Beverages.DeCaf.ToString(), (int)Beverages.DeCaf);
            IBeverage deCafWithMilk = new MilkDecorator(deCafBeverage);
            IBeverage deCafWithMilkWithSugar = new SugarDecorator(deCafWithMilk);
            deCafWithMilkWithSugar.GetCost();
            Console.ReadKey();


        }
        public enum Beverages : byte
        {
            Espresso  = 5,
            DeCaf = 7
        }
    }
}

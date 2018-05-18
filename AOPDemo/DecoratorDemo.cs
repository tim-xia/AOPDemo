using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo
{
    /// <summary>
    /// 装饰者Demo类
    /// </summary>
    public class DecoratorDemo
    {
        /// <summary>
        /// Component
        /// </summary>
        public interface IBeverage
        {
            string GetDescription();
            double GetPrice();
        }

        /// <summary>
        /// ConcreteComponent
        /// </summary>
        public class CoffeeBean1 : IBeverage
        {
            private string description = "第一种咖啡豆";
            public string GetDescription()
            {
                return description;
            }

            public double GetPrice()
            {
                return 50;
            }
        }

        /// <summary>
        /// ConcreteComponent
        /// </summary>
        public class CoffeeBean2 : IBeverage
        {
            private string description = "第二种咖啡豆";
            public string GetDescription()
            {
                return description;
            }

            public double GetPrice()
            {
                return 55;
            }
        }

        /// <summary>
        /// Decorator
        /// </summary>
        public class Decorator : IBeverage
        {
            protected  IBeverage _beverage;

            protected Decorator(IBeverage beverage)
            {
                this._beverage = beverage;
            }

            public  string GetDescription()
            {
               return  _beverage.GetDescription();
            }

            public  double GetPrice()
            {
               return _beverage.GetPrice();
            }
        }

        /// <summary>
        /// DecoratorConcrete
        /// </summary>
        public class Milk : Decorator
        {
            private string description = "加牛奶";

            public Milk(IBeverage beverage) : base(beverage)
            {
            }

            public new  string GetDescription()
            {
               return _beverage.GetDescription() + description;
            }

            public new double GetPrice()
            {
                return _beverage.GetPrice() + 8;
            }

        }

        /// <summary>
        /// DecoratorConcrete
        /// </summary>
        public class Mocha : Decorator
        {
            private string description = "加摩卡";
            public Mocha(IBeverage beverage) : base(beverage)
            {
            }
            public new string GetDescription()
            {
                return _beverage.GetDescription() + description;
            }

            public new double GetPrice()
            {
                return _beverage.GetPrice() + 8;
            }
        }
    }
}

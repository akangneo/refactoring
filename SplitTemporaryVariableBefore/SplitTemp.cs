using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    abstract class Fruit
    {
        public abstract float Weight { get; }
        public abstract float Price { get;}
    }

    class Apple : Fruit
    {
        public override float Weight => 10;
        public override float Price => 5;
    }

    class Pear : Fruit
    {
        public override float Weight => 10;
        public override float Price => 5;
    }

    class Plum : Fruit
    {
        public override float Weight => 3;
        public override float Price => 4;
    }
    public class SplitTemp
    {
        int GetAppleCount() => 10;
        int GetPearCount() => 20;
        int GetPlumCount() => 100;
        public float CalculatePurchasePrice()
        {
            var count = GetAppleCount();
            Fruit[] fruits = new Apple[count];
            var totalPrice = fruits.Sum(fruit => fruit.Price);

            count = GetPearCount();
            fruits = new Pear[count];
            totalPrice += fruits.Sum(fruit => fruit.Price);

            count = GetPlumCount();
            fruits = new Plum[count];
            totalPrice += fruits.Sum(fruit => fruit.Price);

            return totalPrice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class IntroduceVariable
    {
        public bool CheckCanSignContract(Person person)
        {
            if (person.Country.ToUpper().IndexOf("USA") > -1 &&
                person.State.ToUpper().IndexOf("TEXAS") > -1 &&
                person.Age > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetOrderAmount(Order order)
        {
            return order.Quantity * order.Price - Math.Max(0, order.Quantity - 100) *
                    order.Price * 0.06 + Math.Min(order.Quantity * order.Price * 0.1, 100);
        }

    }
}

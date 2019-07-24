using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class SimplyConditionBefore
    {
        public void Or(bool A)
        {
            // true
            var c1 = A || true;

            // A
            var c2 = A || false;

            // A
            var c3 = A || A;

            // true
            var c4 = A || !A;
        }

        public void And(bool A)
        {
            // A
            var c1 = A && true;

            // false
            var c2 = A && false;

            // A
            var c3 = A && A;

            // false
            var c4 = A && !A;
        }

        public void OrAnd(bool A, bool B, bool C)
        {
            // A
            var c1 = A || A && B;

            // A || B
            var c2 = A || !A && B;

            // A || B && C
            var c3 = (A || B) && (A || C);
        }

        public void DeMorgan(bool A, bool B)
        {
            // !A && !B
            var c1 = !(A || B);

            // !A || !B
            var c2 = !(A && B);

            // !(A || B)
            var c3 = !A && !B;

            // !(A && B)
            var c4 = !A || !B;
        }
    }
}

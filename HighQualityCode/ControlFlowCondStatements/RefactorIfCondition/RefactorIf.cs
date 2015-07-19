using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorIfCondition
{
    class RefactorIf
    {
        static void Main()
        {
            if (potato != null)
            {
                 bool potatoReadyForCook=!potato.HasNotBeenPeeled && !potato.IsRotten;
                 if(potatoReadyForCook)
                 {
                 Cook(potato);
                 }
            }
//////////////////////////////and

            bool isXInRange = ((MIN_X <= x) && (x <= MAX_X ));
            bool isYInRange = ((MIN_Y <= y && y <= MAX_Y));
            if ( isXInRange && isYInRange && !shouldNotVisitCell)))
            {
                 VisitCell();
            }
        }
    }
}

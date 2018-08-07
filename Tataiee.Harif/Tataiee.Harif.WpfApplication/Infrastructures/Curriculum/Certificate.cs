using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum.Constraints;
using Tataiee.Harif.Infrastructures.GeneralEnums;
using Tataiee.Harif.Infrastructures.Curriculum;

namespace Tataiee.Harif.Infrastructures.Data.Curriculum
{
    public class Certificate
    {
        public int Id { get; set; }
        public List<ICreditCard> CreditList { get; set; } = new List<ICreditCard>();
        public List<Constraint> ConstraintList { get; set; } = new List<Constraint>();

        public bool IsCreditable(ICreditCard card)
        {
            bool res = true;

            for (int i = 0; i < CreditList.Count; i++)
            {
                var c = CreditList[i];
                if (!c.IsAllowed(card))
                {
                    res = false;
                    break;
                }

            }

            return res;
        }



    }
}

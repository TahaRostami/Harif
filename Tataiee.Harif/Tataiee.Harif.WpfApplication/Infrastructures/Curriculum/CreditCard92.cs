using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.GeneralEnums;
using Tataiee.Harif.Infrastructures.Curriculum;
using Tataiee.Harif.Infrastructures.Curriculum;

namespace Tataiee.Harif.Infrastructures.Data.Curriculum
{
    //پشتیبانی کننده برنامه درسی های 92 
    public class CreditCard92 : ICreditCard
    {
        public int Id { get; set; }

        //نرم افزار و ...
        public List<int> CurriculumList { get; set; } = new List<int>();
        public CreditCardStatus CurriculumListType { get; set; }

        //الگوریتم و محاسبات و...
        public List<int> SpecializedFocus { get; set; } = new List<int>();
        public CreditCardStatus SpecializedFocusType { get; set; }

        private bool IsCredibaleCurriculum(int curriculum)
        {
            if (CurriculumListType == CreditCardStatus.ALLOWED_TO_ALL)
            {
                return true;
            }
            if (CurriculumListType == CreditCardStatus.NOT_ALLOWED_TO_ANY)
            {
                return false;
            }

            foreach (var c in CurriculumList)
            {
                if (c == curriculum)
                {
                    if (CurriculumListType == CreditCardStatus.ALLOWED_TO_ALL_IN_LIST)
                    {
                        return true;
                    }
                    else if (CurriculumListType == CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST)
                    {
                        return false;
                    }
                }
            }

            if (CurriculumListType == CreditCardStatus.ALLOWED_TO_ALL_IN_LIST)
            {
                return false;
            }
            else if (CurriculumListType == CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST)
            {
                return true;
            }

            throw new Exception();

        }

        private bool IsCredibaleSpecializedFocus(int specializedFocus)
        {
            if (SpecializedFocusType == CreditCardStatus.ALLOWED_TO_ALL)
            {
                return true;
            }
            if (SpecializedFocusType == CreditCardStatus.NOT_ALLOWED_TO_ANY)
            {
                return false;
            }

            foreach (var s in SpecializedFocus)
            {
                if (s == specializedFocus)
                {
                    if (SpecializedFocusType == CreditCardStatus.ALLOWED_TO_ALL_IN_LIST)
                    {
                        return true;
                    }
                    else if (SpecializedFocusType == CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST)
                    {
                        return false;
                    }
                }
            }

            if (SpecializedFocusType == CreditCardStatus.ALLOWED_TO_ALL_IN_LIST)
            {
                return false;
            }
            else if (SpecializedFocusType == CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST)
            {
                return true;
            }

            throw new Exception();
        }

        public bool IsAllowed(ICreditCard card)
        {
            CreditCard92 card1 = card as CreditCard92;
            if (card == null || card1.CurriculumList.Count != 1 || card1.SpecializedFocus.Count != 1)
            {               
                throw new ArgumentException();
            }
            if (IsCredibaleCurriculum(card1.CurriculumList[0]) && IsCredibaleSpecializedFocus(card1.SpecializedFocus[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum;
using Tataiee.Harif.Infrastructures.Curriculum;

namespace Tataiee.Harif.Infrastructures.Data.Curriculum
{
    public class Gate
    {
        public int Id { get; set; }
        public CourseCategory SrcCourseCategory { get; set; }
        public CourseCategory DesCourseCategory { get; set; }
        public List<Certificate> CertificateList { get; set; } = new List<Certificate>();

        public bool IsAllowedAllCredits(ICreditCard card)
        {
            bool res = true;
            for (int i = 0; i < CertificateList.Count; i++)
            {
                var cl = CertificateList[0];
                //var crdLst=cl.CreditList;     
                
                if(!cl.IsCreditable(card))
                {
                    res = false;
                    break;
                }
                //for (int j = 0; j < crdLst.Count; j++)
                //{
                //    if(!crdLst[j].IsAllowed(card))
                //    {
                //        res = false;
                //        break;
                //    }

                //}
                if (!res) break;

            }

            return res;
           
        }


    }
}

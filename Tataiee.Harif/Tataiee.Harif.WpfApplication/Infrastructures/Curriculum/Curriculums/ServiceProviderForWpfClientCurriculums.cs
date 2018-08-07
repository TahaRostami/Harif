using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.Infrastructures.Curriculum.Curriculums
{
    public class ServiceProviderForWpfClientCurriculums
    {
        public const string ListLevel1Name = "گرایش";
        public static Tuple<string, int>[] ListLevel1() => new Tuple<string, int>[]
        {
            new Tuple<string, int>("مهندسی کامپیوتر",101),
            new Tuple<string, int>("معماری سیستم های کامپیوتری",103),
            new Tuple<string, int>("نرم افزار",102),
            new Tuple<string, int>("رایانش امن",104),
            new Tuple<string, int>("فناوری اطلاعات",105),
        };

        public const string ListLevel2Name = "تمرکز تخصصی اختیاری";
        public static Tuple<string, int>[] ListLevel2() => new Tuple<string, int>[]
        {
            new Tuple<string, int>("نامشخص",121),
            new Tuple<string, int>("سیستم های مجتمع",122),
            new Tuple<string, int>("شبکه های کامپیوتری",123),
            new Tuple<string, int>("هوش مصنوعی",124),
            new Tuple<string, int>("سیستم های نرم افزاری",125),
            new Tuple<string, int>("الگوریتم و محاسبات",126),
            new Tuple<string, int>("بازی های کامپیوتری",127),
            new Tuple<string, int>("سیستم های اطلاعاتی",128),
            new Tuple<string, int>("امنیت رایانه",129),
        };

        public static Tuple<string, int>[] ValidateAndReturnListLevel2(int curriculum)
        {

            var arr = ListLevel2();
            if (101 == curriculum)
            {
                return arr;
            }
            else if (103 == curriculum)
            {
                return arr;
            }
            else if (102 == curriculum)
            {
                return arr;
            }
            else if (104 == curriculum)
            {
                return new Tuple<string, int>[] { arr[0] };
            }
            else if (105 == curriculum)
            {
                return new Tuple<string, int>[] { arr[0] };
            }

            throw new ArgumentException();
        }

        public static int DefaultLevel1Value = 101;

        public static int DefaultLevel2Value = 121;
    }
}

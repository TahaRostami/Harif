using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.UiMiddlewares
{
    public class CurriculumWpfClientMiddleware
    {

        public static int DefaultLevel1Value = ServiceProviderForWpfClientCurriculums.DefaultLevel1Value;
        public static string ListLevel1Name() => ServiceProviderForWpfClientCurriculums.ListLevel1Name;
        public static Tuple<string, int>[] ListLevel1() => ServiceProviderForWpfClientCurriculums.ListLevel1();

        public static int DefaultLevel2Value =ServiceProviderForWpfClientCurriculums.DefaultLevel2Value;
        public static string ListLevel2Name() => ServiceProviderForWpfClientCurriculums.ListLevel2Name;
        public static Tuple<string, int>[] ListLevel2() => ServiceProviderForWpfClientCurriculums.ListLevel2();

        public static Tuple<string, int>[] ValidateAndReturnListLevel2(int level1) => ServiceProviderForWpfClientCurriculums.ValidateAndReturnListLevel2(level1);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.Data.Curriculum.Constraints
{
    public abstract class Constraint /*: IConstraint*/
    {
        public int Id { get; set; }

        //is it exactly satisfied (bounderies)
        public abstract bool IsSatisfied(int x);//params object[] args

        //
        public abstract bool IsOk(int x);
    }

    public class MinNumberMaxNumberOfCoursesConstraint : Constraint
    {
        public int MinNumberOfCoursesMustBePass { get; set; }
        public int MaxNumberOfCoursesMustBePass { get; set; }

        public override bool IsOk(int x) =>  x <= MaxNumberOfCoursesMustBePass;//MinNumberOfCoursesMustBePass <= x &&


        public override bool IsSatisfied(int x)
        {
            throw new NotImplementedException();
        }
    }

    public class MinUnitsMaxUnitsOfCoursesConstraint : Constraint
    {
        public int MinUnitsOfCoursesMustBePass { get; set; }
        public int MaxUnitsOfCoursesMustBePass { get; set; }

        public override bool IsOk(int x) => x <= MaxUnitsOfCoursesMustBePass;//MinUnitsOfCoursesMustBePass <= x &&

        public override bool IsSatisfied(int x)
        {
            throw new NotImplementedException();
        }
    }


    public class NumberOfCoursesMustBeLabOrWorkshopConstraint : Constraint
    {
        public int NumberOfCoursesMustBeLabOrWorkshop { get; set; }

        public override bool IsOk(int x) => x <= NumberOfCoursesMustBeLabOrWorkshop;

        public override bool IsSatisfied(int x)
        {
            throw new NotImplementedException();
        }
    }
    public class UnitOfCoursesMustBeLabOrWorkshopConstraint : Constraint
    {
        public int UnitOfCoursesMustBeLabOrWorkshop { get; set; }

        public override bool IsOk(int x) => x <= UnitOfCoursesMustBeLabOrWorkshop;

        public override bool IsSatisfied(int x)
        {
            throw new NotImplementedException();
        }
    }
}

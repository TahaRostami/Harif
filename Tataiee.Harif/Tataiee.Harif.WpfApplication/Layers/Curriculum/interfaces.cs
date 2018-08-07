using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.Layers.Curriculum
{
    public enum CreditCardStatus
    {
        ALLOWED_TO_ALL,
        ALLOWED_TO_ALL_IN_LIST,
        ALLOWED_TO_ALL_EXCEPT_IN_LIST,
        NOT_ALLOWED_TO_ANY,
    }

    public interface ICreditCard
    {
        int Id { get; set; }
        bool IsAllowed(ICreditCard card);
    }

    public interface IConstraint
    {
        bool IsSatisfied(params object[] args);
    }
}

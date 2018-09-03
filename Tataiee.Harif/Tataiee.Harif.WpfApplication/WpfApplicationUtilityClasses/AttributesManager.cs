using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.Models
{
    public class ColumnNameAttribute : System.Attribute
    {
        public ColumnNameAttribute(string Name) { this.Name = Name; }
        public string Name { get; set; }
    }
}

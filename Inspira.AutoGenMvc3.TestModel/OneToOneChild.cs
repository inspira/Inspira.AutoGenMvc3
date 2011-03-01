using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspira.AutoGenMvc3.TestModel
{
    public class OneToOneChild
    {
        virtual public Int32 ID { get; set; }
        virtual public String Name { get; set; }
        virtual public OneToOneParent Parent { get; set; }
    }
}

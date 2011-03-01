using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspira.AutoGenMvc3.TestModel
{
    public class OneToOneParent
    {
        virtual public Int32 ID { get; set; }
        virtual public String Name { get; set; }
        virtual public OneToOneChild Child { get; set; }
    }
}

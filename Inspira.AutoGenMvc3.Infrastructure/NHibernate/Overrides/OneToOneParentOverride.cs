using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Automapping.Alterations;
using Inspira.AutoGenMvc3.TestModel;
using Inspira.AutoGenMvc3.Core.CustomTypes;

namespace Inspira.AutoGenMvc3.Core.NHibernate.Overrides
{
    public class OneToOneParentOverride : IAutoMappingOverride<OneToOneParent>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<OneToOneParent> mapping)
        {
            mapping.HasOne(m => m.Child);
        }
    }
}

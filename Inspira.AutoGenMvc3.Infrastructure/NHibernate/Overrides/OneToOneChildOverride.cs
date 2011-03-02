using FluentNHibernate.Automapping.Alterations;
using Inspira.AutoGenMvc3.TestModel;

namespace Inspira.AutoGenMvc3.Core.NHibernate.Overrides
{
    public class OneToOneChildOverride : IAutoMappingOverride<OneToOneChild>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<OneToOneChild> mapping)
        {
            mapping.References(p => p.Parent).Column("Parent_ID").Cascade.SaveUpdate();
        }
    }
}

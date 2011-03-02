using FluentNHibernate.Automapping.Alterations;
using Inspira.AutoGenMvc3.TestModel;
using Web.Generics.Core.CustomTypes;
using Web.Generics.Core.NHibernate;

namespace Inspira.AutoGenMvc3.Core.NHibernate.Overrides
{
    public class MyRealEntityOverride : IAutoMappingOverride<MyRealEntity>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<MyRealEntity> mapping)
        {
            mapping.Map(x => x.Cep).CustomType<TypeWithValue<Cep>>();
            mapping.Map(x => x.Cpf).CustomType<TypeWithValue<Cpf>>();
            mapping.Map(x => x.Cnpj).CustomType<TypeWithValue<Cnpj>>();
            mapping.Map(x => x.Email).CustomType<TypeWithValue<EmailAddress>>();
            mapping.Map(x => x.Telefone).CustomType<TypeWithValue<Telefone>>();
            mapping.Map(x => x.File1).CustomType<TypeWithValue<File>>();
            mapping.Map(x => x.File2).CustomType<TypeWithValue<File>>();
        }
    }
}

using System;
using System.Collections.Generic;
using Inspira.CodeGenerator.Core.CustomTypes;
using System.ComponentModel.DataAnnotations;

namespace Inspira.CodeGenerator.TestModel
{
    public class MyRealEntity
    {
        public MyRealEntity()
        {
            this.Cep = new Cep();
        }

        [DataType("Hidden")]
        virtual public Int32 ID { get; set; }
        virtual public Cep Cep { get; set; }
        virtual public Cpf Cpf { get; set; }
        virtual public Cnpj Cnpj { get; set; }
        virtual public Telefone Telefone { get; set; }
        virtual public SexoEnum Sexo { get; set; }
        virtual public EmailAddress Email { get; set; }
        virtual public File File1 { get; set; }
        virtual public File File2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeGeneratorTest
{
    [TestClass]
    public class embedded_resource
    {
        CodeGeneratorEntityMetadata entity;
        public embedded_resource()
        {
            var reader = new EmbeddedResourceReader("Inspira.CodeGenerator.TestModel");
            reader.ParseXml("CodeGenerator.xml");

            entity = reader.Entities["MyRealEntity"];
        }

/*        [TestMethod]
        public void clear_text()
        {
            //Assert.AreEqual(PropertyTemplate.ClearText, entity.Properties["MyClearText"].PropertyTemplate);
        }

        [TestMethod]
        public void html_text_with_maxlength()
        {
            //var property = entity.Properties["MyHtmlText"];
            //Assert.AreEqual(PropertyTemplate.HtmlText, property.PropertyTemplate);
            //Assert.AreEqual(4000, property.MaxLength);
        }*/

        [TestMethod]
        public void string_with_cep_template()
        {
            var property = entity.Properties["Cep"];
            Assert.AreEqual(PropertyTemplate.StringCep, property.PropertyTemplate);
            //Assert.AreEqual("00000-000".Length, property.MaxLength);
        }

        [TestMethod]
        public void string_with_cpf_template()
        {
            var property = entity.Properties["Cpf"];
            Assert.AreEqual(PropertyTemplate.StringCpf, property.PropertyTemplate);
            //Assert.AreEqual("000.000.000-00".Length, property.MaxLength);
        }

        [TestMethod]
        public void string_with_cnpj_template()
        {
            var property = entity.Properties["Cnpj"];
            Assert.AreEqual(PropertyTemplate.StringCnpj, property.PropertyTemplate);
            //Assert.AreEqual("012.345.678/0001-00".Length, property.MaxLength);
        }

        [TestMethod]
        public void string_with_telefone_template()
        {
            var property = entity.Properties["Telefone"];
            Assert.AreEqual(PropertyTemplate.StringTelefone, property.PropertyTemplate);
            //Assert.AreEqual("(11)2345-67890".Length, property.MaxLength);
        }
    }
}

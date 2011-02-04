using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace CodeGeneratorTest
{
    [TestClass]
    public class read_assembly_and_generate_artifacts
    {
        CodeGeneratorEntity myEntity;
        public read_assembly_and_generate_artifacts()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorMetadata metadata = codeGenerator.GenerateFromAssembly("Inspira.CodeGenerator.TestModel");
            myEntity = metadata.Entities["MyArtificialEntity"];
        }

        [TestMethod]
        public void Guid()
        {
            Assert.AreEqual(WidgetType.Hidden, myEntity.Properties["ID"].WidgetType);
        }

        [TestMethod]
        public void String()
        {
            Assert.AreEqual(WidgetType.TextBox, myEntity.Properties["MyString"].WidgetType);
            Assert.AreEqual(50, myEntity.Properties["MyString"].DatabaseColumn.Size);
        }

        [TestMethod]
        public void ClearText_No_MaxLength()
        {
            Assert.AreEqual(WidgetType.ClearText, myEntity.Properties["MyClearText"].WidgetType);
            Assert.AreEqual(50, myEntity.Properties["MyClearText"].DatabaseColumn.Size);
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeGeneratorTest;

namespace CodeGeneratorTest
{
    [TestClass]
    public class for_platform_modeltypes_without_metadata
    {
        [TestMethod]
        [Description("Yields <input type='text'>, nvarchar(MAX) with no validation or masks")]
        public void String_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<String>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.VarChar, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(ValidationType.None, generatedProperty.Validation.Type);
            Assert.AreEqual(50, generatedProperty.DatabaseColumn.Size);
            Assert.AreEqual(MaskType.None, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, nvarchar(MAX) with no validation or masks")]
        public void Char_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Char>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.Char, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(1, generatedProperty.DatabaseColumn.Size);
            Assert.AreEqual(MaskType.None, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, int, range validation and integer mask")]
        public void Int32_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Int32>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.Int, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(4, generatedProperty.DatabaseColumn.Size);
            Assert.AreEqual(ValidationType.Range, generatedProperty.Validation.Type);
            Assert.AreEqual(Int32.MinValue, generatedProperty.Validation.MinimumValue);
            Assert.AreEqual(Int32.MaxValue, generatedProperty.Validation.MaximumValue);
            Assert.AreEqual(MaskType.Integer, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, smallint, range validation and integer mask")]
        public void Int16_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Int16>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.SmallInt, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(2, generatedProperty.DatabaseColumn.Size);
            Assert.AreEqual(ValidationType.Range, generatedProperty.Validation.Type);
            Assert.AreEqual(Int16.MinValue, generatedProperty.Validation.MinimumValue);
            Assert.AreEqual(Int16.MaxValue, generatedProperty.Validation.MaximumValue);
            Assert.AreEqual(MaskType.Integer, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, smallint, range validation and integer mask")]
        public void Int64_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Int64>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.BigInt, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(8, generatedProperty.DatabaseColumn.Size);
            Assert.AreEqual(ValidationType.Range, generatedProperty.Validation.Type);
            Assert.AreEqual(Int64.MinValue, generatedProperty.Validation.MinimumValue);
            Assert.AreEqual(Int64.MaxValue, generatedProperty.Validation.MaximumValue);
            Assert.AreEqual(MaskType.Integer, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, smallint, range validation and integer mask")]
        public void Byte_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Byte>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.TinyInt, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(1, generatedProperty.DatabaseColumn.Size);
            Assert.AreEqual(ValidationType.Range, generatedProperty.Validation.Type);
            Assert.AreEqual(Byte.MinValue, generatedProperty.Validation.MinimumValue);
            Assert.AreEqual(Byte.MaxValue, generatedProperty.Validation.MaximumValue);
            Assert.AreEqual(MaskType.Integer, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, datetime, range validation and date/time mask")]
        public void DateTime_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<DateTime>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.DateTime, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(ValidationType.Range, generatedProperty.Validation.Type);
            Assert.AreEqual(DateTime.MinValue, generatedProperty.Validation.MinimumValue);
            Assert.AreEqual(DateTime.MaxValue, generatedProperty.Validation.MaximumValue);
            Assert.AreEqual(MaskType.DateTime, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='checkbox'>, bit, no validation, no mask")]
        public void Boolean_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Boolean>();
            Assert.AreEqual(WidgetType.CheckBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.Bit, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(ValidationType.None, generatedProperty.Validation.Type);
            Assert.AreEqual(MaskType.None, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, float, range validation, no mask")]
        public void Single_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Single>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.Float, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(ValidationType.Range, generatedProperty.Validation.Type);
            Assert.AreEqual(Single.MinValue, generatedProperty.Validation.MinimumValue);
            Assert.AreEqual(Single.MaxValue, generatedProperty.Validation.MaximumValue);
            Assert.AreEqual(MaskType.None, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, float, range validation, no mask")]
        public void Double_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Double>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.Float, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(ValidationType.Range, generatedProperty.Validation.Type);
            Assert.AreEqual(Double.MinValue, generatedProperty.Validation.MinimumValue);
            Assert.AreEqual(Double.MaxValue, generatedProperty.Validation.MaximumValue);
            Assert.AreEqual(MaskType.None, generatedProperty.Mask);
        }

        [TestMethod]
        [Description("Yields <input type='text'>, float, range validation, no mask")]
        public void Decimal_Default()
        {
            var codeGenerator = new CodeGenerator();
            CodeGeneratorProperty generatedProperty = codeGenerator.GenerateFromType<Decimal>();
            Assert.AreEqual(WidgetType.TextBox, generatedProperty.WidgetType);
            Assert.AreEqual(DatabaseColumnType.Money, generatedProperty.DatabaseColumn.Type);
            Assert.AreEqual(ValidationType.Range, generatedProperty.Validation.Type);
            Assert.AreEqual(Decimal.MinValue, generatedProperty.Validation.MinimumValue);
            Assert.AreEqual(Decimal.MaxValue, generatedProperty.Validation.MaximumValue);
            Assert.AreEqual(MaskType.Money, generatedProperty.Mask);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using CodeGeneratorTest;

namespace CodeGeneratorTest
{
    class CodeGenerator
    {
        internal CodeGeneratorMetadata GenerateFromAssembly(string assemblyName)
        {
            var metadataFromTypes = GetMetadataFromTypes(assemblyName);
            CompleteMetadataWithConfiguration(metadataFromTypes, assemblyName);
            return metadataFromTypes;
        }

        private void CompleteMetadataWithConfiguration(CodeGeneratorMetadata metadataFromTypes, String assemblyName)
        {
            var reader = new EmbeddedResourceReader(assemblyName);
            reader.ParseXml("CodeGenerator.xml");
            foreach (String entityName in reader.Entities.Keys)
            {
                var entityType = metadataFromTypes.Entities[entityName];
                var entityConfig = reader.Entities[entityName];
                foreach (var propertyName in entityConfig.Properties.Keys)
                {
                    var propertyType = entityType.Properties[propertyName];
                    if (entityConfig.Properties.ContainsKey(propertyName))
                    {
                        var propertyConfig = entityConfig.Properties[propertyName];
                        SetPropertyDetails(propertyType, propertyConfig);
                    }
                }
            }
        }

        private void SetPropertyDetails(CodeGeneratorProperty propertyType, CodeGeneratorPropertyMetadata propertyConfig)
        {
            if (propertyConfig.PropertyTemplate == PropertyTemplate.ClearText)
            {
                propertyType.WidgetType = WidgetType.ClearText;
            }
        }

        private CodeGeneratorMetadata GetMetadataFromTypes(string assemblyName)
        {
            var assembly = Assembly.Load(assemblyName);
            var metadata = new CodeGeneratorMetadata();

            foreach (var type in assembly.GetTypes())
            {
                var entity = new CodeGeneratorEntity();
                entity.Name = type.Name;
                metadata.Entities.Add(entity.Name, entity);
                foreach (var propertyInfo in type.GetProperties())
                {
                    var property = this.GenerateFromType(propertyInfo.PropertyType);
                    property.Name = propertyInfo.Name;
                    entity.Properties.Add(property.Name, property);
                }
            }
            return metadata;
        }

        internal CodeGeneratorProperty GenerateFromType<T>()
        {
            var type = typeof(T);
            return this.GenerateFromType(type);
        }

        private CodeGeneratorProperty GenerateFromType(Type type)
        {
            var field = new CodeGeneratorProperty();
            field.DatabaseColumn = new DatabaseColumn();
            field.Validation = new Validation();

            if (type == typeof(Guid))
            {
                field.WidgetType = WidgetType.Hidden;
            }
            if (type == typeof(String))
            {
                field.WidgetType = WidgetType.TextBox;
                field.DatabaseColumn.Size = 50;
                field.DatabaseColumn.Type = DatabaseColumnType.VarChar;
                field.Validation.Type = ValidationType.None;
            }
            else if (type == typeof(Char))
            {
                field.WidgetType = WidgetType.TextBox;
                field.Validation.Type = ValidationType.None;
                field.DatabaseColumn.Type = DatabaseColumnType.Char;
                field.DatabaseColumn.Size = 1;
            }
            else if (type == typeof(Int32))
            {
                field.DatabaseColumn.Size = 4;
                field.DatabaseColumn.Type = DatabaseColumnType.Int;
                field.Validation.Type = ValidationType.Range;
                field.Validation.MinimumValue = Int32.MinValue;
                field.Validation.MaximumValue = Int32.MaxValue;
                field.Mask = MaskType.Integer;
            }
            else if (type == typeof(Int64))
            {
                field.DatabaseColumn.Size = 8;
                field.DatabaseColumn.Type = DatabaseColumnType.BigInt;
                field.Validation.Type = ValidationType.Range;
                field.Validation.MinimumValue = Int64.MinValue;
                field.Validation.MaximumValue = Int64.MaxValue;
                field.Mask = MaskType.Integer;
            }
            else if (type == typeof(Byte))
            {
                field.DatabaseColumn.Size = 1;
                field.DatabaseColumn.Type = DatabaseColumnType.TinyInt;
                field.Validation.Type = ValidationType.Range;
                field.Validation.MinimumValue = Byte.MinValue;
                field.Validation.MaximumValue = Byte.MaxValue;
                field.Mask = MaskType.Integer;
            }
            else if (type == typeof(Int16))
            {
                field.Validation.Type = ValidationType.Range;
                field.DatabaseColumn.Size = 2;
                field.DatabaseColumn.Type = DatabaseColumnType.SmallInt;
                field.Validation.MinimumValue = Int16.MinValue;
                field.Validation.MaximumValue = Int16.MaxValue;
                field.Mask = MaskType.Integer;
            }
            else if (type == typeof(DateTime))
            {
                field.Validation.Type = ValidationType.Range;
                field.DatabaseColumn.Type = DatabaseColumnType.DateTime;
                field.Validation.MinimumValue = DateTime.MinValue;
                field.Validation.MaximumValue = DateTime.MaxValue;
                field.Mask = MaskType.DateTime;
            }
            else if (type == typeof(Boolean))
            {
                field.Validation.Type = ValidationType.None;
                field.WidgetType = WidgetType.CheckBox;
                field.DatabaseColumn.Type = DatabaseColumnType.Bit;
            }
            else if (type == typeof(Single))
            {
                field.Validation.Type = ValidationType.Range;
                field.DatabaseColumn.Type = DatabaseColumnType.Float;
                field.DatabaseColumn.Size = 8;
                field.Validation.MinimumValue = Single.MinValue;
                field.Validation.MaximumValue = Single.MaxValue;
            }
            else if (type == typeof(Double))
            {
                field.Validation.Type = ValidationType.Range;
                field.DatabaseColumn.Type = DatabaseColumnType.Float;
                field.DatabaseColumn.Size = 16;
                field.Validation.MinimumValue = Double.MinValue;
                field.Validation.MaximumValue = Double.MaxValue;
            }
            else if (type == typeof(Decimal))
            {
                field.Validation.Type = ValidationType.Range;
                field.DatabaseColumn.Type = DatabaseColumnType.Money;
                field.Validation.MinimumValue = Decimal.MinValue;
                field.Validation.MaximumValue = Decimal.MaxValue;
                field.Mask = MaskType.Money;
            }
            return field;

        }
    }
}

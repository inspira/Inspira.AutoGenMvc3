using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeGeneratorTest;
using System.Reflection;
using System.Xml.Linq;

namespace CodeGeneratorTest
{
    class EmbeddedResourceReader
    {
        String _assemblyName;
        public EmbeddedResourceReader(String assemblyName)
        {
            this._assemblyName = assemblyName;
            this.Entities = new Dictionary<String, CodeGeneratorEntityMetadata>();
        }

        private Assembly _assembly;
        internal Assembly Assembly
        {
            get
            {
                if (this._assembly == null)
                {
                    this._assembly = Assembly.Load(this._assemblyName);
                }
                return this._assembly;
            }
        }

        internal void ParseXml(String xmlName)
        {
            var stream = this.Assembly.GetManifestResourceStream(this._assemblyName + "." + xmlName);
            var xdocument = XDocument.Load(stream);
            var xmlEntities = xdocument.Document.Descendants("entity");
            var entities = xmlEntities.Select(e =>
                new CodeGeneratorEntityMetadata
                {
                    Name = e.Attribute("Name") != null ? e.Attribute("Name").Value : "SemNome",
                    Properties = e.Descendants("property").Select(
                            p => new
                            {
                                Key = p.Attribute("Name").Value,
                                Value = new CodeGeneratorPropertyMetadata
                                {
                                    Name = p.Attribute("Name").Value,
                                    PropertyTemplate = p.Attribute("PropertyTemplate") == null ? PropertyTemplate.None : (PropertyTemplate)Enum.Parse(typeof(PropertyTemplate), p.Attribute("PropertyTemplate").Value),
                                    MaxLength = p.Attribute("MaxLength") == null ? 0 : Int32.Parse(p.Attribute("MaxLength").Value),
                                }
                            }
                        ).ToDictionary(x => x.Key, x => x.Value)
                }
            ).ToList();

            foreach (var entity in entities)
            {
                this.Entities.Add(entity.Name, entity);
                /*
                 * foreach (var propertyName in entity.Properties.Keys)
                {
                    var property = entity.Properties[propertyName];
                    if (property.PropertyTemplate == PropertyTemplate.StringCep)
                    {
                        if (property.MaxLength == 0) property.MaxLength = "00000-000".Length;
                    }
                    if (property.PropertyTemplate == PropertyTemplate.StringCpf)
                    {
                        if (property.MaxLength == 0) property.MaxLength = "111.222.333-44".Length;
                    }
                    if (property.PropertyTemplate == PropertyTemplate.StringCnpj)
                    {
                        if (property.MaxLength == 0) property.MaxLength = "012.345.678/0001-00".Length;
                    }
                    if (property.PropertyTemplate == PropertyTemplate.StringTelefone)
                    {
                        if (property.MaxLength == 0) property.MaxLength = "(11)2345-67890".Length;
                    }
                }
                 */
            }
        }

        internal Dictionary<String, CodeGeneratorEntityMetadata> Entities { get; set; }
    }
}

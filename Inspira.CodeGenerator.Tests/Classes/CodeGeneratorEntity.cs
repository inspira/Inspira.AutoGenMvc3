using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeGeneratorTest;

namespace CodeGeneratorTest
{
    class CodeGeneratorEntity
    {
        public CodeGeneratorEntity() {
            this.Properties = new Dictionary<String, CodeGeneratorProperty>();
        }

        public Dictionary<String, CodeGeneratorProperty> Properties { get; set; }
        public String Name { get; set; }
    }
}

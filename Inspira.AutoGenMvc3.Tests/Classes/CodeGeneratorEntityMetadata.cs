using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneratorTest
{
    internal class CodeGeneratorEntityMetadata
    {
        internal CodeGeneratorEntityMetadata()
        {
            this.Properties = new Dictionary<string,CodeGeneratorPropertyMetadata>();
        }
        internal String Name { get; set; }
        internal Dictionary<String, CodeGeneratorPropertyMetadata> Properties { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneratorTest
{
    class CodeGeneratorMetadata
    {
        public CodeGeneratorMetadata()
        {
            this.Entities = new Dictionary<String, CodeGeneratorEntity>();
        }
        public Dictionary<String, CodeGeneratorEntity> Entities { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneratorTest
{
    internal class CodeGeneratorPropertyMetadata
    {
        internal String Name { get; set; }
        internal PropertyTemplate PropertyTemplate { get; set; }
        public Int32 MaxLength { get; set; }
    }
}

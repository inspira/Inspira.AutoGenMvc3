using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneratorTest
{
    class CodeGeneratorProperty
    {
        public WidgetType WidgetType { get; set; }
        public string Name { get; set; }
        public DatabaseColumn DatabaseColumn { get; set; }
        public Validation Validation { get; set; }
        public MaskType Mask { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspira.CodeGenerator.Core.CustomTypes
{
    public class Telefone : CustomType
    {
        public override bool IsValid()
        {
            return base.ValidateByRegex(@"\(\d\d\)\d{4}-\d{4,5}");
        }
    }
}

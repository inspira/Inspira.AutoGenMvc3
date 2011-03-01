using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Inspira.AutoGenMvc3.Core.CustomTypes
{
    public class Cep : CustomType
    {
        public override bool IsValid() {
            return base.ValidateByRegex(@"\d{5}-\d{3}");
        }
    }
}

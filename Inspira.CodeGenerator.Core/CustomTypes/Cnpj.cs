﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspira.CodeGenerator.Core.CustomTypes
{
    public class Cnpj : CustomType
    {
        public override bool IsValid()
        {
            return base.ValidateByRegex(@"\d{2,3}\.\d{3}\.\d{3}/\d{4}-\d{2}");
        }
    }
}

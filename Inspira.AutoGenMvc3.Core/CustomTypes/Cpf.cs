﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inspira.AutoGenMvc3.Core.CustomTypes
{
    public class Cpf : CustomType
    {
        public override bool IsValid()
        {
            return base.ValidateByRegex(@"\d{3}\.\d{3}\.\d{3}-\d{2}");
        }
    }
}

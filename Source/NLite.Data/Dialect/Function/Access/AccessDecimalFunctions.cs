﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLite.Data.Dialect.Function.Access
{
    class AccessDecimalFunctions : IDecimalFunctions
    {
        public IFunctionView Remainder
        {
            get { return FunctionView.VarArgs("(", "MOD", ")"); }
        }
    }
}

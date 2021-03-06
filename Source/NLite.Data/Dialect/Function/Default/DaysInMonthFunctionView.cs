﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using NLite.Data.Dialect.SqlBuilder;

namespace NLite.Data.Dialect.Function.Default
{
    class DaysInMonthFunctionView : IFunctionView
    {
        public void Render(ISqlBuilder builder, params Expression[] args)
        {
            var year = args[0];
            var month = args[1];

            builder.Append("(CASE");
            builder.Append(" WHEN ");
            builder.Visit(year);
            builder.Append("% 4 = 0 AND(");
            builder.Visit(year);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Linq.Expressions;
using NLite.Data.Dialect;

namespace NLite.Data.Mapping
{
    /// <summary>
    /// 实体Mapping元数据接口
    /// </summary>
    public interface IEntityMapping
    {
        /// <summary>
        /// Schema
        /// </summary>
        string Schema { get; }
        /// <summary>
        /// 表名
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// 实体类型
        /// </summary>
        Type EntityType { get; }
        /// <summary>
        /// 实体成员映射元数据集合
        /// </summary>
        IMemberMapping[] Members { get; }
        /// <summary>
        /// 主键映射元数据
        /// </summary>
        IMemberMapping[] PrimaryKeys { get; }
        /// <summary>
        /// 版本映射元数据
        /// </summary>
        IMemberMapping Version { get; }
        /// <summary>
        /// 获取成员映射元数据
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        IMemberMapping Get(MemberInfo member);
    }
}

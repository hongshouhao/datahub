using Geone.DataService.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geone.DataService.Core.Exceptions
{
    public class MetaAlreadyexistException : Exception
    {
        public MetaAlreadyexistException(MetaType metaType, string name)
            : base($"已存在元数据: 类型={metaType}, 标识={name}")
        {

        }
    }
}

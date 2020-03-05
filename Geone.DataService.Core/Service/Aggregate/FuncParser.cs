using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Geone.DataService.Core.Service.Aggregate
{
    public class FuncParser
    {
        public FuncParser(string jsonSchema)
        {
            var mes = Regex.Matches(jsonSchema, @"^\$(?<service>[a-zA-Z0-9_]+)\((?<arg>[a-zA-Z0-9_, ]+)\)(?<path>\.[a-zA-Z0-9_\.]+)");
            foreach (Match mitem in mes)
            {

            }
        }

        public ValRef[] ValRefs { get; private set; }
    }

    public class ValRef
    {
        public string FuncName { get; set; }
        public string[] Parameters { get; set; }
        public string ValuePath { get; set; }
    }
}

using Newtonsoft.Json.Linq;
using System;

namespace Geone.DataService.Core.Service.REST
{
    public class RestMeta : IServiceContent
    {
        public string CURL { get; set; }

        public void CheckValid()
        {
            if (string.IsNullOrWhiteSpace(CURL))
            {
                throw new ArgumentException("参数错误: CURL不能为空");
            }
        }
    }
}

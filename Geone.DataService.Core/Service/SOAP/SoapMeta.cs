using System;

namespace Geone.DataService.Core.Service.SOAP
{
    public class SoapMeta : IServiceContent
    {
        public SoapMeta()
        {
        }

        public string Uri { get; set; }

        public void CheckValid()
        {
            if (string.IsNullOrWhiteSpace(Uri))
            {
                throw new ArgumentException("参数错误: 服务地址不能为空");
            }
        }
    }
}

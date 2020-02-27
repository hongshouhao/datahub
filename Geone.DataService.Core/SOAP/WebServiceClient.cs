using Google.Protobuf.WellKnownTypes;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;

namespace Geone.DataService.Core.SOAP
{
    
    public class WebServiceClient
    {
        private static Dictionary<EMethod, MethodInfo> m_MethodDic = new Dictionary<EMethod, MethodInfo>();

        public static bool CreateWebService(string webServiceUrl, out string error)
        {
            error = string.Empty;

            Call(webServiceUrl);
            //Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cli", "Geone.DataService.SoapDllBuilder.exe"), webServiceUrl);

            return true;
        }

        /// <summary>
        /// 反射构建Methods
        /// </summary>
        //private static void BuildMethods()
        //{
        //    Assembly asm = Assembly.LoadFrom(m_OutputDllFilename);
        //    //var types = asm.GetTypes();
        //    System.Type asmType = asm.GetType(m_ProxyClassName);
        //    m_ObjInvoke = Activator.CreateInstance(asmType);

        //    //var methods = asmType.GetMethods();
        //    var methods = System.Enum.GetNames(typeof(Method)).ToList();
        //    foreach (var item in methods)
        //    {
        //        var methodInfo = asmType.GetMethod(item);
        //        if (methodInfo != null)
        //        {
        //            var method = (Method)System.Enum.Parse(typeof(Method), item);
        //            m_MethodDic.Add(method, methodInfo);
        //        }
        //    }
        //}

        ///// <summary>
        ///// 获取请求响应
        ///// </summary>
        ///// <param name="method">方法</param>
        ///// <param name="para">参数</param>
        ///// <returns>返回：Json串</returns>
        //public static string GetResponseString(Method method, params object[] para)
        //{
        //    string result = null;
        //    if (m_MethodDic.ContainsKey(method))
        //    {
        //        var temp = m_MethodDic[method].Invoke(m_ObjInvoke, para);
        //        if (temp != null)
        //        {
        //            result = temp.ToString();
        //        }
        //    }
        //    return result;
        //}

        public static void Call(string webServiceUrl)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CLI", "Geone.DataService.SoapDllBuilder.exe");
            startInfo.Arguments = webServiceUrl;

            Process.Start(startInfo);
        }
    }
}

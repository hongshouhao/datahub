using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string aa = "$rest(param1)";
            string servicePattren = @"(?<=\$)(.*)(?=\()";
            string serviceName = Regex.Match(aa, servicePattren).Value;

            string paramPattern = @"(?<=\()(.*)(?=\))";
            string param = Regex.Match(aa, paramPattern).Value;


            string groupPattern = @"(?<serviceName>(?<=\$)(.*)(?=\()))|(?<param>(?<=\()(.*)(?=\))";
            Match match = Regex.Match(aa, groupPattern);
            string s = match.Groups["serviceName"].ToString();
            string p = match.Groups["param1"].ToString();
        }

        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            Console.WriteLine("Error in Schema - ");
            Console.WriteLine(args.Message);
        }
    }
}

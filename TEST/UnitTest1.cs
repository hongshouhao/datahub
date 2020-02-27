using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStack;

namespace TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IOneWayClient oneWay = ClientFactory.Create("http://sys89.gxzjt.gov.cn:8080/RegisterUser/BuildMarket/WebService/BuildMarketWebService.asmx?wsdl");
         

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebServiceAddition
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceAddition : System.Web.Services.WebService
    {

        //[WebMethod]
        //public double Addition(decimal num1, decimal num2)
        //{
        //    decimal result = num1 + num2;
        //    return Convert.ToDouble(result);
        //}

        [WebMethod]
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        [WebMethod]
        public double Difference(double num1, double num2)
        {
            return num1 - num2;
        }

        [WebMethod]
        public double Product(double num1, double num2)
        {
            return num1 * num2;
        }

        [WebMethod]
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        [WebMethod]
        public double Square (double num1)
        {
            return num1 * num1;
        }

        [WebMethod]
        public double Cube(double num1)
        {
            return num1 * num1 * num1;
        }
    }
}

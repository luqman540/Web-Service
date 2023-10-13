using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService
{
    public partial class addition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string num1Str = Request.QueryString["num1"];
                string num2Str = Request.QueryString["num2"];
                if ((num1Str != "" && num1Str != null) || (num2Str != "" && num2Str != null))
                {
                    double num1, num2;
                    if (double.TryParse(num1Str, out num1) && double.TryParse(num2Str, out num2))
                    {
                        double result = num1 + num2;
                        //Response.ContentType = "text/plain";
                        Response.Write(result);
                    }
                    else
                    {
                        Response.StatusCode = 400;
                        Response.Write("Invalid input. Please provide valid num1 and num2 parameters in the query string.");
                    }
                    Response.End();
                }
            }
            
        }
    }
}
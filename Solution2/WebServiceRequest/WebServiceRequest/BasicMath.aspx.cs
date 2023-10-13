using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceRequest
{
    public partial class BasicMath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            string btnTxt = hiddenTxt.Value;
            double num1 = Convert.ToDouble(firstNumberTxt.Text);
            double num2 = 0;
            if (secondNumberTxt.Text != "")
            {
                num2 = Convert.ToDouble(secondNumberTxt.Text);
            }
            AdditionService.WebServiceAdditionSoapClient calculate = new
                AdditionService.WebServiceAdditionSoapClient();
            if (btnTxt == "Add")
            {
                answerTxt.Text = calculate.Addition(num1, num2).ToString();
            }
            else if (btnTxt == "Subtract")
            {
                answerTxt.Text = calculate.Difference(num1, num2).ToString();
            }
            else if (btnTxt == "Multiply")
            {
                answerTxt.Text = calculate.Product(num1, num2).ToString();
            }
            else if (btnTxt == "Divide")
            {
                answerTxt.Text = calculate.Division(num1, num2).ToString();
            }
            else if (btnTxt == "Square")
            {
                answerTxt.Text = calculate.Square(num1).ToString();
            }
            else if (btnTxt == "Cube")
            {
                answerTxt.Text = calculate.Cube(num1).ToString();
            }
        }
    }
}
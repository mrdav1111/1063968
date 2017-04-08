using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hola
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int suma(int a, int b)
        {
            return a +b;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hi stranger");
        }
    }
}
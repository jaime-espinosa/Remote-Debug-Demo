using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Remote_Debug_Demo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        static int i = 0;
        protected void Button1_Click(object sender, EventArgs e)
        {
            string val = i.ToString();
            i++;
            Button1.Text = val;
        }

    }
}
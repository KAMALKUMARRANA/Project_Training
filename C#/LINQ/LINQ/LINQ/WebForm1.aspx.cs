using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Student> Result = Student.GetAllStudent().Where(x => x.Gender == "Male");
            GridView1.DataSource = Result;
            GridView1.DataBind();
        }
    }
}
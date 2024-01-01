using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Using Lambda Expression
            IEnumerable<Student> Result1 = Student.GetAllStudent().Where(x => x.Gender == "Male");

            GridView1.DataSource = Result1;
            GridView1.DataBind();

            // Using SQL like Expression
            IEnumerable<Student> Result2 = from student in Student.GetAllStudent()
                                           where student.Gender == "FeMale"
                                           select student;
            GridView2.DataSource = Result2;
            GridView2.DataBind();

        }

    }
}
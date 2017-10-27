using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERP
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            string stName = StudentName.Value;
            Response.Write(stName);
            string stCNIC = CNIC.Value;
            string stMobile = MobileNo.Value;
            string stAge = Age.Value;
            string st10thMarks = TenthMarks.Value;
            string stFSCMarks = FSCMarks.Value;
            string stNTSMarks = NTSMarks.Value;
            string stProgram = Program.Value;
            StudentBLL.AddStudent(stName, stCNIC, stMobile, stAge, st10thMarks, stFSCMarks, stNTSMarks, stProgram);

        }
    }
}
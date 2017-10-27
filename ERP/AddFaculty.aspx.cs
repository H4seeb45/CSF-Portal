using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERP
{
    public partial class AddFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            string fcName = FacultyMemberName.Value;
            Response.Write(fcName);
            string fcCNIC = CNIC.Value;
            string fcMobile = MobileNo.Value;
            string fcAge = Age.Value;
            string fcQualification = Qualification.Value;
            string fcDesignation = Designation.Value;
            string fcResponsibility = Responsibility.Value;
            string fcStatus = Status.Value;
            string fcDepartment = Department.Value;
            FacultyBLL.AddFaculty(fcName, fcCNIC, fcMobile, fcAge, fcQualification, fcDesignation, fcResponsibility, fcStatus, fcDepartment);

        }
    }
}
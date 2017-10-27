using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERP
{
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            string sName = MemberName.Value;
            Response.Write(sName);
            string sCNIC = CNIC.Value;
            string sMobile = MobileNo.Value;
            string sAge = Age.Value;
            string sDesignation = Designation.Value;
            string sAddress = Address.Value;
            string sType = StaffType.Value;
            StaffBLL.AddStaff(sName, sCNIC, sMobile, sAge, sDesignation, sAddress, sType);

        }
    }
}
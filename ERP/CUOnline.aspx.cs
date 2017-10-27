using System;
using System.Data;

namespace ERP
{
    public partial class CUOnline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userroll = Session["UserName"].ToString();
            string season = userroll.Substring(0,userroll.IndexOf('-') ).Trim();
            DataTable dt = new DataTable();
            try
            {
                dt = DAL.ExecuteQuery("select DBID from ", "[Records].dbo.[StudentDBID]", " where [Registration No] = '" +userroll+"'");
                string dbid = dt.Rows[0]["DBID"].ToString();
                dbid = dbid.Substring(0,7).Trim();
                dt = DAL.ExecuteQuery("select name from "+season+".sys.tables where name like '"+dbid + "-%'",null,null);
                string tablename = dt.Rows[0]["name"].ToString();

                dt = DAL.ExecuteQuery("select [Course Code] from ["+season+"].dbo.["+tablename+"]", "", "");
                string[] courses =  { "n", "n", "n", "n", "n", "n" };
                int count = 0;
                while (count < dt.Rows.Count)
                {
                    courses[count] = dt.Rows[count]["Course Code"].ToString();
                    count++;
                }
                dt = DAL.ExecuteQuery("select [Course Name] from [Records].dbo.[CourseCodes] where [CC] IN ('"+courses[0]+"','"+ courses[1]+"','"+courses[2] +"','"+courses[3]+"','" + courses[4] + "','" + courses[5] + "')",null,null);
                count = 0;
                while (count < dt.Rows.Count)
                {
                    courses[count] = dt.Rows[count]["Course Name"].ToString();
                    count++;
                }
                
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
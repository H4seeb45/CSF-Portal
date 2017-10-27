using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP
{
    class StaffBLL
    {
        public static void AddStaff(string Name, string CNIC, string MobileNo, string Age, string Designation, string Address, string Type)
        {
            DAL.addCount("[Records].[dbo].[StaffCounter]", "Staff");
            DAL.addCount("[Records].[dbo].[StaffDBCounter]", "ID");
            int roll = DAL.Count("[Records].[dbo].[StaffCounter]", "Staff");
            string RollNo = null;
            string season = null;
            season = "ST-";
            RollNo = season + roll;
            DAL.addStaff(RollNo,Name, CNIC, MobileNo, Age, Designation, Address, Type);
            string dbid = null;
            int id = DAL.Count("[Records].[dbo].[StaffDBCounter]", "ID");
            dbid = "STF-DB" + id;
            DAL.createDBID("StaffDBID", RollNo, dbid);
            

        }
    }

}
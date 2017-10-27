using System;

namespace ERP
{
    class FacultyBLL
    {
        public static void AddFaculty(string FacultyMemberName, string CNIC, string MobileNo, string Age, string Qualification, string Designation, string Responsibility, string Status, string Department)
        {
            DAL.addCount("[Records].[dbo].[FacultyCounter]", "Faculty");
            DAL.addCount("[Records].[dbo].[FacultyDBCounter]", "ID");
            int roll = DAL.Count("[Records].[dbo].[FacultyCounter]", "Faculty");
            string RollNo = null;
            string season = null;
                season = "FC-";
            RollNo = season + roll;
            DAL.addFaculty(RollNo, FacultyMemberName, CNIC, MobileNo, Age, Qualification, Designation, Responsibility, Status, Department);
            string dbid = null;
            int id = DAL.Count("[Records].[dbo].[FacultyDBCounter]", "ID");
            dbid = "FC-DB" + id;
            DAL.createDBID("FacultyDBID", RollNo, dbid);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ERP
{
    class StudentBLL
    {
        public static void AddStudent(string Name, string CNIC, string MobileNo, string Age, string TenthMarks, string FSCMarks, string NTSMarks, string Program)
        {

            DAL.addCount("[Records].[dbo].[StudentCounter]", "Student");
            DAL.addCount("[Records].[dbo].[StudentDBCounter]", "ID");

            int roll = DAL.Count("[Records].[dbo].[StudentCounter]", "Student");

            string RollNo = null;
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            int mnth = Convert.ToInt16(month);
            int yr = Convert.ToInt16(year);
            string season;

            if (mnth <= 6)
                season = "SP";
            else
                season = "FA";

            string dbname = season + yr % 100;

            if (Program == "BSSE")
            {
                RollNo = season + yr % 100 + " -BSE- " + roll + "-B2A/SWL";
            }
            DAL.addStudent(RollNo, Name, CNIC, MobileNo, Age, TenthMarks, FSCMarks, NTSMarks);

            string dbid = null;
            int id = DAL.Count("[Records].[dbo].[StudentDBCounter]", "ID");
            dbid = "ST-DB" + id;
            DAL.createDBID("StudentDBID", RollNo, dbid);
            DAL.CreateDB(dbname);
            string tablename = dbid + "-SM1";
            DAL.createTable(tablename, dbname);
            DAL.createStCredentials(RollNo);
            DAL.addSubjects(dbname,tablename);
             
            
        } 

        }
    }


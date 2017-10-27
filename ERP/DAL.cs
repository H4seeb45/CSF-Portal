using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text;
using System.Security.Cryptography;
namespace ERP
{
    class DAL
    {

        public static void createStCredentials(string rollno)
        {
            SqlCommand command1 = new SqlCommand("INSERT INTO [Records].[dbo].[Student Credentials] ([Username], [Password]) values ( @username, @pass )", GetConnection());

            try
            {

                command1.Connection = GetConnection();
                command1.Connection.Open();
                command1.Parameters.AddWithValue("@username", rollno);
                string password = Encrypt("pass");
                command1.Parameters.AddWithValue("@pass", password);

                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

                command1.Connection.Close();
            }


        }
        public static void addSubjects(string season,string tablename)
        {

            DataTable dt = ExecuteQuery("select CC from ["+season+"].dbo.[SE-1] ","","");
            try
            {
               int rows = dt.Rows.Count;
                    string[] cc = new string[8];
                    int count = 0;
                    while(count< rows)
                    {
                    SqlCommand command2 = new SqlCommand("insert into [" + season + "].dbo.[" + tablename + "] ([Course Code]) values (@code)", GetConnection());
                    command2.Connection.Open();
                    cc[count] = dt.Rows[count]["CC"].ToString();
                        command2.Parameters.AddWithValue("@code", cc[count]);
                    
                    command2.ExecuteNonQuery();
                        count++;
                    command2.Connection.Close();
                }

                }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {          
            }
        }
        public static void createTable(string tablename, string dbname)
        {
            SqlCommand command1 = new SqlCommand("CREATE TABLE [FA17].dbo.["+tablename+"]([Course Code] varchar(8),Attendence char(1),Q1 int,Q2 int,Q3 int,Q4 int,A1 int, A2 int,A3 int,A4 int, S1 int,S2 int, Final int,PRIMARY KEY([Course Code])); ", GetConnection());

            try
            {

                command1.Connection = GetConnection();
                command1.Connection.Open();
                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

                command1.Connection.Close();
            }
        }
            public static void addStudent(string RegistrationNo, string Name, string CNIC, string MobileNo, string Age, string TenthMarks, string FSCMarks, string NTSMarks)
            {
                SqlCommand command1 = new SqlCommand("INSERT INTO [Records].[dbo].[StudentsRecord] ([Registration No], [Name] ,[CNIC] ,[Mobile No],[Age],[10th Marks],[FSC Marks],[NTS Marks],[Program]) VALUES(@regno, @name, @cnic, @mobileno, @age, @tenthmarks, @fscmarks, @ntsmarks, @prog )", GetConnection());

                try
                {

                    command1.Connection = GetConnection();
                    command1.Connection.Open();
                    command1.Parameters.AddWithValue("@regno", RegistrationNo);
                    command1.Parameters.AddWithValue("@name", Name);
                    command1.Parameters.AddWithValue("@cnic", CNIC);
                    command1.Parameters.AddWithValue("@mobileno", MobileNo);
                    command1.Parameters.AddWithValue("@age", Age);
                    command1.Parameters.AddWithValue("@tenthmarks", TenthMarks);
                    command1.Parameters.AddWithValue("@fscmarks", FSCMarks);
                    command1.Parameters.AddWithValue("@ntsmarks", NTSMarks);
                    command1.Parameters.AddWithValue("@prog", "BSSE");


                    command1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                finally
                {

                    command1.Connection.Close();
                }


            }


        public static void createDBID(string Tablename, string RegistrationNo, string DBID)
        {
            SqlCommand command1 = new SqlCommand("INSERT INTO [Records].[dbo].["+Tablename+"] ([Registration No], [DBID]) values ( @regno, @dbid )", GetConnection());

            try
            {

                command1.Connection = GetConnection();
                command1.Connection.Open();
                command1.Parameters.AddWithValue("@regno", RegistrationNo);
                command1.Parameters.AddWithValue("@dbid",  DBID);



                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

                command1.Connection.Close();
            }


        }



        

        public static int Count(string tablename, string columnname)
        {

            int a;
            SqlCommand cmd = new SqlCommand("select count" + "(" + columnname + ")" + " from " + tablename, GetConnection());
            try
            {
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                a = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return a;
            
        }


        
        internal static void addStaff(string roll, string name, string CNIC, string mobileno, string age, string designation, string address, string type)
        {
            SqlCommand command1 = new SqlCommand("INSERT INTO [Records].[dbo].[StaffRecord] ([Registration No], [Member Name] ,[CNIC] ,[Mobile No],[Age],[Designation],[Address],[Type]) VALUES(@regno, @name, @cnic, @mobileno, @age, @designation, @address, @type )", GetConnection());

            try
            {

                command1.Connection = GetConnection();
                command1.Connection.Open();
                command1.Parameters.AddWithValue("@regno", roll);
                command1.Parameters.AddWithValue("@name", name);
                command1.Parameters.AddWithValue("@cnic", CNIC);
                command1.Parameters.AddWithValue("@mobileno", mobileno);
                command1.Parameters.AddWithValue("@age", age);
                command1.Parameters.AddWithValue("@designation", designation);
                command1.Parameters.AddWithValue("@address", address);
                command1.Parameters.AddWithValue("@type", type);



                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

                command1.Connection.Close();
            }
        }
        public static void addFaculty(string RegistrationNo, string Name, string CNIC, string MobileNo, string Age, string Qualification, string Designation, string Responsibility, string Status, string Department)
        {
            SqlCommand command1 = new SqlCommand("INSERT INTO [Records].[dbo].[FacultyRecord] ([Registration No],[FacultyMemberName] ,[CNIC] ,[Mobile No],[Age],[Qualification],[Designation],[Responsibility],[Status],[Department]) VALUES(@regno, @name, @cnic, @mobileno, @age, @qualification, @designation, @responsibility, @status, @department )", GetConnection());

            try
            {

                command1.Connection = GetConnection();
                command1.Connection.Open();
                command1.Parameters.AddWithValue("@regno", RegistrationNo);
                command1.Parameters.AddWithValue("@name", Name);
                command1.Parameters.AddWithValue("@cnic", CNIC);
                command1.Parameters.AddWithValue("@mobileno", MobileNo);
                command1.Parameters.AddWithValue("@age", Age);
                command1.Parameters.AddWithValue("@qualification", Qualification);
                command1.Parameters.AddWithValue("@designation", Designation);
                command1.Parameters.AddWithValue("@responsibility", Responsibility);
                command1.Parameters.AddWithValue("@status", Status);
                command1.Parameters.AddWithValue("@department", Department);


                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

                command1.Connection.Close();
            }

        }

        public static void addCount(String tablename, string columnname)
            
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO" + tablename + "(" + columnname + ") values(1)", GetConnection());
            try
            {
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public static void CreateDB(string dbname)
        {

            String str;
            SqlConnection myConn = GetConnection();

            str = "CREATE DATABASE " + dbname + " ON PRIMARY " +
                "(NAME = " +dbname+ ", " +
                "FILENAME = 'E:\\" + dbname + ".mdf', " +
                "SIZE = 3MB, MAXSIZE = 50MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = " + dbname + "_Log, " +
                "FILENAME = 'E:\\" + dbname + ".ldf', " +
                "SIZE = 1MB, " +
                "MAXSIZE = 5MB, " +
                "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Equals("Database 'FA17' already exists. Choose a different database name.")){

                }
                else
                throw ex;
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }



        public static string Decrypt(string cipherText)
            {
                string EncryptionKey = "MAKV2SPBNI99212";
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return cipherText;
            }



            public static string Encrypt(string clearText)
            {
                string EncryptionKey = "MAKV2SPBNI99212";
                byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        clearText = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return clearText;
            }





            public static DataTable ExecuteQuery(string query, string tablename, string where)
            {
                string connection = System.Configuration.ConfigurationManager.
                          ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlConnection1 = new SqlConnection(connection);
                try
                {

                    DataTable dt = new DataTable();
                    string statement = query + tablename + where;

                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;

                    cmd.CommandText = statement;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();

                    reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
                  
                }
                finally
                {
                    sqlConnection1.Close();

                }
            }



       




        public static SqlConnection GetConnection()
            {


                string connection = System.Configuration.ConfigurationManager.
                        ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlConnection1 = new SqlConnection(connection);
                return sqlConnection1;
            }

        public static SqlConnection GetConnection(string db)
        {


            string connection = System.Configuration.ConfigurationManager.
                    ConnectionStrings["ConnectionString"].ConnectionString;
            
            SqlConnection sqlConnection1 = new SqlConnection(connection);
            sqlConnection1.ChangeDatabase(db);
            return sqlConnection1;
        }


        public static string GetConnectionString()
            {


                string connection = System.Configuration.ConfigurationManager.
                        ConnectionStrings["ConnectionString"].ConnectionString;
                // SqlConnection sqlConnection1 = new SqlConnection(connection);
                return connection;
            }




            public static DataTable SelectRecord1(string query)
            {
                string connection = System.Configuration.ConfigurationManager.
                ConnectionStrings["ConnectionString"].ConnectionString;
                DataTable dt = new DataTable();
                SqlConnection sqlConnection1 = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }












        }
    }
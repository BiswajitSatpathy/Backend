//using System;
//using System.Data.SqlClient;
//using System.Collections.Generic;

//namespace WebApplication1
//{
//    public static class Repo
//    {
//        public static List<Registration> GetAllDetails()
//        {
//            List<Registration> employees = null;
//            try
//            {
//                using (SqlConnection con = new SqlConnection(@"Server=.\SQLExpress;Database=UserLogin; Trusted_Connection=Yes;User Id=."))
//                {
//                    using (SqlCommand cmd = new SqlCommand("select * from Employee", con))
//                    {
//                        con.Open();
//                        using (var a = cmd.ExecuteReader())
//                        {
//                            employees = new List<Registration>();
//                            while (a.Read())
//                            {
//                                Registration emp = new Registration();
//                                emp.UserName = a.GetString(0);
//                                emp.Password = a.GetString(1);

//                                employees.Add(emp);
//                            }
//                        }
//                    }
//                }
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//            //finally
//            //{
//            //    //if(con.State == System.Data.ConnectionState.Open)
//            //    //{
//            //    //    con.Close;
//            //    //}
//            //}

//            return employees;
//        }
//    }
//}

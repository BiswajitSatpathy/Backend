using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        [HttpGet]

        public JsonResult Get()
        {
            string query = @"select UserName, Password, FirstName, LastName, Role from Registration";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("UserLoginAppcon");
            SqlDataReader myReader;
            using(SqlConnection myCon=new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }


        [HttpPost]
        public IActionResult Post(Registration reg)
        {
            string query1 = "insert into Registration values(@UserName, @Password, @FirstName, @LastName, @Role)";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("UserLoginAppcon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query1, myCon))
                {
                    myCommand.Parameters.AddWithValue("@UserName", reg.UserName);
                    myCommand.Parameters.AddWithValue("@Password", reg.Password);
                    myCommand.Parameters.AddWithValue("@FirstName", reg.FirstName);
                    myCommand.Parameters.AddWithValue("@LastName", reg.LastName);
                    myCommand.Parameters.AddWithValue("@Role", reg.Role);


                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return Ok("Added Successfully");
        }




        [HttpPut]
        public IActionResult Put(Registration reg)
        {
            //string query = @"
            //        update dbo.Department set
            //        UserName = '" + reg.UserName + @"'
            //        where Password = " + reg.Password + @" 
            //        ";

            string query = "update Registration set FirstName=@fn where UserName = @un";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("UserLoginAppcon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@un", reg.UserName);
                    //myCommand.Parameters.AddWithValue("@un", reg.UserName);
                    myCommand.Parameters.AddWithValue("@fn", reg.FirstName);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return Ok("Updated Successfully");
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public IActionResult Delete(Registration reg)
        {

            string query = "update from Registration where UserName = @UserName";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("UserLoginAppcon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@UserName", reg.UserName);
                   

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return Ok("delete Successfully");
        }
    }
}


//UserName varchar(50) UNIQUE NOT NULL,
//Password varchar(50) NOT NULL,
//FirstName varchar(50) NOT NULL,
//LastName varchar(50) NOT NULL,
//Role VARCHAR(50)
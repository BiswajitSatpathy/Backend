using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Registration
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}

//UserName varchar(50) UNIQUE NOT NULL,
//Password varchar(50) NOT NULL,
//FirstName varchar(50) NOT NULL,
//LastName varchar(50) NOT NULL,
//Role VARCHAR(50)
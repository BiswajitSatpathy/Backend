using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Constants
{
    public class Query
    {
        public static string loginQuery = "select * from dbo.Registration where Password = @Password and Email=@Email";    
    }
}


//[Password]
//      ,[FirstName]
//      ,[LastName]
//      ,[Role]

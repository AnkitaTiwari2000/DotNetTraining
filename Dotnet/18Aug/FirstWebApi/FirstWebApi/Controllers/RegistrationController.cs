using FirstWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : Controller
    {
        private readonly IConfiguration _configuration;
        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
            
        }
        [HttpPost]
        [Route("registration")]
       public string registration(Registration registration) {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("ActionDb").ToString());
            SqlCommand cmd=new SqlCommand("insert into Registration(UserNAme,Password,Email,IsActive) Values ('"+registration.UserName+","+registration.UserName+","+registration.UserName+","+registration.UserName+"')",con);
            int i = cmd.ExecuteNonQuery();
            if(i > 0)
            {
                return "Data Inserted";
            }
            else
            {
                return "Error";
            }


            return "";
        }
    }
}

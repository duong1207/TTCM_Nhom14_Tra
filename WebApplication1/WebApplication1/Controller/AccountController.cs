using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class AccountController : ApiController
    {

        [HttpGet]
        public List<Admin> GetAccountLists()
        {
            DataClasses1DataContext dbCustomer = new DataClasses1DataContext();
            return dbCustomer.Admins.ToList();
        }
        [HttpPost]
        [Route("api/Account/Login")]
        public IHttpActionResult Login([FromBody] LoginDTO login)
        {
            using (var db = new DataClasses1DataContext())
            {
                var Username = login.Username;
                var Password = login.Password;

                // Tìm kiếm thông tin tài khoản trong cơ sở dữ liệu
                var user = db.Admins.FirstOrDefault(x => x.Username == Username && x.Password == Password);

                if (user == null)
                {
                    return BadRequest("Sai tên tài khoản hoặc mật khẩu");
                }

                // Tạo và trả về một token hoặc một đối tượng JSON chứa thông tin tài khoản
                var token = "abcxyz";
                var result = new
                {
                    Username = user.Username,
                    Password = user.Password,
                    Token = token
                };

                return Ok(result);
            }
        }
    }
}

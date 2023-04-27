using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class AccountkhController : ApiController
    {
        public string Username_khach { get; private set; }
        public string Password_khach { get; private set; }

        [HttpGet]
        public List<Khachhang> GetAccountLists1()
        {
            DataClasses1DataContext dbCustomer = new DataClasses1DataContext();
            return dbCustomer.Khachhangs.ToList();
        }
        [HttpPost]
        [Route("api/Accountkh/Login")]
        public IHttpActionResult Login([FromBody] LoginKH login)
        {
            using (var db = new DataClasses1DataContext())
            {
                var Username = login.Username_khach;
                var Password = login.Password_khach;

                // Tìm kiếm thông tin tài khoản trong cơ sở dữ liệu
                var user = db.Khachhangs.FirstOrDefault(x => x.Username_khach == Username && x.Password_khach == Password);

                if (user == null)
                {
                    return BadRequest("Sai tên tài khoản hoặc mật khẩu");
                }

                // Tạo và trả về một token hoặc một đối tượng JSON chứa thông tin tài khoản
                var token = "abcxyz";
                var result = new
                {
                    Username = user.Username_khach,
                    Password = user.Password_khach,
                    Token = token
                };

                return Ok(result);
            }
        }
        [HttpPost]
        [Route("api/Accountkh/Register")]
        public IHttpActionResult Register([FromBody] Khachhang account1)
        {
            try
            {
                if (account1 == null || string.IsNullOrEmpty(account1.TenKH) 
                    || string.IsNullOrEmpty(account1.Diachi) || string.IsNullOrEmpty(account1.SDT) 
                    || string.IsNullOrEmpty(account1.Username_khach) || string.IsNullOrEmpty(account1.Password_khach)
                    || string.IsNullOrEmpty(account1.Password_khach))
                {
                    return BadRequest("Vui lòng nhập đầy đủ thông tin tài khoản");
                }
                using (var db = new DataClasses1DataContext())
                {
                    var TaiKhoan = account1.Username_khach;
                    // Kiểm tra xem tài khoản đã tồn tại hay chưa
                    var existingAccount = db.Khachhangs.FirstOrDefault(a => a.Username_khach == TaiKhoan);
                    if (existingAccount != null)
                    {
                        return BadRequest("Tài khoản đã tồn tại");
                    }
                    // Kiểm tra xem mật khẩu đã trùng khớp hay chưa
                    if (account1.Password_khach != account1.Password_khach)
                    {
                        return BadRequest("Mật khẩu không trùng khớp");
                    }

                    var newAccount = new Khachhang
                    {
                        Username_khach = account1.Username_khach,
                        Password_khach = account1.Password_khach
                    };
                    // Thêm tài khoản mới vào cơ sở dữ liệu
                    db.Khachhangs.InsertOnSubmit(newAccount);
                    db.SubmitChanges();

                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

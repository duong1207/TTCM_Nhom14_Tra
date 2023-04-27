using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class KhachhangController : ApiController
    {
        [HttpGet]
        public List<Khachhang> GetBooksLists()
        {
            DataClasses1DataContext dbBooks = new DataClasses1DataContext();
            return dbBooks.Khachhangs.ToList();
        }

        [HttpPost]
        public bool InsertNewBook(string id, string name, string diachi,
        string sdt, string userkhach, string passkhach)


        {
            try
            {
                DataClasses1DataContext dbBooks = new DataClasses1DataContext();
                Khachhang book = new Khachhang
                {

                    MaKH = id,
                    TenKH = name,
                    Diachi = diachi,
                    SDT = sdt,
                    Username_khach = userkhach,
                    Password_khach = passkhach
                };
                dbBooks.Khachhangs.InsertOnSubmit(book);
                dbBooks.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteBook(string id)
        {
            try
            {
                DataClasses1DataContext dbCustomer = new DataClasses1DataContext();
                //Lấy mã khách đã có
                Khachhang customer =
               dbCustomer.Khachhangs.FirstOrDefault(x => x.MaKH == id);
                if (customer == null) return false;

                dbCustomer.Khachhangs.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateBook(string id, string name, string diachi,
        string sdt, string userkhach, string passkhach)
        {
            try
            {
                DataClasses1DataContext DataClasses1 = new DataClasses1DataContext();
                //Lấy mã khách đã có
                Khachhang customer =
              DataClasses1.Khachhangs.FirstOrDefault(x => x.MaKH == id);
                if (customer == null) return false;
                customer.MaKH = id;
                customer.TenKH = name;
                customer.Diachi = diachi;
                customer.SDT = sdt;
                customer.Username_khach = userkhach;
                customer.Password_khach = passkhach;
                DataClasses1.SubmitChanges();//Xác nhận chỉnh sua

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Khachhang/SearchKhachhangByName/{name}")]
        public List<Khachhang> SearchKhachhangByName(string name)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Khachhangs.Where(x => x.TenKH.Contains(name)).ToList();
        }
        [HttpGet]
        [Route("api/Khachhang/SearchKhachhangById/{id}")]
        public List<Khachhang> SearchKhachhangById(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Khachhangs.Where(x => x.MaKH.Contains(id)).ToList();
        }
    }
}

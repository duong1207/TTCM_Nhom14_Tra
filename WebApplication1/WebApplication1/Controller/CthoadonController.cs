using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class CthoadonController : ApiController
    {
        [HttpGet]
        public List<Chitiethdb> GetBooksLists()
        {
            DataClasses1DataContext dbBooks = new DataClasses1DataContext();
            return dbBooks.Chitiethdbs.ToList();
        }

        [HttpPost]
        public bool InsertNewBook(string id, string masp, int soluong,
        float giamua)


        {
            try
            {
                DataClasses1DataContext dbBooks = new DataClasses1DataContext();
                Chitiethdb book = new Chitiethdb
                {

                    SoHDB = id,
                    MaSP = masp,
                    SL = soluong,
                    Giamua = giamua
                };
                dbBooks.Chitiethdbs.InsertOnSubmit(book);
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
                Chitiethdb customer =
               dbCustomer.Chitiethdbs.FirstOrDefault(x => x.SoHDB == id);
                if (customer == null) return false;

                dbCustomer.Chitiethdbs.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateBook(string id, string masp, int soluong,
        float giamua)
        {
            try
            {
                DataClasses1DataContext DataClasses1 = new DataClasses1DataContext();
                //Lấy mã khách đã có
                Chitiethdb customer =
              DataClasses1.Chitiethdbs.FirstOrDefault(x => x.SoHDB == id);
                if (customer == null) return false;
                customer.SoHDB = id;
                customer.MaSP = masp;
                customer.SL = soluong;
                customer.Giamua = giamua;
                DataClasses1.SubmitChanges();//Xác nhận chỉnh sua

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Cthoadon/SearchCthoadonById/{id}")]
        public List<Chitiethdb> SearchCthoadonById(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Chitiethdbs.Where(x => x.SoHDB.Contains(id)).ToList();
        }
    }
}

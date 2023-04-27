using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class HoadonController : ApiController
    {
        [HttpGet]
        public List<Hoadonban> GetBooksLists()
        {
            DataClasses1DataContext dbBooks = new DataClasses1DataContext();
            return dbBooks.Hoadonbans.ToList();
        }

        [HttpPost]
        public bool InsertNewBook(string id, string makh, string ngayban,
        float tongtien)


        {
            try
            {
                DataClasses1DataContext dbBooks = new DataClasses1DataContext();
                Hoadonban book = new Hoadonban
                {

                    SoHDB = id,
                    MaKH = makh,
                    Ngayban = ngayban,
                    Tongtien = tongtien
                };
                dbBooks.Hoadonbans.InsertOnSubmit(book);
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
                Hoadonban customer =
               dbCustomer.Hoadonbans.FirstOrDefault(x => x.SoHDB == id);
                if (customer == null) return false;

                dbCustomer.Hoadonbans.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateBook(string id, string makh, string ngayban,
        float tongtien)
        {
            try
            {
                DataClasses1DataContext DataClasses1 = new DataClasses1DataContext();
                //Lấy mã khách đã có
                Hoadonban customer =
              DataClasses1.Hoadonbans.FirstOrDefault(x => x.SoHDB == id);
                if (customer == null) return false;
                customer.SoHDB = id;
                customer.MaKH = makh;
                customer.Ngayban = ngayban;
                customer.Tongtien = tongtien;
                DataClasses1.SubmitChanges();//Xác nhận chỉnh sua

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Hoadon/SearchHoadonById/{id}")]
        public List<Hoadonban> SearchHoadonById(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Hoadonbans.Where(x => x.SoHDB.Contains(id)).ToList();
        }
    }
}

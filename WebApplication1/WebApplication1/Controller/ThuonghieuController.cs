using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class ThuonghieuController : ApiController
    {
        [HttpGet]
        public List<Thuonghieu> GetBooksLists()
        {
            DataClasses1DataContext dbBooks = new DataClasses1DataContext();
            return dbBooks.Thuonghieus.ToList();
        }

        [HttpPost]
        public bool InsertNewBook(string id, string name)


        {
            try
            {
                DataClasses1DataContext dbBooks = new DataClasses1DataContext();
                Thuonghieu book = new Thuonghieu
                {

                    Math = id,
                    Tenth = name
                };
                dbBooks.Thuonghieus.InsertOnSubmit(book);
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
                Thuonghieu customer =
               dbCustomer.Thuonghieus.FirstOrDefault(x => x.Math == id);
                if (customer == null) return false;

                dbCustomer.Thuonghieus.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateBook(string id, string name)
        {
            try
            {
                DataClasses1DataContext DataClasses1 = new DataClasses1DataContext();
                //Lấy mã khách đã có
                Thuonghieu customer =
              DataClasses1.Thuonghieus.FirstOrDefault(x => x.Math == id);
                if (customer == null) return false;
                customer.Math = id;
                customer.Tenth = name;
                DataClasses1.SubmitChanges();//Xác nhận chỉnh sua

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Thuonghieu/SearchThuonghieuByName/{name}")]
        public List<Thuonghieu> SearchThuonghieuByName(string name)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Thuonghieus.Where(x => x.Tenth.Contains(name)).ToList();
        }
        [HttpGet]
        [Route("api/Thuonghieu/SearchThuonghieuById/{id}")]
        public List<Thuonghieu> SearchThuonghieuById(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Thuonghieus.Where(x => x.Math.Contains(id)).ToList();
        }
    }
}

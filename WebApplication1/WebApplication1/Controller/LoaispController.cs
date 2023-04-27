using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class LoaispController : ApiController
    {
        [HttpGet]
        public List<Loaisp> GetBooksLists()
        {
            DataClasses1DataContext dbBooks = new DataClasses1DataContext();
            return dbBooks.Loaisps.ToList();
        }

        [HttpPost]
        public bool InsertNewBook(string id, string name)


        {
            try
            {
                DataClasses1DataContext dbBooks = new DataClasses1DataContext();
                Loaisp book = new Loaisp
                {

                    Maloaisp = id,
                    Tenloaisp = name
                };
                dbBooks.Loaisps.InsertOnSubmit(book);
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
                Loaisp customer =
               dbCustomer.Loaisps.FirstOrDefault(x => x.Maloaisp == id);
                if (customer == null) return false;

                dbCustomer.Loaisps.DeleteOnSubmit(customer);
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
                Loaisp customer =
              DataClasses1.Loaisps.FirstOrDefault(x => x.Maloaisp == id);
                if (customer == null) return false;
                customer.Maloaisp = id;
                customer.Tenloaisp = name;
                DataClasses1.SubmitChanges();//Xác nhận chỉnh sua

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Loaisp/SearchLoaispByName/{name}")]
        public List<Loaisp> SearchLoaispByName(string name)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Loaisps.Where(x => x.Tenloaisp.Contains(name)).ToList();
        }
        [HttpGet]
        [Route("api/Loaisp/SearchLoaispById/{id}")]
        public List<Loaisp> SearchLoaispById(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Loaisps.Where(x => x.Maloaisp.Contains(id)).ToList();
        }
    }
}

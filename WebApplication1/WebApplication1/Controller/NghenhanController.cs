using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class NghenhanController : ApiController
    {
        [HttpGet]
        public List<Nghenhan> GetBooksLists()
        {
            DataClasses1DataContext dbBooks = new DataClasses1DataContext();
            return dbBooks.Nghenhans.ToList();
        }

        [HttpPost]
        public bool InsertNewBook(string id, string name, string anhnn,
        string thongtin, string username)


        {
            try
            {
                DataClasses1DataContext dbBooks = new DataClasses1DataContext();
                Nghenhan book = new Nghenhan
                {

                    MaNN = id,
                    Tennghenhan = name,
                    AnhNN = anhnn,
                    Thongtin = thongtin,
                    Username = username
                };
                dbBooks.Nghenhans.InsertOnSubmit(book);
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
                Nghenhan customer =
               dbCustomer.Nghenhans.FirstOrDefault(x => x.MaNN == id);
                if (customer == null) return false;

                dbCustomer.Nghenhans.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateBook(string id, string name, string anhnn,
        string thongtin, string username)
        {
            try
            {
                DataClasses1DataContext DataClasses1 = new DataClasses1DataContext();
                //Lấy mã khách đã có
                Nghenhan customer =
              DataClasses1.Nghenhans.FirstOrDefault(x => x.MaNN == id);
                if (customer == null) return false;
                customer.MaNN = id;
                customer.Tennghenhan = name;
                customer.AnhNN = anhnn;
                customer.Thongtin = thongtin;
                customer.Username = username;
                DataClasses1.SubmitChanges();//Xác nhận chỉnh sua

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Nghenhan/SearchNghenhanByName/{name}")]
        public List<Nghenhan> SearchNghenhanByName(string name)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Nghenhans.Where(x => x.Tennghenhan.Contains(name)).ToList();
        }
        [HttpGet]
        [Route("api/Nghenhan/SearchNghenhanById/{id}")]
        public List<Nghenhan> SearchNghenhanById(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Nghenhans.Where(x => x.MaNN.Contains(id)).ToList();
        }
    }
}

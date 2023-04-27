using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class TintucController : ApiController
    {
        [HttpGet]
        public List<Tintuc> GetBooksLists()
        {
            DataClasses1DataContext dbBooks = new DataClasses1DataContext();
            return dbBooks.Tintucs.ToList();
        }

        [HttpPost]
        public bool InsertNewBook(string id, string name, string gioithieu,
        string ngaytao, string username, string anhtt)


        {
            try
            {
                DataClasses1DataContext dbBooks = new DataClasses1DataContext();
                Tintuc book = new Tintuc
                {

                    MaTT = id,
                    Tieude = name,
                    Gioithieu = gioithieu,
                    Ngaytaott = ngaytao,
                    Username = username,
                    AnhTT = anhtt
                };
                dbBooks.Tintucs.InsertOnSubmit(book);
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
                Tintuc customer =
               dbCustomer.Tintucs.FirstOrDefault(x => x.MaTT == id);
                if (customer == null) return false;

                dbCustomer.Tintucs.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateBook(string id, string name, string gioithieu,
        string ngaytao, string username, string anhtt)
        {
            try
            {
                DataClasses1DataContext DataClasses1 = new DataClasses1DataContext();
                //Lấy mã khách đã có
                Tintuc customer =
              DataClasses1.Tintucs.FirstOrDefault(x => x.MaTT == id);
                if (customer == null) return false;
                customer.MaTT = id;
                customer.Tieude = name;
                customer.Gioithieu = gioithieu;
                customer.Ngaytaott = ngaytao;
                customer.Username = username;
                customer.AnhTT = anhtt;
                DataClasses1.SubmitChanges();//Xác nhận chỉnh sua

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Tintuc/SearchTintucByName/{name}")]
        public List<Tintuc> SearchTintucByName(string name)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Tintucs.Where(x => x.Tieude.Contains(name)).ToList();
        }
        [HttpGet]
        [Route("api/Tintuc/SearchTintucById/{id}")]
        public List<Tintuc> SearchTintucById(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Tintucs.Where(x => x.MaTT.Contains(id)).ToList();
        }
        [HttpGet]
        [Route("api/Tintuc/chitiettt/{id}")]
        public List<Tintuc> chitietsp(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Tintucs.Where(x => x.MaTT == id).ToList();
        }
    }
}

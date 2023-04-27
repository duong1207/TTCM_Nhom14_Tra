using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    public class SanphamController : ApiController
    {
        [HttpGet]
        public List<Sanpham> GetBooksLists()
        {
            DataClasses1DataContext dbBooks = new DataClasses1DataContext();
            return dbBooks.Sanphams.ToList();
        }

        [HttpGet]
        public Sanpham GetTraById(string id)
        {
            DataClasses1DataContext DBhoaquaDataContext = new
            DataClasses1DataContext();
            return DBhoaquaDataContext.Sanphams.FirstOrDefault(x =>
           x.MaSP == id);
        }

        [HttpPost]
        public bool InsertNewBook(string id, string name,
        string malsp, string math, int giaban, string mota,
        string trongluong, string cachpha, string ngaytao, string user, string anh)


        {
            try
            {
                DataClasses1DataContext dbBooks = new DataClasses1DataContext();
                Sanpham book = new Sanpham
                {

                    MaSP = id,
                    TenSP = name,
                    Maloaisp = malsp,
                    Math = math,
                    Giaban = giaban,
                    Mota = mota,
                    Trongluong = trongluong,
                    Cachpha = cachpha,
                    Ngaytao = ngaytao,
                    Username = user,
                    AnhSP = anh
                };
                dbBooks.Sanphams.InsertOnSubmit(book);
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
                Sanpham customer =
               dbCustomer.Sanphams.FirstOrDefault(x => x.MaSP == id);
                if (customer == null) return false;

                dbCustomer.Sanphams.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateBook(string anh, string id, string name,
        string malsp, string math, int giaban, string mota,
        string trongluong, string cachpha, string ngaytao, string user)
        {
            try
            {
                DataClasses1DataContext DataClasses1 = new DataClasses1DataContext();
                //Lấy mã khách đã có
                Sanpham customer =
              DataClasses1.Sanphams.FirstOrDefault(x => x.MaSP == id);
                if (customer == null) return false;

                customer.MaSP = id;
                customer.TenSP = name;
                customer.Maloaisp = malsp;
                customer.Math = math;
                customer.Giaban = giaban;
                customer.Mota = mota;
                customer.Trongluong = trongluong;
                customer.Cachpha = cachpha;
                customer.Ngaytao = ngaytao;
                customer.Username = user;
                customer.AnhSP = anh;
                DataClasses1.SubmitChanges();//Xác nhận chỉnh sua

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Sanpham/SearchSanphamByName/{name}")]
        public List<Sanpham> SearchSanphamByName(string name)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Sanphams.Where(x => x.TenSP.Contains(name)).ToList();
        }
        [HttpGet]
        [Route("api/Sanpham/SearchSanphamById/{id}")]
        public List<Sanpham> SearchSanphamById(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Sanphams.Where(x => x.MaSP.Contains(id)).ToList();
        }
        [HttpGet]
        [Route("api/Sanpham/chitietsp/{id}")]
        public List<Sanpham> chitietsp(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.Sanphams.Where(x => x.MaSP==id).ToList();
        }
    }
}

using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    //Base Entity abstract class'i, tum entitylere ayni anda ulasip topluca crud islemi yapabilmek icin acildi.
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        //Burada tum class'lar icin ortak olan CRUD islemleri yer aliyor. Farklilik gosteren methodlar Concrete icerisinde yer almakta.

        ProjectContext db = new ProjectContext();
        public string Create(T model)
        {
            string result = "";
            try
            {
                db.Set(typeof(T)).Add(model); //class'lardaki T'nin tipine bak. Eger ilgili tablo varsa ona set et ve girilen model tipini ilgili tabloya ekle.
                db.SaveChanges();
                result = $"Veri kaydedildi.";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var deleted = db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(deleted);
                db.SaveChanges();
                return "Silme islemi basarili.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }
        public T FindById(int id) //Guncelleme islemi yapabilmek icin oncelikle id'yi bulmak icin bir method hazirlamamiz gerekiyor.
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }
        public string Update(T model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Guncelleme basarili.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

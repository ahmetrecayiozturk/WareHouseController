using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseController3
{
    // Generics ile CRUD işlemleri için arayüz
    // Burada istersek where T : class demeyiz böylece her türden veri ile çalışabiliriz
    internal interface ICrud<T> where T : class
    {
        void Add(T entity);
        void AddNew(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
    }

    // Generics ile temel CRUD işlemleri gerçekleştiren sınıf
    // Burada istersek where T : class demeyiz böylece her türden veri ile çalışabiliriz
    internal class CrudGenerics<T> : ICrud<T> where T : class
    {
        [Obsolete("Bu metodun kullanımı tavsiye edilmiyor. AddNew metodunu kullanınız.")]
        public void Add(T entity)
        {
            using (var context = new WareHouseControlContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }
        public void AddNew(T entity)
        {
            using (var context = new WareHouseControlContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }
        public void Update(T entity)
        {
            using (var context = new WareHouseControlContext())
            {
                var entityInDb = context.Entry(entity);
                entityInDb.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new WareHouseControlContext())
            {
                var entityInDb = context.Entry(entity);
                entityInDb.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new WareHouseControlContext())
            {
                return context.Set<T>().ToList();
            }
        }
    }
    //Biz burada aynı zamanda hazır attribute'ler kullanabiliriz. örneğin obsolete 
}

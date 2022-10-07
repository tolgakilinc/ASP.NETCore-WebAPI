using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constrait  <T> aralığını kısıtlamak için kullanılır
    //class: -> referans tipi
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        //List<Product> GetAll();
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);

        //List<Product> GetAllByCategory(int categoryId);
        //linq ile yukarıdakileri yazmaya gerek kalmaz tek tek category product yazmıyasun ara değer oluşturuyosun hepsini burdan çekmeni sağlıyor.

        List<T> GetAll(Expression<Func<T, bool>> fiter = null);
        T Get(Expression<Func<T, bool>> fiter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}

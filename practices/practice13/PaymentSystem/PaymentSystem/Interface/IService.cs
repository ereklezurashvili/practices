using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Interface
{
    public interface IService<T>
    {
         void Add(T item);
         List<T> GetAll();
        T GetById(Guid Id);
        void Update(Guid Id, T item);
        void Delete(Guid Id);

    }
}

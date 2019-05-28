using System.Collections.Generic;

namespace DataLayer.Repositories
{
    public interface IRepository<T>
    {
        void Add(T element);
        void Remove(T element);
        void RemoveAt(int index);
        IList<T> GetAll();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        int Insert(T p);
        int Update(T p);
        int Delete(T p);
        List<T> List();
        T GetById(int id);
    }
}

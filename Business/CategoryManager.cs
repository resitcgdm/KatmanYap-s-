using DataAccess;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoryManager
    {
        Repository<Category> categoryRepo = new Repository<Category>();

        public  List<Category>GetAll()
        {
            return categoryRepo.List();
        }
        public int BusAdd(Category c)
        {
                if(c.CategoryName.Length<=4)
            {
                return -1;
            }
                else
            {
                return categoryRepo.Insert(c);
            }
        }

    }
}

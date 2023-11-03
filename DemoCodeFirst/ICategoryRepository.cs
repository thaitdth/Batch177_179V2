using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        void Insert(Category category);
        void Update(Category category);
        void Delete(Category category);
        bool CheckCategoryID(int id);
    }
}

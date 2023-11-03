using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAll() => CategoryDao.Instance.GetCategories();
        public void Insert(Category category) => CategoryDao.Instance.Insert(category);
        public void Update (Category category) => CategoryDao.Instance.Update(category);
        public void Delete(Category category) => CategoryDao.Instance.Delete(category);
        public bool CheckCategoryID(int id) => CategoryDao.Instance.CheckCategoryID(id);
    }
}

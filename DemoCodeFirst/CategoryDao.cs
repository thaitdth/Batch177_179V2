using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
{
    public class CategoryDao
    {
        private static CategoryDao instance;
        private static readonly object instanceLock = new object();
        public static CategoryDao Instance
        {
            get 
            { 
                lock (instanceLock) 
                { 
                    if (instance == null)
                    {
                        instance = new CategoryDao();
                    }
                    return instance;
                }
            }
        }
        public List<Category> GetCategories()
        {
            List<Category> categories;
            try
            {
                using MyStockDBContext stock = new MyStockDBContext();
                categories = stock.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categories;
        }
        public void Insert(Category category)
        {
            try 
            {
                using MyStockDBContext stock = new MyStockDBContext();
                stock.Add(category);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Category category)
        {
            try
            {
                using MyStockDBContext stock = new MyStockDBContext();
                stock.Entry<Category>(category).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool CheckCategoryID(int id)
        {
            try
            {
                using MyStockDBContext stock = new MyStockDBContext();
                var category = stock.Categories.SingleOrDefault(c => c.CategoryID==id);
                if (category != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
{
    public class Program
    {
        private ICategoryRepository _categoryRepository = null;
        public Program() { _categoryRepository = new CategoryRepository(); }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.GetListCategory();
            Console.WriteLine("---------------------");
            Console.WriteLine("Insert new Category: ");
            Category category = new Category();
            category.CategoryName = GetString("Input Category Name: ");
            p._categoryRepository.Insert(category);
            p.GetListCategory();
            Console.WriteLine("---------------------");
            Console.WriteLine("Update Category: ");
            int id = GetInt("Input Id: ");
            if (CategoryDao.Instance.CheckCategoryID(id))
            {
                category.CategoryID = id;
                category.CategoryName = GetString("Input Category Name: ");
            }
            p._categoryRepository.Update(category);
            p.GetListCategory();
            Console.WriteLine("---------------------");
            Console.WriteLine("Delete Category: ");
            id = GetInt("Input Id: ");
            if (p._categoryRepository.CheckCategoryID(id))
            {
                category.CategoryID = id;
            }
            p._categoryRepository.Delete(category);
            p.GetListCategory();
        }

        public static int GetInt(string mes)
        {
            Console.WriteLine(mes);
            return Convert.ToInt32(Console.ReadLine());
        }

        public void GetListCategory()
        {
            Console.WriteLine("Get list of Category: ");
            foreach (var i in _categoryRepository.GetAll())
            {
                Console.WriteLine($"{i.CategoryID}-{i.CategoryName}");
            }
        }

        public static string GetString(string mes)
        {
            Console.WriteLine(mes);
            return Console.ReadLine();
        }
    }
}
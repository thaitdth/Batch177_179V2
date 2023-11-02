using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            GetListCategory();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Insert new category: ");
            Category category = new Category();
            category.CategoryName = GetString("Input Category Name: ");
            CategoryDao.Instance.Insert(category);
            GetListCategory();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Update Category: ");
            int id = GetInt("Input Id: ");
            if (CategoryDao.Instance.CheckCategoryID(id))
            {
                category.CategoryID = id;
                category.CategoryName = GetString("Input Category Name: ");
            }
            CategoryDao.Instance.Update(category);
            GetListCategory();
        }
        public static int GetInt(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void GetListCategory()
        {
            Console.WriteLine("Get List of Category:");
            foreach (var i in CategoryDao.Instance.GetCategories())
            {
                Console.WriteLine($"{i.CategoryID} - {i.CategoryName}");
            }
        }
        public static string GetString(string mes)
        {
            Console.WriteLine(mes);
            return Console.ReadLine();
        }
    }
}

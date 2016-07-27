using PiggyBankCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PiggyBankCore.Services
{
    public class CategoryServices
    {
        private List<Category> categoryDB = new List<Category>() 
        { 
            new Category("All","LightGray") {ID = -1},
            new Category("Supermarket","ForestGreen") {ID = 1},
            new Category("Electronics","Yellow") {ID = 2},
            new Category("Vacation","LightSeaGreen") {ID = 3},
            new Category("Utilities","OrangeRed") {ID = 4},
            new Category("Apartment","PaleGoldenrod") {ID = 5}
        };

        public void AddCategory(string categoryName, string categoryColour)
        {
            categoryDB.Add(new Category(categoryName, categoryColour));            
        }

        public Category EditCategory(string newCategoryName, string newCategoryColour, Category categoryForUpdate)
        {
            categoryForUpdate.Name = newCategoryName;
            categoryForUpdate.Colour = newCategoryColour;

            return categoryForUpdate;
        }

        public void DeleteCategory(Category categoryForDelete)
        {
            categoryDB.Remove(categoryForDelete);
        }

        public Category GetDefaultCategory()
        {
            return categoryDB.Find(category => category.ID == -1);
        }

        public List<Category> GetCategoryDb()
        {
            return categoryDB;
        }
    

        //private string AddOrEditValidation(string newCategoryName, string newCategoryColour)
        //{
        //    string errorText = "";

        //    if (categoryDB.Find(category => category.CategoryName == newCategoryName) != null)
        //    {
        //        errorText = "Category with this name already exists!";
        //        return errorText;
        //    }

        //    if (categoryDB.Find(category => category.CategoryColour == newCategoryColour) != null)
        //    {
        //        errorText = "This colour is already used by another category!";
        //        return errorText;
        //    }

        //    return errorText;

        //}
    }
}

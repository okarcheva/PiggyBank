using PiggyBankCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankCore.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public IEnumerable<Category> List
        {
            get
            {
                IEnumerable<Category> categoriesList;
                using (var context = new PiggyBankContext())
                {
                    categoriesList = context.Categories.ToList();
                }
                return categoriesList;
            }
        }

        public void Add(Category entity)
        {
            using (var context = new PiggyBankContext())
            {
                try
                {
                    context.Categories.Add(entity);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } 
        }

        public void Delete(Category entity)
        {
            using (var context = new PiggyBankContext())
            {
                context.Categories.Remove(entity);
                context.SaveChanges();
            }
        }

        public Category FindById(int Id)
        {
            Category category;
            using (var context = new PiggyBankContext())
            {
                category = context.Categories.Where(x => x.ID == Id).First();
            }
            return category;
        }

        public void Update(Category entity)
        {
            using (var context = new PiggyBankContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

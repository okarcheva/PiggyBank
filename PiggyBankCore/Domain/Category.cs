using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PiggyBankCore.Repositories;

namespace PiggyBankCore.Domain
{
    public class Category : TEntity
    {
        public string Name { get; set; }
        public string Colour { get; set; }    
        public virtual ICollection<Operation> Operations { get; set; }

        public Category()
        {
            Operations = new List<Operation>();
        }

        public Category(string categoryName)
            : this(categoryName, "LightGray") {}

        public Category(string categoryName, string categoryColour)
        {
            Name = categoryName;
            Colour = categoryColour;

            Operations = new List<Operation>();
        }
    }
}

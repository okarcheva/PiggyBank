using PiggyBankCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankCore.Domain
{
    public class FamilyMember : TEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
        public FamilyMember()
        {
            Operations = new List<Operation>();
        }
        public FamilyMember(string name)
        {
            Operations = new List<Operation>();
            Name = name;
        }
    }
}

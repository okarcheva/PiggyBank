using PiggyBankCore.Enum;
using PiggyBankCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankCore.Domain
{

    public class Operation : TEntity    
    {
        public decimal Amount { get; set; }
        public OperationType Status { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int FamilyMemberId { get; set; }
        public virtual FamilyMember FamilyMember { get; set; }
        public string Notes { get; set; }

        public Operation() { }

        public Operation(decimal amount, OperationType status, DateTime date, Category category, FamilyMember familyMember)
            :this(amount,status,date,category,familyMember,""){}


        public Operation(decimal amount, OperationType status, DateTime date, Category category, FamilyMember familyMember, string notes)
        {
            Amount = amount;
            Status = status;
            Date = date;
            Category = category;
            FamilyMember = familyMember;
            Notes = notes;
        }
    }
}

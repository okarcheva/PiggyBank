using PiggyBankCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankCore.Repositories
{
    public class FamilyMemberRepository : IRepository<FamilyMember>
    {
        public IEnumerable<FamilyMember> List
        {
            get
            {
                IEnumerable<FamilyMember> familyMembersList;

                using (var context = new PiggyBankContext())
                {
                    familyMembersList = context.FamilyMembers.ToList();
                }

                return familyMembersList;
            }
        }

        public void Add(FamilyMember entity)
        {             
            using (var context = new PiggyBankContext())
            {
                try
                {
                    context.FamilyMembers.Add(entity);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Delete(FamilyMember entity)
        {
            using (var context = new PiggyBankContext())
            {
                context.FamilyMembers.Remove(entity);
                context.SaveChanges();
            }
        }

        public FamilyMember FindById(int Id)
        {
            FamilyMember familyMember;

            using (var context = new PiggyBankContext())
            {
                familyMember = context.FamilyMembers.Where(member => member.ID == Id).First();                
            }

            return familyMember;
        }

        public void Update(FamilyMember entity)
        {
            using (var context = new PiggyBankContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

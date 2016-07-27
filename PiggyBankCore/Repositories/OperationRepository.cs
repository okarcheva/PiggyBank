using PiggyBankCore.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System;

namespace PiggyBankCore.Repositories
{
    public class OperationRepository : IRepository<Operation>
    {
        public IEnumerable<Operation> List
        {
            get
            {
                IEnumerable<Operation> operationsList;
                using (var context = new PiggyBankContext())
                {
                    operationsList = context.Operations.Include(x => x.Category).Include(x => x.FamilyMember).ToList();
                }
                return operationsList;
            }
        }

        public void Add(Operation entity)
        {
            using (var context = new PiggyBankContext())
            {
                try
                {
                    context.Operations.Add(entity);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Delete(Operation entity)
        {
            using (var context = new PiggyBankContext())
            {
                context.Operations.Attach(entity);
                context.Operations.Remove(entity);
                context.SaveChanges();
            }
        }

        public Operation FindById(int Id)
        {
            Operation operation;
            using (var context = new PiggyBankContext())
            {
                operation = context.Operations.Where(x => x.ID == Id).Include(x => x.FamilyMember).Include(x => x.Category).First();
            }
            return operation;
        }

        public void Update(Operation entity)
        {
            using (var context = new PiggyBankContext())
            {
                try
                {
                    entity.FamilyMember = null;
                    entity.Category = null;
                     
                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
